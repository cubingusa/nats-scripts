AssignGroups(
    _333-r3,
    [
      AssignmentSet("G1", (RoundPosition(_333-r2) >= 7), (GroupNumber() == 1)),
      AssignmentSet("G2", (RoundPosition(_333-r2) >= 5), (GroupNumber() == 2)),
      AssignmentSet("G3", (RoundPosition(_333-r2) >= 3), (GroupNumber() == 3)),
      AssignmentSet("G4", (RoundPosition(_333-r2) >= 1), (GroupNumber() == 4))
    ],
    stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_333-r2))])

Map([1, 2, 3, 4],
    All(
      ManuallyAssign([2015MACK06], _333-r3, "Main Hall", Arg<Number>(), "staff-runner"),
      ManuallyAssign([2017WOFF01], _333-r3, "Main Hall", Arg<Number>(), "staff-runner"),
      ManuallyAssign([2016KELL12], _333-r3, "Main Hall", Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2014GOSL01], _333-r3, "Main Hall", Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2011WELC01], _333-r3, "Main Hall", Arg<Number>(), "staff-judge"),
      ManuallyAssign([2014GARB01], _333-r3, "Main Hall", Arg<Number>(), "staff-judge"),
      ManuallyAssign([2017DURE01], _333-r3, "Main Hall", Arg<Number>(), "staff-Data")))
