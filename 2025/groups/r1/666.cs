#include "../../lib/_advancement.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_666-r1,
             RoundOneAssignmentSets(_666, 2025-07-05, MAIN_666, SIDE_666),
             Concat(DefaultScorers(),
                    [ByFilters(CompetingIn(_333fm), (StartTime() < 2025-07-05T16:40), -100),
                     ByFilters(PossiblyWillAdvance(_555-r3, Arg<Person>()),
                               (EndTime() > 2025-07-05T17:05), -100)]))
