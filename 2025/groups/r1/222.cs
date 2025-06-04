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
                               (EndTime() > 2025-07-04T11:45), -100),
                     ByFilters(Or((WcaId() == "2015KUCA01"),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               (StartTime() >= 2025-07-04T10:30), 10),
                     ByFilters(In(Arg<Person>(), [2014GOSL01, 2011HOLL04]),
                               (EndTime() <= 2025-07-04T10:30), 10)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_222))),
               _222-r1, SIDE_ORANGE, 10)
