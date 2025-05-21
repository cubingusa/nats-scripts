#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_pyram-r1,
             RoundOneAssignmentSets(_pyram, 2025-07-03, MAIN_PYRAM, SIDE_PYRAM),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(CompetingIn(_333fm), (StartTime() < 2025-07-03T16:40), -100),
                     ByFilters(PossiblyWillAdvance(_clock-r2, Arg<Person>()),
                               (EndTime() > 2025-07-03T17:05), -100),
                     ByFilters(PossiblyWillAdvance(_555-r2, Arg<Person>()),
                               (EndTime() > 2025-07-03T17:15), -100),
                     ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-03T17:00), -100)]))
