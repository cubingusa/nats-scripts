#include "../../lib/_assigned_stage.cs"
#include "../../lib/_constants.cs"
#include "_jobs.cs"
#include "_unavailable.cs"

# Args:
# 1: Round
# 2: Stage
# 3: Date of round
# 4: Jobs (see _jobs.cs)
# 5: Scorers (see _scorers.cs)
Define("DoVolunteerAssignments",
           AssignStaff(
             {1, Round},
             (Stage() == {2, String}),
             Persons((AssignedStage(Arg<Person>(), {3, Date}) == {2, String})),
             {4, Array<AssignmentJob>},
             {5, Array<AssignmentScorer>},
             unavailable=Unavailable(Arg<Person>()), overwrite=true))

Define("StageToTeam", Switch({1, String}, [Tuple(RED, 1), Tuple(BLUE, 2)]))

# Args:
# 1: Round
# 2: Stage
# 3: Jobs (see _jobs.cs)
# 4: Scorers (see _scorers.cs)
Define("FinalsAssignments",
       AssignStaff(
         {1, Round},
         (Stage() == {2, String}),
         Persons((NumberProperty(FINALS_TEAM) == StageToTeam({2, String}))),
         {3, Array<AssignmentJob>},
         {4, Array<AssignmentScorer>},
         unavailable=Unavailable(Arg<Person>()), overwrite=true))
