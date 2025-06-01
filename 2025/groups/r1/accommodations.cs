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

# TODO: volunteer assignments
