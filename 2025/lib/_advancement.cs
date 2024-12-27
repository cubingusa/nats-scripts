Define("LikelyToAdvance",
       (PsychSheetPosition(EventForRound({1, Round}), person={2, Person}) <= NumberInRound({1, Round})))

Define("PossibleAdvancements",
       If(({1, Number} < 100), (3 * {1, Number}),
          If(({1, Number} < 300), (2 * {1, Number}),
             (1.5 * {1, Number}))))
           

Define("PossiblyWillAdvance",
       (PsychSheetPosition(EventForRound({1, Round}), person={2, Person}) <= PossibleAdvancements(NumberInRound({1, Round}))))
