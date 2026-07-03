#include "_assignment_sets.cs"
#include "_group_scorers.cs"

Define("AssignSemifinals",
       AssignGroups({1, Round},
                    SemifinalAssignmentSets({1, Round}),
                    DefaultScorers(Date(RoundStartTime({1, Round})),
                                   EventForRound({1, Round})),
                    stationRules=[],
                    overwrite=true))

Define("FinalsStations",
       [StationAssignmentRule(true, "ascending", RoundPosition(PreviousRound({1, Round})),
                              stationExclusionRules=[NonNAStream()])])

Define("AssignFinals",
       AssignGroups({1, Round}, FinalsAssignmentSets({1, Round}),
                    [],
                    stationRules=FinalsStations({1, Round})))
