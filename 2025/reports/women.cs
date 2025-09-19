Map(Rounds(),
    All(
      RoundId(),
      Table(
        Sort(
          Persons(
            And(
              (Gender() == "f"),
              (PositionInRound() <= 200))),
          PositionInRound()),
        [Column("Name", Name()),
         Column("Position", PositionInRound())])))
