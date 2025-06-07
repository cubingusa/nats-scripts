#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333oh-r1,
             RoundOneAssignmentSets(_333oh, 2025-07-03, MAIN_333OH, SIDE_333OH),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(Or(CompetingIn(_333mbf), BooleanProperty(MULTI_VOLUNTEER)),
                               (StartTime() < 2025-07-03T14:30), -100),
                     ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (EndTime() > 2025-07-03T15:00), -100),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013WALL03),
                                  IsStageLeadTogether(Arg<Person>(), 2017KELL08),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-03T13:00, 2025-07-03T14:15), -5),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-03T15:15, 2025-07-03T16:30), -5),
                     ByFilters((WcaId() == "2015MACK06"),
                               Not(Overlaps(2025-07-03T14:15, 2025-07-03T15:00)), 10),
                     ByFilters(IsStageLeadTogether(Arg<Person>(), 2015MACK06),
                               Not(Overlaps(2025-07-03T14:15, 2025-07-03T15:00)), 5),
                     ByFilters((WcaId() == "2018DAIN02"),
                               (EndTime() <= 2025-07-03T15:15), 10)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_333oh))),
               _333oh-r1, MAIN_ORANGE, 1)

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
