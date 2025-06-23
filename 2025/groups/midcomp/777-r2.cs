#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_777-r2, SemifinalAssignmentSets(_777-r2), DefaultScorers(2025-07-05))

"Potential Skewb conflicts"
Table(
    Sort(Persons(And(CompetingInRound(_777-r2),
                     CompetingIn(_skewb),
                     (EndTime(AssignedGroup(_skewb-r1) > 2025-07-05T11:05)))),
         StartTime(AssignedGroup(_skewb-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_skewb-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_skewb-r1))))),
     Column("EndTime", StartTime(AssignedGroup(_skewb-r1)))])

