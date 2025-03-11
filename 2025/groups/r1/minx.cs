#include "../../lib/_advancement.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_minx-r1,
             RoundOneAssignmentSets(_minx, 2025-07-04, MAIN_MINX, SIDE_MINX),
             Concat(DefaultScorers(),
                    [ByFilters(CompetingIn(_333fm), (StartTime() < 2025-07-04T16:45), -100),
                     ByFilters(PossiblyWillAdvance(_555-r3, Arg<Person>()),
                               (EndTime() > 2025-07-04T17:05), -100)]))
