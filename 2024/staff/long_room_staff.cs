#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

AssignStaff(
    _333fm-r1, true, Persons(Or(StaffingThursdayFMC(Arg<Person>()),
                                StaffingFridayFMC(Arg<Person>()),
                                StaffingSaturdayFMC(Arg<Person>()))),
    [Job("judge", 4)],
    [
      GroupScorer(And((Date() == 2024-07-18), StaffingThursdayFMC(Arg<Person>())), 1),
      GroupScorer(And((Date() == 2024-07-19), StaffingFridayFMC(Arg<Person>())), 1),
      GroupScorer(And((Date() == 2024-07-20), StaffingSaturdayFMC(Arg<Person>())), 1)
    ], unavailable=[])

AssignStaff(
    _333mbf-r1, true, Persons(Or(StaffingThursdayMulti(Arg<Person>()),
                                 StaffingFridayMulti(Arg<Person>()))),
    [Job("judge", 8)],
    [
      GroupScorer(And((Date() == 2024-07-18), StaffingThursdayMulti(Arg<Person>())), 1),
      GroupScorer(And((Date() == 2024-07-19), StaffingFridayMulti(Arg<Person>())), 1)
    ])

AssignStaff(
    _555bf-r1, true, Persons(StaffingSaturday5BLD(Arg<Person>())),
    [Job("judge", 10), Job("scrambler", 2)],
    StaffScorers(_555bf))
