#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333bf-r1,
             RoundOneAssignmentSets(_333bf, 2025-07-05, MAIN_333BF, SIDE_333BF),
             DefaultScorers(2025-07-05))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_333bf))),
               _333bf-r1, SIDE_GREEN, 1)
