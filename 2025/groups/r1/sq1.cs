#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_sq1-r1,
             RoundOneAssignmentSets(_sq1, 2025-07-06, MAIN_SQ1, SIDE_SQ1),
             Concat(DefaultScorers(2025-07-06),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-06T10:30), -100)]))
