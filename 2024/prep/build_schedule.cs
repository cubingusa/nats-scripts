#include "../lib/_constants.cs"

# Thursday

Map(Stages(), CreateGroups(_minx-r1, 4, 2024-07-18T09:00, 2024-07-18T10:40))
Map(Stages(),
    CreateGroups(_sq1-r1, 5, 2024-07-18T10:40, 2024-07-18T12:20,
      Switch(
        Arg<String>(),
        [Tuple(RED, []),
         Tuple(BLUE, []),
         Tuple(GREEN, [5]),
         Tuple(ORANGE, [4, 5])])))
Map(Stages(),
    CreateGroups(_555-r1, 6, 2024-07-18T12:40, 2024-07-18T14:40,
      Switch(
        Arg<String>(),
        [Tuple(RED, [1, 2]),
         Tuple(BLUE, [1, 2]),
         Tuple(GREEN, [1]),
         Tuple(ORANGE, [])])))
Map(Stages(), CreateGroups(_clock-r1, 6, 2024-07-18T14:40, 2024-07-18T16:10))
Map(Stages(), CreateGroups(_666-r1, 4, 2024-07-18T16:10, 2024-07-18T17:30))
Map(Stages(), CreateGroups(_minx-r2, 1, 2024-07-18T17:30, 2024-07-18T17:50))
Map(Stages(), CreateGroups(_sq1-r2, 1, 2024-07-18T17:50, 2024-07-18T18:10))
Map(Stages(), CreateGroups(_555-r2, 1, 2024-07-18T18:10, 2024-07-18T18:30))


# Friday

Map(Stages(), CreateGroups(_333bf-r1, 2, 2024-07-19T08:20, 2024-07-19T09:00))
Map(Stages(), CreateGroups(_777-r1, 2, 2024-07-19T09:00, 2024-07-19T09:50))
Map(Stages(),
    CreateGroups(_pyram-r1, 10, 2024-07-19T09:50, 2024-07-19T12:15,
      Switch(
        Arg<String>(),
        [Tuple(RED, []),
         Tuple(BLUE, []),
         Tuple(GREEN, [10]),
         Tuple(ORANGE, [9, 10])])))

Map(Stages(),
    CreateGroups(_333oh-r1, 8, 2024-07-19T12:40, 2024-07-19T14:40,
      Switch(
        Arg<String>(),
        [Tuple(RED, [1, 2]),
         Tuple(BLUE, [1, 2]),
         Tuple(GREEN, [1]),
         Tuple(ORANGE, [])])))

Map(Stages(), CreateGroups(_444-r1, 7, 2024-07-19T14:40, 2024-07-19T17:00))
Map(FinalsStages(), CreateGroups(_666-r2, 1, 2024-07-19T17:00, 2024-07-19T17:20))
Map(FinalsStages(), CreateGroups(_minx-r3, 1, 2024-07-19T17:20, 2024-07-19T17:40))
Map(FinalsStages(), CreateGroups(_sq1-r3, 1, 2024-07-19T17:40, 2024-07-19T18:00))
Map(FinalsStages(), CreateGroups(_777-r2, 1, 2024-07-19T18:00, 2024-07-19T18:20))


# Saturday

Map([RED, BLUE, GREEN], CreateGroups(_333bf-r2, 1, 2024-07-20T08:40, 2024-07-20T09:00))
Map(Stages(),
    CreateGroups(_333-r1, 12, 2024-07-20T09:00, 2024-07-20T12:00,
      Switch(
        Arg<String>(),
        [Tuple(RED, []),
         Tuple(BLUE, []),
         Tuple(GREEN, [12]),
         Tuple(ORANGE, [11, 12])])))
Map(Stages(),
    CreateGroups(_222-r1, 12, 2024-07-20T12:30, 2024-07-20T15:00,
      Switch(
        Arg<String>(),
        [Tuple(RED, [1, 2]),
         Tuple(BLUE, [1, 2]),
         Tuple(GREEN, [1]),
         Tuple(ORANGE, [])])))
Map(Stages(), CreateGroups(_skewb-r1, 9, 2024-07-20T15:00, 2024-07-20T16:50))
Map(Stages(), CreateGroups(_333-r2, 5, 2024-07-20T16:50, 2024-07-20T18:00))


# Sunday

Map(Stages(), CreateGroups(_444bf-r1, 1, 2024-07-21T08:15, 2024-07-21T09:00))
Map(Stages(), CreateGroups(_clock-r2, 1, 2024-07-21T09:00, 2024-07-21T09:20))
Map(Stages(), CreateGroups(_333oh-r2, 1, 2024-07-21T09:20, 2024-07-21T09:40))
Map(Stages(), CreateGroups(_222-r2, 5, 2024-07-21T09:40, 2024-07-21T10:50))
Map(Stages(), CreateGroups(_444-r2, 1, 2024-07-21T10:50, 2024-07-21T11:10))
Map(Stages(), CreateGroups(_pyram-r2, 1, 2024-07-21T11:10, 2024-07-21T11:30))
Map(Stages(), CreateGroups(_skewb-r2, 1, 2024-07-21T11:30, 2024-07-21T11:50))
Map(Stages(), CreateGroups(_333-r3, 1, 2024-07-21T11:50, 2024-07-21T12:10))
Map(Stages(), CreateGroups(_222-r3, 1, 2024-07-21T12:10, 2024-07-21T12:30))

Map(FinalsStages(), CreateGroups(_clock-r3, 1, 2024-07-21T13:20, 2024-07-21T13:40))
Map(FinalsStages(), CreateGroups(_555-r3, 1, 2024-07-21T13:40, 2024-07-21T14:00))
Map(FinalsStages(), CreateGroups(_pyram-r3, 1, 2024-07-21T14:00, 2024-07-21T14:20))
Map(FinalsStages(), CreateGroups(_444-r3, 1, 2024-07-21T14:20, 2024-07-21T14:40))
Map(FinalsStages(), CreateGroups(_skewb-r3, 1, 2024-07-21T14:40, 2024-07-21T15:00))
Map(FinalsStages(), CreateGroups(_333oh-r3, 1, 2024-07-21T15:00, 2024-07-21T15:20))
Map(FinalsStages(), CreateGroups(_222-r4, 1, 2024-07-21T15:20, 2024-07-21T15:40))
Map(FinalsStages(), CreateGroups(_333bf-r3, 1, 2024-07-21T15:40, 2024-07-21T16:00))
Map(FinalsStages(), CreateGroups(_333-r4, 8, 2024-07-21T16:15, 2024-07-21T17:35))


# Side Room

CreateGroups(_333mbf-r1-a1, 1, SIDE, 2024-07-18T12:15, 2024-07-18T13:30, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, SIDE, 2024-07-19T12:15, 2024-07-19T13:30, useStageName=false)
CreateGroups(_555bf-r1, 1, SIDE, 2024-07-20T12:15, 2024-07-20T13:30, useStageName=false)
CreateGroups(_333fm-r1-a1, 1, SIDE, 2024-07-18T14:15, 2024-07-18T15:30, useStageName=false)
CreateGroups(_333fm-r1-a2, 1, SIDE, 2024-07-19T14:15, 2024-07-19T15:30, useStageName=false)
CreateGroups(_333fm-r1-a3, 1, SIDE, 2024-07-20T14:15, 2024-07-20T15:30, useStageName=false)
