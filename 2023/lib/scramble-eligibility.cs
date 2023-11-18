Define(
    "CanScramble333",
    And((PersonalBest(_333) < 20s),
        In("3x3", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramble222",
    And((PersonalBest(_222) < 8s),
        In("2x2", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramble444",
    And((PersonalBest(_444) < 1:00s),
        In("4x4", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramble555",
    And((PersonalBest(_555) < 1:20s),
        In("5x5", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramble666",
    And((PersonalBest(_666) < 3:00s),
        In("6x6", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramble777",
    And((PersonalBest(_777) < 4:30s),
        In("7x7", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScrambleSq1",
    And((PersonalBest(_sq1) < 20s),
        In("Square-1", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScrambleClock",
    And((PersonalBest(_clock) < 10s),
        In("Clock", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScrambleClockPermissive",
    And((PersonalBest(_clock) < 12s),
        In("Clock", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScramblePyraminx",
    And((PersonalBest(_pyram) < 8s),
        In("Pyraminx", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScrambleMegaminx",
    And((PersonalBest(_minx) < 1:30s),
        In("Megaminx", ArrayProperty("puzzles-to-scramble"))))
Define(
    "CanScrambleSkewb",
    And((PersonalBest(_skewb) < 8s),
        In("Skewb", ArrayProperty("puzzles-to-scramble"))))
