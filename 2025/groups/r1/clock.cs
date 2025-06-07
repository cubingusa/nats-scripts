#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2025-07-03, MAIN_CLOCK, SIDE_CLOCK),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(BooleanProperty(MULTI_VOLUNTEER), (EndTime() <= 2025-07-03T10:00), 10),
                     ByFilters(BooleanProperty(MULTI_VOLUNTEER), (EndTime() <= 2025-07-03T10:15), 5),
                     ByFilters((WcaId() == "2012CANT02"),
                               Not(Overlaps(2025-07-03T10:00, 2025-07-03T11:00)), 10),
                     ByFilters(IsStageLeadTogether(Arg<Person>(), 2012CANT02),
                               Not(Overlaps(2025-07-03T10:00, 2025-07-03T11:00)), 5),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                                  IsStageLeadTogether(Arg<Person>(), 2013WALL03),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01),
                                  IsStageLeadTogether(Arg<Person>(), 2009LIUE01)),
                               Not(Overlaps(2025-07-03T09:00, 2025-07-03T10:00)), 5)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_clock))),
               _clock-r1, MAIN_GREEN, 6)

"Sanity Check - 5BLD competitors"
Table(
    Sort(Persons(And(CompetingIn(_555bf), CompetingIn(_clock))), StartTime(AssignedGroup(_clock-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_clock-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_clock-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_clock-r1)))])
