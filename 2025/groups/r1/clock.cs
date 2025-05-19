#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2025-07-03, MAIN_CLOCK, SIDE_CLOCK),
             DefaultScorers())


"Sanity Check - 5BLD competitors"
Table(
    Sort(Persons(And(CompetingIn(_555bf), CompetingIn(_clock))), StartTime(AssignedGroup(_clock-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_clock-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_clock-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_clock-r1)))])
