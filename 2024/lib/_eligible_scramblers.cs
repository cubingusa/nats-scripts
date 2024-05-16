Define("ScrambleLimits",
       [Tuple(_333, 20s),
        Tuple(_222, 8s),
        Tuple(_444, 1:00s),
        Tuple(_555, 1:30s),
        Tuple(_666, 2:45s),
        Tuple(_777, 3:45s),
        Tuple(_sq1, 20s),
        Tuple(_clock, 10s),
        Tuple(_pyram, 8s),
        Tuple(_minx, 1:30s),
        Tuple(_skewb, 8s)])

Define("EventNamesInForm",
       [Tuple(_333, "3x3"),
        Tuple(_222, "2x2"),
        Tuple(_444, "4x4"),
        Tuple(_555, "5x5"),
        Tuple(_666, "6x6"),
        Tuple(_777, "7x7"),
        Tuple(_sq1, "Square-1"),
        Tuple(_clock, "Clock"),
        Tuple(_pyram, "Pyraminx"),
        Tuple(_minx, "Megaminx"),
        Tuple(_skewb, "Skewb")])

Define("CanScramble",
       And(
         (PersonalBest({1, Event}) < Switch({1, Event}, ScrambleLimits())),
         In(Switch({1, Event}, EventNamesInForm()), ArrayProperty("puzzles-to-scramble"))))
