Map(Events(),
    All(
      EventId(),
      Table(Persons(And(BooleanProperty(DATA_TEAM),
                        CompetingIn(),
                        (Stage(AssignedGroup(RoundForEvent(1))) == SIDE_BLUE))),
            [Column("Name", Name()),
             Column("WcaId", WcaId()),
             Column("Group", GroupNumber(AssignedGroup(RoundForEvent(1))))])))
