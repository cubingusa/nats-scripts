#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

Define("MultiOverlap", And((EndTime() > 2024-07-19T11:40), (StartTime() < 2024-07-19T13:30)))
Define("FMCOverlap", And((EndTime() > 2024-07-19T14:00), (StartTime() < 2024-07-19T16:00)))

AssignGroups(_333bf-r1,
             RoundOneAssignmentSets(_333bf, 2024-07-19),
             DefaultScorers(2024-07-19))

AssignGroups(_777-r1,
             RoundOneAssignmentSets(_777, 2024-07-19),
             DefaultScorers(2024-07-19))

AssignGroups(_pyram-r1,
             RoundOneAssignmentSets(_pyram, 2024-07-19),
             Concat(DefaultScorers(2024-07-19),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingFridayMulti(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), MultiOverlap(Arg<Group>()), -20)]))

AssignGroups(_333oh-r1,
             RoundOneAssignmentSets(_333oh, 2024-07-19),
             Concat(DefaultScorers(2024-07-19),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingFridayMulti(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), MultiOverlap(Arg<Group>()), -20),
                     ByFilters(Or(CompetingIn(_333fm),
                                  StaffingFridayFMC(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), FMCOverlap(Arg<Group>()), -20)]))

AssignGroups(_444-r1,
             RoundOneAssignmentSets(_444, 2024-07-19),
             Concat(DefaultScorers(2024-07-19),
                    [ByFilters(Or(CompetingIn(_333fm),
                                  StaffingFridayFMC(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), FMCOverlap(Arg<Group>()), -20)]))
