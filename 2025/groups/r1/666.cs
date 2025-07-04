#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_666-r1,
             RoundOneAssignmentSets(_666, 2025-07-05, MAIN_666, SIDE_666),
             Concat(DefaultScorers(2025-07-05),
                    [ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (StartTime() < 2025-07-05T16:40), -100),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-05T15:15, 2025-07-05T16:30), -5),
                     ByFilters(PossiblyWillAdvance(_555-r3, Arg<Person>()),
                               (EndTime() > 2025-07-05T17:05), -100),
                     ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-05T17:00), -100)]))
