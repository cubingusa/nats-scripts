#include "../lib/_constants.cs"

ClearCompetitionGroupsAssignments(Persons(true))

CreateCompetitionGroupsAssignments(
    Persons(And(CompetingIn(_skewb),
                (StringProperty(ACCOMMODATION) == NO_SATURDAY))),
    "Compete in Skewb R1 (Green Stage)", 2025-07-03T09:00, 2025-07-03T09:20)

CreateCompetitionGroupsAssignments(
    Persons(And(CompetingIn(_sq1),
                (StringProperty(ACCOMMODATION) == NO_SUNDAY_MORNING))),
    "Compete in Square-1 R1 (Green Stage)", 2025-07-03T09:00, 2025-07-03T09:20)

CreateCompetitionGroupsAssignments(
    Persons(And(CompetingIn(_333),
                (StringProperty(ACCOMMODATION) == NO_SATURDAY))),
    "Compete in 3x3 R1 (Green Stage)", 2025-07-04T12:45, 2025-07-04T13:05)

# TODO: volunteer assignments for accommodations.

CreateCompetitionGroupsAssignments(
    [2017BRYA06], "Mirror Blocks Volunteering", 2025-07-03T09:00, 2025-07-03T10:00)
CreateCompetitionGroupsAssignments(
    [2020OREN01], "Mirror Blocks Volunteering", 2025-07-03T09:00, 2025-07-03T11:00)
CreateCompetitionGroupsAssignments(
    [2022KHAN05], "Mirror Blocks Volunteering", 2025-07-03T10:00, 2025-07-03T12:00)
CreateCompetitionGroupsAssignments(
    [2022STON03], "Mirror Blocks Volunteering", 2025-07-03T11:00, 2025-07-03T13:00)
CreateCompetitionGroupsAssignments(
    [2014MELL03], "Mirror Blocks Volunteering", 2025-07-03T12:00, 2025-07-03T13:00)
CreateCompetitionGroupsAssignments(
    [2022LEAV01], "Mirror Blocks Volunteering", 2025-07-03T13:00, 2025-07-03T14:00)
CreateCompetitionGroupsAssignments(
    [2020TONG02], "Mirror Blocks Volunteering", 2025-07-03T13:00, 2025-07-03T15:00)
CreateCompetitionGroupsAssignments(
    [2023VINC03], "Mirror Blocks Volunteering", 2025-07-03T14:00, 2025-07-03T16:00)
CreateCompetitionGroupsAssignments(
    [2003HARD01], "Mirror Blocks Volunteering", 2025-07-03T15:00, 2025-07-03T17:00)
CreateCompetitionGroupsAssignments(
    [2015MACD03], "Mirror Blocks Volunteering", 2025-07-03T16:00, 2025-07-03T18:00)
CreateCompetitionGroupsAssignments(
    [2014MELL03], "Mirror Blocks Volunteering", 2025-07-03T17:00, 2025-07-03T18:00)

CreateCompetitionGroupsAssignments(
    [2003HARD01], "FTO Volunteering", 2025-07-04T09:00, 2025-07-04T10:00)
CreateCompetitionGroupsAssignments(
    [2015MACD03], "FTO Volunteering", 2025-07-04T09:00, 2025-07-04T11:00)
CreateCompetitionGroupsAssignments(
    [2019BLAC02], "FTO Volunteering", 2025-07-04T10:00, 2025-07-04T12:00)
CreateCompetitionGroupsAssignments(
    [2022LEAV01], "FTO Volunteering", 2025-07-04T11:00, 2025-07-04T13:00)
CreateCompetitionGroupsAssignments(
    [2014MELL03], "FTO Volunteering", 2025-07-04T12:00, 2025-07-04T13:00)
CreateCompetitionGroupsAssignments(
    [2017BRYA06], "FTO Volunteering", 2025-07-04T13:00, 2025-07-04T14:30)
CreateCompetitionGroupsAssignments(
    [2017CAST41], "FTO Volunteering", 2025-07-04T13:00, 2025-07-04T15:00)
CreateCompetitionGroupsAssignments(
    [2022TIND01], "FTO Volunteering", 2025-07-04T14:30, 2025-07-04T16:00)
CreateCompetitionGroupsAssignments(
    [2017OSUD01], "FTO Volunteering", 2025-07-04T15:00, 2025-07-04T17:00)
CreateCompetitionGroupsAssignments(
    [2017LAMB06], "FTO Volunteering", 2025-07-04T16:00, 2025-07-04T18:00)
CreateCompetitionGroupsAssignments(
    [2003HARD01], "FTO Volunteering", 2025-07-04T17:00, 2025-07-04T18:00)

CreateCompetitionGroupsAssignments(
    Persons(BooleanProperty(MULTI_VOLUNTEER)), "Multi Blind Scrambling", 2025-07-03T10:00, 2025-07-03T12:00)
CreateCompetitionGroupsAssignments(
    Persons(BooleanProperty(MULTI_VOLUNTEER)), "Multi Blind Scrambling", 2025-07-05T10:00, 2025-07-05T12:00)

CreateCompetitionGroupsAssignments(
    Persons(BooleanProperty(CORE_VOLUNTEER)), "2x2 Volunteer Assignments (TBD)", 2025-07-04T09:50, 2025-07-04T12:15)
CreateCompetitionGroupsAssignments(
    Persons(BooleanProperty(CORE_VOLUNTEER)), "Skewb Volunteer Assignments (TBD)", 2025-07-05T09:40, 2025-07-05T12:15)
CreateCompetitionGroupsAssignments(
    Persons(BooleanProperty(CORE_VOLUNTEER)), "Square-1 Volunteer Assignments (TBD)", 2025-07-06T09:30, 2025-07-03T11:00)
