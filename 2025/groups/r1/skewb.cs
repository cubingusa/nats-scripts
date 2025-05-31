#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_skewb-r1,
             RoundOneAssignmentSets(_skewb, 2025-07-05, MAIN_SKEWB, SIDE_SKEWB),
             Concat(DefaultScorers(2025-07-05),
                    [ByFilters(PossiblyWillAdvance(_777-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:00), -100),
                     ByFilters(PossiblyWillAdvance(_minx-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:20), -100),
                     ByFilters(PossiblyWillAdvance(_444-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T11:40), -100),
                     ByFilters(PossiblyWillAdvance(_222-r2, Arg<Person>()),
                               (EndTime() > 2025-07-05T12:00), -100),
                     ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-05T11:00), -100),
                     ByFilters(BooleanProperty(MULTI_VOLUNTEER),
                               Or((EndTime() < 2025-07-05T10:00),
                                  (StartTime() >= 2025-07-05T12:00)), 10),
                     ByFilters((Arg<Person>() == 2007STRO01),
                               (StartTime() >= 2025-07-05T10:30), 10),
                     ByFilters((Arg<Person>() == 2020LONG05),
                               (EndTime() <= 2025-07-05T10:30), 10)]))

ManuallyAssign(Persons(And(CompetingIn(_skewb-r1),
                           (StringProperty(ACCOMMODATION) == NO_SATURDAY))),
               _skewb-r1, MAIN_GREEN, 1)

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_skewb-r1))),
               _skewb-r1, SIDE_RED, 9)
