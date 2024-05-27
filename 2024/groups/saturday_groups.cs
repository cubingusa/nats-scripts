#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_long_room_staff.cs"

Define("FiveBlindOverlap", And((EndTime() > 2024-07-20T11:40), (StartTime() < 2024-07-20T13:30)))
Define("FMCOverlap", And((EndTime() > 2024-07-20T14:00), (StartTime() < 2024-07-20T16:00)))

AssignGroups(_333-r1,
             RoundOneAssignmentSets(_333, 2024-07-20),
             Concat(DefaultScorers(2024-07-20),
                    [ByFilters(CompetingIn(_555bf), FiveBlindOverlap(Arg<Group>()), -20),
                     ByFilters(StaffingSaturday5BLD(Arg<Person>()), FiveBlindOverlap(Arg<Group>()), -20)]))

AssignGroups(_222-r1,
             RoundOneAssignmentSets(_222, 2024-07-20),
             Concat(DefaultScorers(2024-07-20),
                    [ByFilters(CompetingIn(_555bf), FiveBlindOverlap(Arg<Group>()), -20),
                     ByFilters(CompetingIn(_333fm), FMCOverlap(Arg<Group>()), -20),
                     ByFilters(StaffingSaturday5BLD(Arg<Person>()), FiveBlindOverlap(Arg<Group>()), -20),
                     ByFilters(StaffingSaturdayFMC(Arg<Person>()), FMCOverlap(Arg<Group>()), -20)]))

AssignGroups(_skewb-r1,
             RoundOneAssignmentSets(_skewb, 2024-07-20),
             Concat(DefaultScorers(2024-07-20),
                    [ByFilters(CompetingIn(_333fm), FMCOverlap(Arg<Group>()), -20),
                     ByFilters(StaffingSaturdayFMC(Arg<Person>()), FMCOverlap(Arg<Group>()), -20)]))
