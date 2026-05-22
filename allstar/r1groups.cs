Define("Default", [AssignmentSet("Everyone", true, true)])
Define("SplitAssignmentSets", [AssignmentSet("US", (Country() == "US"), (GroupNumber() <= {1, Number})),
                               AssignmentSet("non-US", Not((Country() == "US")), (GroupNumber() > {1, Number}))])

Define("Stations", [StationAssignmentRule(true, "ascending", PsychSheetPosition({1, Event}))])

AssignGroups(_333mbf-r1, Default(), [], attemptNumber=1)
AssignGroups(_333mbf-r1, Default(), [], attemptNumber=2)
AssignGroups(_333fm-r1, Default(), [], attemptNumber=1)
AssignGroups(_333fm-r1, Default(), [], attemptNumber=2)
AssignGroups(_333fm-r1, Default(), [], attemptNumber=3)

AssignGroups(_skewb-r1, Default(),
             [ByFilters(CompetingIn(_555bf), (GroupNumber() == 2), -10)],
             stationRules=Stations(_skewb))

AssignGroups(_555bf-r1, Default(), [], stationRules=Stations(_555bf))

AssignGroups(_444-r1, Default(),
             [ByFilters(CompetingIn(_555bf), (GroupNumber() == 1), -10)],
             stationRules=Stations(_444))

AssignGroups(_222-r1, SplitAssignmentSets(2),
             [ByFilters(CompetingIn(_333mbf), (GroupNumber() == 2), -10),
              ByFilters((GroupNumber(AssignedGroup(_444-r1)) == 2), (GroupNumber() == 1), -5)],
             stationRules=Stations(_222))

AssignGroups(_666-r1, Default(), [], stationRules=Stations(_666))
AssignGroups(_minx-r1, Default(), [], stationRules=Stations(_minx))
AssignGroups(_sq1-r1, Default(), [], stationRules=Stations(_sq1))

AssignGroups(_333-r1, Default(),
             [ByFilters(CompetingIn(_333fm), (GroupNumber() > 1), -10),
              ByFilters(CompetingIn(_sq1), (GroupNumber() == 1), -5),
              ByFilters(CompetingIn(_clock), (GroupNumber() == 4), -5)],
             stationRules=Stations(_333))

AssignGroups(_clock-r1, Default(), [], stationRules=Stations(_clock))
AssignGroups(_444bf-r1, Default(), [], stationRules=Stations(_444bf))

AssignGroups(_555-r1, Default(),
             [ByFilters(CompetingIn(_333fm), (GroupNumber() == 1), -10)],
             stationRules=Stations(_555))

AssignGroups(_pyram-r1, Default(),
             [ByFilters((GroupNumber(AssignedGroup(_555-r1)) == 2), (GroupNumber() == 1), -5)],
             stationRules=Stations(_pyram))

AssignGroups(_333oh-r1, Default(),
             [ByFilters((GroupNumber(AssignedGroup(_pyram-r1)) == 2), (GroupNumber() == 1), -5),
              ByFilters(CompetingIn(_777), (GroupNumber() == 2), -10)],
             stationRules=Stations(_333oh))

AssignGroups(_777-r1, Default(), [], stationRules=Stations(_777))
AssignGroups(_333bf-r1, Default(), [], stationRules=Stations(_333bf))
