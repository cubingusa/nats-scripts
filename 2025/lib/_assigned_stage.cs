#include "_constants.cs"

Define(
    "AssignedStageForTeam",
    Switch({1, Number},
           Switch(Day({2, Date}),
                  [Tuple(3, [Tuple(1, MAIN_RED),
                             Tuple(2, MAIN_GREEN),
                             Tuple(3, SIDE_RED),
                             Tuple(4, MAIN_BLUE),
                             Tuple(5, SIDE_BLUE),
                             Tuple(6, SIDE_ORANGE),
                             Tuple(7, SIDE_GREEN),
                             Tuple(8, MAIN_ORANGE),
                             Tuple(9, MAIN_YELLOW),
                             Tuple(10, MAIN_WHITE)]),
                   Tuple(4, [Tuple(1, MAIN_GREEN),
                             Tuple(2, SIDE_RED),
                             Tuple(3, MAIN_RED),
                             Tuple(4, MAIN_ORANGE),
                             Tuple(5, MAIN_BLUE),
                             Tuple(6, SIDE_GREEN),
                             Tuple(7, SIDE_ORANGE),
                             Tuple(8, MAIN_YELLOW),
                             Tuple(9, MAIN_WHITE),
                             Tuple(10, SIDE_BLUE)]),
                   Tuple(5, [Tuple(1, MAIN_RED),
                             Tuple(2, SIDE_RED),
                             Tuple(3, MAIN_GREEN),
                             Tuple(4, SIDE_BLUE),
                             Tuple(5, SIDE_GREEN),
                             Tuple(6, MAIN_BLUE),
                             Tuple(7, MAIN_YELLOW),
                             Tuple(8, MAIN_WHITE),
                             Tuple(9, MAIN_ORANGE),
                             Tuple(10, SIDE_ORANGE)]),
                   Tuple(6, [Tuple(1, MAIN_GREEN),
                             Tuple(2, MAIN_RED),
                             Tuple(3, SIDE_RED),
                             Tuple(4, SIDE_ORANGE),
                             Tuple(5, SIDE_GREEN),
                             Tuple(6, SIDE_BLUE),
                             Tuple(7, MAIN_BLUE),
                             Tuple(8, MAIN_ORANGE),
                             Tuple(9, MAIN_YELLOW),
                             Tuple(10, MAIN_WHITE)])])))

Define(
    "AssignedStage",
    If(HasProperty(STAFF_TEAM, {1, Person}),
       AssignedStageForTeam(NumberProperty(STAFF_TEAM, {1, Person}), {2, Date}),
       "n/a"))
