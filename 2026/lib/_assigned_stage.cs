#include "_constants.cs"

Define(
    "AssignedStageForTeam",
    Switch({1, Number},
           Switch(Day({2, Date}),
                  [Tuple(2, [Tuple(1, RED),
                             Tuple(2, BLUE),
                             Tuple(3, GREEN),
                             Tuple(4, ORANGE)]),
                   Tuple(3, [Tuple(1, BLUE),
                             Tuple(2, GREEN),
                             Tuple(3, ORANGE),
                             Tuple(4, RED)]),
                   Tuple(4, [Tuple(1, GREEN),
                             Tuple(2, ORANGE),
                             Tuple(3, RED),
                             Tuple(4, BLUE)]),
                   Tuple(5, [Tuple(1, ORANGE),
                             Tuple(2, RED),
                             Tuple(3, BLUE),
                             Tuple(4, GREEN)])])))

Define(
    "AssignedStage",
    If(HasProperty(STAFF_TEAM, {1, Person}),
       AssignedStageForTeam(
         If(And((Name({1, Person}) == "David Krasne"),
                ({2, Date} == 2026-07-03)),
            2,
            NumberProperty(STAFF_TEAM, {1, Person})),
         {2, Date}),
       "n/a"))
