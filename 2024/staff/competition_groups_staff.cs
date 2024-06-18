#include "../lib/_constants.cs"
#include "../lib/_long_room_staff.cs"

ClearCompetitionGroupsAssignments(Persons(true))

CreateCompetitionGroupsAssignments(
    Persons(StaffingThursdayMulti(Arg<Person>())),
    "Scramble Multi Blind", 2024-07-18T10:00, 2024-07-18T12:00)
 
CreateCompetitionGroupsAssignments(
    Persons(StaffingFridayMulti(Arg<Person>())),
    "Scramble Multi Blind", 2024-07-19T10:00, 2024-07-19T12:00)

CreateCompetitionGroupsAssignments(
    [2018KHAN26, 2018KHAN27, 2018KHAN28, 2014GULA02],
    "Compete in OH (Blue Stage)", 2024-07-18T08:30, 2024-07-18T09:00)
CreateCompetitionGroupsAssignments(
    [2008YOUN02, 2017WOFF01],
    "Accommodation for OH (Blue Stage)", 2024-07-18T08:30, 2024-07-18T09:00)

CreateCompetitionGroupsAssignments(
    [2015PADG01, 2024BOIS01],
    "Compete in Saturday events (Blue Stage)", 2024-07-19T12:30, 2024-07-19T13:15)
CreateCompetitionGroupsAssignments(
    [2010AMBR01, 2020LONG05],
    "Accommodation for Saturday events (Blue Stage)", 2024-07-19T12:30, 2024-07-19T13:15)

CreateCompetitionGroupsAssignments(
    Persons(And(CompetingIn(_333mbf), Not(IsStaff(Arg<Person>())))),
    "Multi-Blind Cube Submission", 2024-07-18T09:30, 2024-07-18T10:00)
CreateCompetitionGroupsAssignments(
    Persons(And(CompetingIn(_333mbf), Not(IsStaff(Arg<Person>())))),
    "Multi-Blind Cube Submission", 2024-07-19T09:30, 2024-07-19T10:00)

CreateCompetitionGroupsAssignments(
    Concat([2014GULA02], Persons(And(CompetingIn(_333mbf), IsStaff(Arg<Person>())))),
    "Multi-Blind Cube Submission", 2024-07-18T08:50, 2024-07-18T10:00)
CreateCompetitionGroupsAssignments(
    Concat([2014GULA02], Persons(And(CompetingIn(_333mbf), IsStaff(Arg<Person>())))),
    "Multi-Blind Cube Submission", 2024-07-19T08:30, 2024-07-19T10:00)
