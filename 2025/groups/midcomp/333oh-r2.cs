#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333oh-r2, SemifinalAssignmentSets(_333oh-r2), DefaultScorers(2025-07-04))

"Potential 2x2 conflicts"
Table(
    Sort(Persons(And(CompetingInRound(_333oh-r2),
                     CompetingIn(_222),
                     (EndTime(AssignedGroup(_222-r1) > 2025-07-04T11:50)))),
         StartTime(AssignedGroup(_222-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_222-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_222-r1))))),
     Column("EndTime", StartTime(AssignedGroup(_222-r1)))])

