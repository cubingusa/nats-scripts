#include "_assignment_sets.cs"
#include "_scorers.cs"
#include "_stations.cs"

Define("AssignRoundTwo",
       AssignGroups({1, Round},
                    RoundTwoAssignmentSets({1, Round}),
                    DefaultScorers(Date(RoundStartTime({1, Round})))))
Define("AssignSemifinals",
       AssignGroups({1, Round},
                    SemifinalAssignmentSets({1, Round}),
                    DefaultScorers(Date(RoundStartTime({1, Round})))))
Define("AssignFinals",
       AssignGroups({1, Round}, FinalAssignmentSets({1, Round}), stationRules=FinalsStations({1, Round}))
