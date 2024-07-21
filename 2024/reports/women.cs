Map(Rounds(),
    All(
      RoundId(),
      Table(
        Sort(
          Persons(
            And(
              (Gender() == "f"),
              (PositionInRound() <= 100))),
          PositionInRound()),
        [Column("Name", Name()),
         Column("Position", PositionInRound())])))
