#include "../lib/_midcomp.cs"
AssignSemifinals(_555-r2)

"Sanity Check - pyra competitors"
Table(
    Sort(Persons(And(CompetingInRound(_555-r2), CompetingIn(_pyram))), StartTime(AssignedGroup(_pyram-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_pyram-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_pyram-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_pyram-r1)))])
