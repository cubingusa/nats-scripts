#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_555-r1,
             RoundOneAssignmentSets(_555, 2025-07-03, MAIN_555, SIDE_555),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(CompetingIn(_333mbf), (EndTime() > 2025-07-03T12:30), -100)]))
