Table(
    Sort(
      Persons(And(CompetingIn(_sq1), CompetingInRound(_333-r2))),
      (StartTime(AssignedGroup(_sq1-r1)) - StartTime(AssignedGroup(_333-r2)))),
    [
      Column("Name", Name()),
      Column("WcaId", WcaId()),
      Column("333 Group", GroupName(AssignedGroup(_333-r2))),
      Column("sq1 Group", GroupName(AssignedGroup(_sq1-r1))),
      Column("Diff", (StartTime(AssignedGroup(_sq1-r1)) - StartTime(AssignedGroup(_333-r2))))
    ]
    )
