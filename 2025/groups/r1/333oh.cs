#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333oh-r1,
             RoundOneAssignmentSets(_333oh, 2025-07-03, MAIN_333OH, SIDE_333OH),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(Or(CompetingIn(_333mbf), BooleanProperty(MULTI_VOLUNTEER)),
                               (StartTime() < 2025-07-03T14:30), -100),
                     ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (EndTime() > 2025-07-03T15:00), -100)]))

"Sanity Check - Multi competitors"
Table(
    Sort(Persons(And(CompetingIn(_333mbf), CompetingIn(_333oh))), StartTime(AssignedGroup(_333oh-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_333oh-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_333oh-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_333oh-r1)))])

"Sanity Check - FMC competitors"
Table(
    Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_333oh))), EndTime(AssignedGroup(_333oh-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_333oh-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_333oh-r1))))),
     Column("EndTime", EndTime(AssignedGroup(_333oh-r1)))])
