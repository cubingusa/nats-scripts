#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

Define("MultiOverlap", And((EndTime() > 2024-07-18T11:40), (StartTime() < 2024-07-18T13:30)))
Define("FMCOverlap", And((EndTime() > 2024-07-18T14:00), (StartTime() < 2024-07-18T15:45)))

AssignGroups(_minx-r1,
             RoundOneAssignmentSets(_minx, 2024-07-18),
             Concat(DefaultScorers(2024-07-18),
                    [ByFilters(StaffingThursdayMulti(Arg<Person>()), (GroupNumber() < 3), 10),
                     ByFilters(BooleanProperty(WCA_BOARD), (GroupNumber() == 1), 10)]))

AssignGroups(_sq1-r1,
             RoundOneAssignmentSets(_sq1, 2024-07-18),
             Concat(DefaultScorers(2024-07-18),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingThursdayMulti(Arg<Person>())), MultiOverlap(Arg<Group>()), -20)]))

AssignGroups(_555-r1,
             RoundOneAssignmentSets(_555, 2024-07-18),
             Concat(DefaultScorers(2024-07-18),
                    [ByFilters(Or(CompetingIn(_333mbf),
                                  StaffingThursdayMulti(Arg<Person>())), MultiOverlap(Arg<Group>()), -20),
                     ByFilters(Or(CompetingIn(_333fm),
                                  StaffingThursdayFMC(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), FMCOverlap(Arg<Group>()), -20),
                     ByFilters(BooleanProperty(WCA_BOARD), (GroupNumber() == 1), 10)]))

AssignGroups(_clock-r1,
             RoundOneAssignmentSets(_clock, 2024-07-18),
             Concat(DefaultScorers(2024-07-18),
                    [ByFilters(Or(CompetingIn(_333fm),
                                  StaffingThursdayFMC(Arg<Person>()),
                                  BooleanProperty(STAGE_LEAD)), FMCOverlap(Arg<Group>()), -20)]))

AssignGroups(_666-r1,
             RoundOneAssignmentSets(_666, 2024-07-18),
             DefaultScorers(2024-07-18))
