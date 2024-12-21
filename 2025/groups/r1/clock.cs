#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2025-07-03, MAIN_CLOCK, SIDE_CLOCK),
             DefaultScorers())
