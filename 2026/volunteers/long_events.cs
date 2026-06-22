#include "../lib/_constants.cs"
#include "../lib/_long_room_volunteers.cs"

AssignStaff(_333fm-r1, (AttemptNumber() == 1), Persons(FMC1Volunteer()),
            [Job("judge", Length(Persons(FMC1Volunteer())))], [])
AssignStaff(_333fm-r1, (AttemptNumber() == 2), Persons(FMC2Volunteer()),
            [Job("judge", Length(Persons(FMC2Volunteer())))], [])
AssignStaff(_333fm-r1, (AttemptNumber() == 3), Persons(FMC3Volunteer()),
            [Job("judge", Length(Persons(FMC3Volunteer())))], [])
AssignStaff(_333mbf-r1, (AttemptNumber() == 1), Persons(Multi1Volunteer()),
            [Job("judge", Length(Persons(Multi1Volunteer())))], [])
AssignStaff(_333mbf-r1, (AttemptNumber() == 2), Persons(Multi2Volunteer()),
            [Job("judge", Length(Persons(Multi2Volunteer())))], [])
