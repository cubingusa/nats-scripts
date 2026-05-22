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


Define("ScrambleSpeedWeight",
       [Tuple(_333, 3),
        Tuple(_222, 3),
        Tuple(_444, 5),
        Tuple(_555, 5),
        Tuple(_666, 8),
        Tuple(_777, 8),
        Tuple(_sq1, 5),
        Tuple(_clock, 5),
        Tuple(_pyram, 3),
        Tuple(_minx, 8),
        Tuple(_skewb, 3),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1),
        Tuple(_333mbf, 3),
        Tuple(_444bf, 3),
        Tuple(_555bf, 3)])

Define("IsCore", (StringProperty("assigned-team") == "Core Volunteer"))


Define("StandardJobNames", ["judge", "scrambler", "runner", "Data"])

Define("Scorers",
       [
         PriorAssignmentScorer(-2, 0, 2025-11-01T00:00),
         PreferenceScorer(weight=5, prefix="percent-", prior=15, allJobs=["judge", "scrambler", "runner"]),
         SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
         ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),
         ConsecutiveJobScorer(60, -5, 0, jobs=["scrambler"]),
         MismatchedStationScorer(-10),
         SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                            Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                            Switch({1, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         FollowingGroupScorer(-10, maxMinutes=10)
       ])

Define("Judges", Job("judge", {1, Number}, assignStations=true))
Define("Scramblers", Job("scrambler", {1, Number},
                         eligibility=And(CanScramble({2, Event}),
                                         (NumberProperty("percent-scrambler") > 0))))
Define("Runners", Job("runner", {1, Number},
                      eligibility=(NumberProperty("percent-runner") > 0)))
Define("Data", Job("Data", {1, Number}, eligibility=BooleanProperty("data-entry")))

Define("Jobs", [Judges(8), Scramblers(2, {1, Event}), Runners(0), Data(1)])
Define("IsVolunteer", Or(IsCore(), In(Name(), ["Stephen Griggs", "Roman Wofford", "Zeke Mackay", "Carter Kucala"])))

Define("Unavailable",
    Concat(
      Switch(
        {1, Person},
        [
          Tuple(2016GUTI23, [UnavailableBetween(2025-11-01T00:00, 2025-11-01T10:00)]),
          Tuple(2016LIJE01, [UnavailableBetween(2025-11-01T00:00, 2025-11-01T10:00)]),
          Tuple(2019KUCA01, [UnavailableBetween(2025-11-01T09:00, 2025-11-01T09:15),
                             UnavailableBetween(2025-11-01T11:45, 2025-11-01T13:45)]),
          Tuple(2022KUCA01, [UnavailableBetween(2025-11-01T09:00, 2025-11-01T09:15),
                             UnavailableBetween(2025-11-01T11:45, 2025-11-01T13:45)]),
          Tuple(2017SEOH01, [UnavailableForDate(2025-11-02)]),
          Tuple(2014GRIG01, [UnavailableForDate(2025-11-02),
                             UnavailableBetween(2025-11-01T15:00, 2025-11-01T17:00)]),
          Tuple(2013LANG03, [UnavailableForDate(2025-11-02)]),
          Tuple(2017WOFF01, [UnavailableBetween(2025-11-01T09:00, 2025-11-01T13:30)]),
          Tuple(2013BROW04, [UnavailableBetween(2025-11-01T10:00, 2025-11-01T11:45)]),
          Tuple(2015MACK06, [UnavailableBetween(2025-11-01T11:00, 2025-11-01T11:45)])
        ]
        )
      ))

Define("DefaultAssignment",
       AssignStaff({1, Round},
                   true,
                   Persons(IsVolunteer()),
                   Jobs(EventForRound({1, Round})),
                   Scorers(EventForRound({1, Round})),
                   unavailable=Unavailable(Arg<Person>())))

