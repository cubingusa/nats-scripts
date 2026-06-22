#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_volunteers.cs"

Define("MultiOverlap", And((EndTime() > 2026-07-04T13:00), (StartTime() < 2026-07-04T14:45)))
Define("Sets", RoundOneAssignmentSets({1, Event}, 2026-07-04))
Define("Scorers", DefaultScorers(2026-07-04, {1, Event}))

AssignGroups(_333bf-r1, Sets(_333bf), Scorers(_333bf))
AssignGroups(_skewb-r1, Sets(_skewb),
             Concat(Scorers(_skewb),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (GroupNumber() > 7), -10)]))

AssignGroups(_333-r1, Sets(_333),
             Concat(Scorers(_333),
                    [ByFilters(Or(Multi2Volunteer(), CompetingIn(_333mbf)),
                               MultiOverlap(Arg<Group>()), -20)]))

AssignGroups(_777-r1, Sets(_777),
             Concat(Scorers(_777),
                    [ByFilters(BooleanProperty(COMMENTATOR),
                               (GroupNumber() == 2), -10)]))

#include "../lib/_assignment_table.cs"
AssignmentTable(
    Sort(Persons(IsStageLead()),
         AssignedStage(Arg<Person>(), 2026-07-04)),
    [_333bf-r1, _skewb-r1, _333-r1, _777-r1],
    [Column("Stage", AssignedStage(Arg<Person>(), 2026-07-04))])
