#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_555-r1,
             RoundOneAssignmentSets(_555, 2025-07-03, MAIN_555, SIDE_555),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(CompetingIn(_333mbf), (EndTime() > 2025-07-03T12:30), -100),
                     ByFilters(BooleanProperty(MULTI_VOLUNTEER), (StartTime() > 2025-07-03T12:00), 10),
                     ByFilters((WcaId() == "2013DIPI01"),
                               (EndTime() <= 2025-07-03T11:45), 10),
                     ByFilters(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                               (EndTime() <= 2025-07-03T11:45), 5)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_555))),
               _555-r1, MAIN_WHITE, 1)

"Sanity Check - Clock competitors changing rooms"
Table(
    Sort(Persons(And(CompetingIn(_clock), CompetingIn(_555),
                     (Room(AssignedGroup(_555-r1)) != Room(AssignedGroup(_clock-r1))))),
         StartTime(AssignedGroup(_555-r1))),
    [Column("Name", Name()),
     Column("555", ((Stage(AssignedGroup(_555-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_555-r1))))),
     Column("clock", ((Stage(AssignedGroup(_clock-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_clock-r1))))),
     Column("clock EndTime", EndTime(AssignedGroup(_clock-r1))),
     Column("555 StartTime", StartTime(AssignedGroup(_555-r1)))])
