#include "../../lib/_assigned_stage.cs"
#include "../../lib/_constants.cs"
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
         unavailable=Unavailable(Arg<Person>())))
