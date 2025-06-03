#include "_constants.cs"

Define(
    "AssignedStageForTeam",
    Switch({1, Number},
           Switch(Day({2, Date}),
                  [Tuple(3, [Tuple(1, MAIN_RED),
                             Tuple(2, SIDE_RED),
                             Tuple(3, MAIN_GREEN),
                             Tuple(4, MAIN_BLUE),
                             Tuple(5, MAIN_ORANGE),
                             Tuple(6, SIDE_GREEN),
                             Tuple(7, SIDE_ORANGE),
                             Tuple(8, SIDE_BLUE),
                             Tuple(9, MAIN_YELLOW),
                             Tuple(10, MAIN_WHITE)]),
                   Tuple(4, [Tuple(1, MAIN_GREEN),
                             Tuple(2, MAIN_RED),
                             Tuple(3, SIDE_RED),
                             Tuple(4, SIDE_GREEN),
                             Tuple(5, MAIN_BLUE),
                             Tuple(6, SIDE_ORANGE),
                             Tuple(7, SIDE_BLUE),
                             Tuple(8, MAIN_WHITE),
                             Tuple(9, MAIN_ORANGE),
                             Tuple(10, MAIN_YELLOW)]),
                   Tuple(5, [Tuple(1, SIDE_RED),
                             Tuple(2, MAIN_GREEN),
                             Tuple(3, MAIN_RED),
                             Tuple(4, MAIN_ORANGE),
                             Tuple(5, SIDE_GREEN),
                             Tuple(6, MAIN_BLUE),
                             Tuple(7, MAIN_WHITE),
                             Tuple(8, MAIN_YELLOW),
                             Tuple(9, SIDE_BLUE),
                             Tuple(10, SIDE_ORANGE)]),
                   Tuple(6, [Tuple(1, MAIN_RED),
                             Tuple(2, SIDE_RED),
                             Tuple(3, MAIN_GREEN),
                             Tuple(4, SIDE_BLUE),
                             Tuple(5, SIDE_ORANGE),
                             Tuple(6, MAIN_YELLOW),
                             Tuple(7, MAIN_BLUE),
                             Tuple(8, SIDE_GREEN),
                             Tuple(9, MAIN_WHITE),
                             Tuple(10, MAIN_ORANGE)])])))

Define(
    "AssignedStage",
    If(HasProperty(STAFF_TEAM, {1, Person}),
       AssignedStageForTeam(NumberProperty(STAFF_TEAM, {1, Person}), {2, Date}),
       "n/a"))

Define(
    "AssignedRoom",
    If(HasProperty(DATA_TEAM, {1, Person}),
      Switch(NumberProperty(DATA_TEAM),
        Switch(Day({2, Date}), [
          Tuple(3, [
            Tuple(1, BALLROOM),
            Tuple(2, MAIN_HALL),
            Tuple(3, MAIN_HALL),
            Tuple(4, MAIN_HALL)
          ]),
          Tuple(4, [
            Tuple(1, BALLROOM),
            Tuple(2, MAIN_HALL),
            Tuple(3, MAIN_HALL),
            Tuple(4, MAIN_HALL)
          ]),
          Tuple(5, [
            Tuple(1, MAIN_HALL),
            Tuple(2, BALLROOM),
            Tuple(3, MAIN_HALL),
            Tuple(4, BALLROOM)
          ]),
          Tuple(6, [
            Tuple(1, MAIN_HALL),
            Tuple(2, MAIN_HALL),
            Tuple(3, BALLROOM),
            Tuple(4, BALLROOM)
          ])])),
      "n/a"))
