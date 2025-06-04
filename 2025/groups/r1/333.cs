#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333-r1,
             RoundOneAssignmentSets(_333, 2025-07-05, MAIN_333, SIDE_333),
             Concat(DefaultScorers(2025-07-05),
                    [ByFilters(Or(CompetingIn(_333mbf), BooleanProperty(MULTI_VOLUNTEER)),
                               (StartTime() < 2025-07-05T14:30), -100),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013WALL03),
                                  IsStageLeadTogether(Arg<Person>(), 2017KELL08),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-05T13:00, 2025-07-05T14:15), -5),
                     ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (EndTime() > 2025-07-05T15:00), -100),
                     ByFilters(Or((WcaId() == "2016LOPE37"),
                                  IsStageLeadTogether(Arg<Person>(), 2016LOPE37)),
                               Or((EndTime() <= 2025-07-05T14:30),
                                  (StartTime() >= 2025-07-05T15:30)), 10),
                     ByFilters((WcaId() == "2012ICKL01"),
                               (EndTime() <= 2025-07-05T15:15), 10),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-05T15:15, 2025-07-05T16:30), -5),
                     ByMatchingValue(If((WcaId() == "2023PETR15"), "2012PARK03", WcaId()), 100),
                     ByFilters((WcaId() == "2009HAYS01"), (GroupNumber() == 1), 10),
                     ByFilters((WcaId() == "2009ZEMD01"), (GroupNumber() == 2), 10)]))

ManuallyAssign(Persons(And(CompetingIn(_333),
                           (StringProperty(ACCOMMODATION) == NO_SATURDAY))),
               _333-r1, MAIN_GREEN, 1)

ManuallyAssign([2010THOM03, 2016SILV08], _333-r1, MAIN_RED, 1)
ManuallyAssign([2018SMIT42], _333-r1, MAIN_BLUE, 1)
