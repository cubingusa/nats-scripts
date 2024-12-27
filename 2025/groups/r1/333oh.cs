#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333oh-r1,
             RoundOneAssignmentSets(_333oh, 2025-07-03, MAIN_333OH, SIDE_333OH),
             Concat(DefaultScorers(),
                    [ByFilters(CompetingIn(_333mbf), (StartTime() < 2025-07-03T14:30), -100),
                     ByFilters(CompetingIn(_333fm), (EndTime() > 2025-07-03T15:00), -100)]))
