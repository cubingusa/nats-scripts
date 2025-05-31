#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_777-r1,
             RoundOneAssignmentSets(_777, 2025-07-04, MAIN_777, SIDE_777),
             Concat([DefaultScorers(2025-07-04),
                     ByFilters((Arg<Person>() == 2015KUCA01),
                               (EndTime() <= 2025-07-04T09:30), 10)]))
