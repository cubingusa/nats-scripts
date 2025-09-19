#include "_assignment_sets.cs"
#include "_scorers.cs"

Define("AssignSemifinals",
       AssignGroups({1, Round},
                    SemifinalAssignmentSets({1, Round}),
                    DefaultScorers(Date(RoundStartTime({1, Round})),
                                   EventForRound({1, Round})),
                    stationRules=[]))

Define("FinalsStations",
       [StationAssignmentRule(true, "ascending", RoundPosition(PreviousRound({1, Round})))])

Define("AssignFinals",
       AssignGroups({1, Round}, FinalAssignmentSets({1, Round}),
                    [],
                    stationRules=FinalsStations({1, Round})))
