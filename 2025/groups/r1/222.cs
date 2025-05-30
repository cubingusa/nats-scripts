#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_222-r1,
             RoundOneAssignmentSets(_222, 2025-07-04, MAIN_222, SIDE_222),
             Concat(DefaultScorers(2025-07-04),
                    [ByFilters(PossiblyWillAdvance(_333oh-r2, Arg<Person>()),
                               (EndTime() > 2025-07-04T11:30), -100),
                     ByFilters(PossiblyWillAdvance(_pyram-r2, Arg<Person>()),
                               (EndTime() > 2025-07-04T12:00), -100),
                     ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-04T11:45), -100)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_222-r1))),
               _222-r1, MAIN_ORANGE, 3)
