# For dev, add all people to the round.
Map(Events(),
    AddResults(
        RoundForEvent(1),
        Persons(
            And(CompetingIn(),
                (PsychSheetPosition() <=
                 Switch(Arg<Event>(), [Tuple(_333mbf, 20), Tuple(_333fm, 30)], 99999))))))
