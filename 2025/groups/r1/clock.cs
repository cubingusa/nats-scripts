#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2025-07-03, MAIN_CLOCK, SIDE_CLOCK),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(BooleanProperty(MULTI_VOLUNTEER), (EndTime() <= 2025-07-03T10:00), 10),
                     ByFilters(BooleanProperty(MULTI_VOLUNTEER), (EndTime() <= 2025-07-03T10:15), 5),
                     ByFilters((WcaId() == "2012CANT02"),
                               Or((StartTime() >= 2025-07-03T11:00),
                                  (EndTime() <= 2025-07-03T10:00)), 10)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_clock))),
               _clock-r1, SIDE_RED, 1)

"Sanity Check - 5BLD competitors"
Table(
    Sort(Persons(And(CompetingIn(_555bf), CompetingIn(_clock))), StartTime(AssignedGroup(_clock-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_clock-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_clock-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_clock-r1)))])
