#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_volunteers.cs"

Define("FMC1Overlap", And((EndTime() > 2026-07-03T08:45), (StartTime() < 2026-07-03T10:30)))
Define("FMC2Overlap", And((EndTime() > 2026-07-03T12:45), (StartTime() < 2026-07-03T14:30)))
Define("FMC3Overlap", And((EndTime() > 2026-07-03T14:00), (StartTime() < 2026-07-03T15:45)))
Define("Sets", RoundOneAssignmentSets({1, Event}, 2026-07-03))
Define("Scorers", DefaultScorers(2026-07-03, {1, Event}))

AssignGroups(_222-r1, Sets(_222),
             Concat(Scorers(_222),
                    [ByFilters(Or(FMC1Volunteer(), CompetingIn(_333fm)),
                               FMC1Overlap(Arg<Group>()), -20)]))
AssignGroups(_666-r1, Sets(_666),
             Concat(Scorers(_666),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (GroupNumber() == 2), -10)]))

AssignGroups(_444-r1,
             Concat([AssignmentSet(
                         "Special - Green Stage Leads",
                         And(IsStageLead(),
                             (AssignedStage(Arg<Person>(), 2026-07-03) == GREEN),
                             (Name() != "Zeke Mackay")),
                         And((GroupNumber() >= 8), (Stage() == GREEN)))],
                    Sets(_444)),
             Concat(Scorers(_444),
                    [ByFilters(Or(FMC2Volunteer(), CompetingIn(_333fm)),
                               FMC2Overlap(Arg<Group>()), -20),
                     ByFilters(Or(FMC3Volunteer(), CompetingIn(_333fm)),
                               FMC3Overlap(Arg<Group>()), -20),
                     ByFilters(And(IsStageLead(), (AssignedStage(Arg<Person>(), 2026-07-03) == GREEN)),
                               (GroupNumber() < 8), -10),
                     ByFilters(And(IsStageLead(), (AssignedStage(Arg<Person>(), 2026-07-03) == ORANGE)),
                               In(GroupNumber(), [4, 5, 6, 7]), -10)
                    ]))

AssignGroups(_sq1-r1, Sets(_sq1),
             Concat(Scorers(_sq1),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (GroupNumber() == 2), -10)]))

#include "../lib/_assignment_table.cs"
AssignmentTable(
    Sort(Persons(IsStageLead()),
         AssignedStage(Arg<Person>(), 2026-07-03)),
    [_222-r1, _666-r1, _444-r1, _sq1-r1],
    [Column("Stage", AssignedStage(Arg<Person>(), 2026-07-03))])
