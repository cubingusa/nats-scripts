#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333-r1,
             RoundOneAssignmentSets(_333, 2025-07-05, MAIN_333, SIDE_333),
             Concat(DefaultScorers(2025-07-05),
                    [ByFilters(Or(CompetingIn(_333mbf), BooleanProperty(MULTI_VOLUNTEER)),
                               (StartTime() < 2025-07-05T14:30), -100),
                     ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (EndTime() > 2025-07-05T15:00), -100)]))

ManuallyAssign(Persons(And(CompetingIn(_333-r1),
                           (StringProperty(ACCOMMODATION) == NO_SATURDAY))),
               _333-r1, MAIN_GREEN, 1)

ManuallyAssign([2010THOM03, 2016SILV08], MAIN_RED, 1)
ManuallyAssign([2018SMIT42], MAIN_BLUE, 1)
