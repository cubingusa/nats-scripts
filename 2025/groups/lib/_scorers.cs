#include "../../lib/_assigned_stage.cs"
#include "../../lib/_constants.cs"
#include "_name_clusters.cs"

#define EVEN_STAGES [MAIN_RED, MAIN_GREEN, MAIN_ORANGE, SIDE_BLUE, SIDE_GREEN]
#define ODD_STAGES [MAIN_BLUE, MAIN_YELLOW, MAIN_WHITE, SIDE_RED, SIDE_ORANGE]

Define("DefaultScorers",
       Concat([ByMatchingValue(FirstNameCluster(), -5),
               ByMatchingValue(Country(), 4, limit=2),
               ByMatchingValue(Country(), -1),
               # Put competitors in Chinese-speaking countries on one of the stages with a Chinese-speaking stage lead.
               ByFilters(In(Country(), ["CN", "HK", "TW", "SG", "MO"]),
                         In(Stage(), [MAIN_RED, MAIN_GREEN, SIDE_RED]), 10),
               # Prefer groups 2^k+1. This makes sure that smaller AssignmentSets are effectively spread out, rather than e.g. putting all of the stage leads back-to-back.
               ByFilters(true, (Mod(GroupNumber(), 2) == If(In(Stage(), EVEN_STAGES), 1, 0)), 1),
               ByFilters(true, (Mod(GroupNumber(), 4) == If(In(Stage(), EVEN_STAGES), 1, 2)), 1),
               ByFilters(true, (Mod(GroupNumber(), 8) == If(In(Stage(), EVEN_STAGES), 1, 2)), 1),
               # But, we don't want stage leads to end up in these groups for other assignment sets, so even more strongly promote these groups for non-stage-leads.
               ByFilters(Not(IsStageLead(Arg<Person>())),
                         (Mod(GroupNumber(), 2) == If(In(Stage(), EVEN_STAGES), 1, 0)), 1),
               ByFilters(Not(IsStageLead(Arg<Person>())),
                         (Mod(GroupNumber(), 4) == If(In(Stage(), EVEN_STAGES), 1, 2)), 1),
               ByFilters(Not(IsStageLead(Arg<Person>())),
                         (Mod(GroupNumber(), 8) == If(In(Stage(), EVEN_STAGES), 1, 2)), 1),
               RecentlyCompeted(In(Stage(), MainStages()), In(Stage(), MainStages()),
                                Min([((Arg<Number>() - 30) / 10), 0])),
               RecentlyCompeted(In(Stage(), SideStages()), In(Stage(), MainStages()),
                                Min([((Arg<Number>() - 60) / 10), 0])),
               RecentlyCompeted(In(Stage(), SideStages()), In(Stage(), SideStages()),
                                Min([((Arg<Number>() - 30) / 10), 0])),
               RecentlyCompeted(In(Stage(), MainStages()), In(Stage(), SideStages()),
                                Min([((Arg<Number>() - 60) / 10), 0]))],
              Map(AllStages(),
                  ByFilters((AssignedStage(Arg<Person>(), {1, Date}) == Arg<String>()),
                            (Stage() == Arg<String>()), 10))))
