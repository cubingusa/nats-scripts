#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_volunteers.cs"

Define("MultiOverlap", And((EndTime() > 2026-07-02T12:45), (StartTime() < 2026-07-02T14:15)))
Define("Sets", RoundOneAssignmentSets({1, Event}, 2026-07-02))
Define("Scorers", DefaultScorers(2026-07-02, {1, Event}))

AssignGroups(_555bf-r1, Sets(_555bf), Scorers(_555bf),
             stationRules=[StationAssignmentRule(true, "ascending", PsychSheetPosition(_555bf),
                                                 stationExclusionRules=[NonNAStream()])])
AssignGroups(_555-r1, Sets(_555), Scorers(_555))
AssignGroups(_clock-r1, Sets(_clock), Scorers(_clock))

AssignGroups(_333oh-r1, Sets(_333oh),
             Concat(Scorers(_333oh),
                    [ByFilters(Or(Multi1Volunteer(), CompetingIn(_333mbf)),
                               MultiOverlap(Arg<Group>()), -20)]))
AssignGroups(_pyram-r1, Sets(_pyram),
             Concat(Scorers(_pyram),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (GroupNumber() > 7), -10)]))

"Sanity Check - Stage Lead assignments"
#include "../lib/_assignment_table.cs"
AssignmentTable(
    Sort(Persons(IsStageLead()),
         AssignedStage(Arg<Person>(), 2026-07-02)),
    [_555-r1, _clock-r1, _333oh-r1, _pyram-r1],
    [Column("Stage", AssignedStage(Arg<Person>(), 2026-07-02))])
