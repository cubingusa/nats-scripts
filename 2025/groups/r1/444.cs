#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_444-r1,
             RoundOneAssignmentSets(_444, 2025-07-04, MAIN_444, SIDE_444),
             Concat(DefaultScorers(),
                    [ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (StartTime() >= 2025-07-04T15:00), -100),
                     ByFilters((StringProperty(ACCOMMODATION) == NO_FRIDAY_EARLY_AFTERNOON),
                               (StartTime() >= 2025-07-04T15:00), 100)]))
