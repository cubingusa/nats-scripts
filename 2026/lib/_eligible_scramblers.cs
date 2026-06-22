Define("ScrambleLimits",
       [Tuple(_333, 20s),
        Tuple(_222, 8s),
        Tuple(_444, 1:00s),
        Tuple(_555, 1:30s),
        Tuple(_666, 2:45s),
        Tuple(_777, 4:30s),
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

Define("EventsToScramblingEvents",
       [Tuple(_333, _333),
        Tuple(_222, _222),
        Tuple(_444, _444),
        Tuple(_555, _555),
        Tuple(_666, _666),
        Tuple(_777, _777),
        Tuple(_sq1, _sq1),
        Tuple(_clock, _clock),
        Tuple(_pyram, _pyram),
        Tuple(_minx, _minx),
        Tuple(_skewb, _skewb),
        Tuple(_333bf, _333),
        Tuple(_333oh, _333),
        Tuple(_333mbf, _333),
        Tuple(_444bf, _444),
        Tuple(_555bf, _555)])

Define("CanScramble",
       And(
         (PersonalBest(
            Switch({1, Event}, EventsToScramblingEvents())) <
          Switch(
            Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits())),
          In(
            Switch(
              Switch({1, Event}, EventsToScramblingEvents()),
              EventNamesInForm()),
            ArrayProperty("puzzles-to-scramble"))))
