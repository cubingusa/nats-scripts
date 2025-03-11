#include "../../lib/_advancement.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_skewb-r1,
             RoundOneAssignmentSets(_skewb, 2025-07-05, MAIN_SKEWB, SIDE_SKEWB),
             Concat(DefaultScorers(),
                    [ByFilters(PossiblyWillAdvance(_777-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:00), -100),
                     ByFilters(PossiblyWillAdvance(_minx-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:20), -100),
                     ByFilters(PossiblyWillAdvance(_444-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:40), -100),
                     ByFilters(PossiblyWillAdvance(_222-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T12:00), -100)]))
