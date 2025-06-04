#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_group_counts.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_scorers.cs"

AssignGroups(_pyram-r1,
             RoundOneAssignmentSets(_pyram, 2025-07-03, MAIN_PYRAM, SIDE_PYRAM),
             Concat(DefaultScorers(2025-07-03),
                    [ByFilters(Or(CompetingIn(_333fm), BooleanProperty(FMC_VOLUNTEER)),
                               (StartTime() < 2025-07-03T16:40), -100),
                     ByFilters(Or(IsStageLeadTogether(Arg<Person>(), 2013DIPI01),
                                  IsStageLeadTogether(Arg<Person>(), 2015KUCA01)),
                               Overlaps(2025-07-03T15:15, 2025-07-03T16:30), -5),
                     ByFilters(PossiblyWillAdvance(_clock-r2, Arg<Person>()),
                               (EndTime() > 2025-07-03T17:05), -100),
                     ByFilters(PossiblyWillAdvance(_555-r2, Arg<Person>()),
                               (EndTime() > 2025-07-03T17:15), -100),
                     ByFilters(BooleanProperty(COMMENTATOR),
                               (EndTime() > 2025-07-03T17:00), -100),
                     ByFilters((WcaId() == "2016MORA24"),
                               (StartTime() >= 2025-07-03T16:30), 10)]))

ManuallyAssign(Persons(And(BooleanProperty(WCA_BOARD),
                           CompetingIn(_pyram))),
               _pyram-r1, SIDE_RED, 9)

"Sanity Check - FMC competitors"
Table(
    Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_pyram))), StartTime(AssignedGroup(_pyram-r1))),
    [Column("Name", Name()),
     Column("Group", ((Stage(AssignedGroup(_pyram-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_pyram-r1))))),
     Column("StartTime", StartTime(AssignedGroup(_pyram-r1)))])

"Sanity Check - OH competitors changing rooms"
Table(
    Sort(Persons(And(CompetingIn(_333oh), CompetingIn(_pyram),
                     (Room(AssignedGroup(_pyram-r1)) != Room(AssignedGroup(_333oh-r1))))),
         StartTime(AssignedGroup(_pyram-r1))),
    [Column("Name", Name()),
     Column("Pyra", ((Stage(AssignedGroup(_pyram-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_pyram-r1))))),
     Column("OH", ((Stage(AssignedGroup(_333oh-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_333oh-r1))))),
     Column("OH EndTime", EndTime(AssignedGroup(_333oh-r1))),
     Column("Pyra StartTime", StartTime(AssignedGroup(_pyram-r1)))])
