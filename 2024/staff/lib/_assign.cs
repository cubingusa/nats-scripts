#include "../../lib/_assigned_stage.cs"
#include "../../lib/_constants.cs"
#include "_jobs.cs"
#include "_unavailable.cs"

# Args:
# 1: Round
# 2: Date of round
# 3: Jobs (see _jobs.cs)
# 4: Scorers (see _scorers.cs)
Define("DoStaffAssignments",
       Map([ORANGE],
           AssignStaff(
             {1, Round},
             (Stage() == Arg<String>()),
             Persons((AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
             {3, Array<AssignmentJob>},
             {4, Array<AssignmentScorer>},
             unavailable=Unavailable(Arg<Person>()), overwrite=true)))
