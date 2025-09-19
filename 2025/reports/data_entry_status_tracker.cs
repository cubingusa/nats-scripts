Table(
    Sort(Rounds(), RoundEndTime()),
    [
      Column("Start", FormatTime(RoundStartTime())),
      Column("End", FormatTime(RoundEndTime())),
      Column("Event", EventForRound()),
      Column("Number", RoundNumber(Arg<Round>()))
    ]
    )
