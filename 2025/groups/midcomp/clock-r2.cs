#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_clock-r2, SemifinalAssignmentSets(_clock-r2), DefaultScorers(2025-07-03))

"Potential Pyra conflicts"
Table(
    Sort(Persons(And(CompetingInRound(_clock-r2),
                     CompetingIn(_pyram),
                     (EndTime(AssignedGroup(_pyram-r1) > 2025-07-03T17:00)))),
         StartTime(AssignedGroup(_pyram-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_pyram-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_pyram-r1))))),
     Column("EndTime", StartTime(AssignedGroup(_pyram-r1)))])

