#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

# Args:
# 1: Stage
Define("SundayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _444bf-r1, {1, String}, 2025-07-06,
           [Judges(10, _444bf), Scramblers(3, _444bf), Runners(2), Checkers(1), Delegates(2)],
           VolunteerScorers(_444bf, 2025-07-06)),
         DoVolunteerAssignments(
           _sq1-r1, {1, String}, 2025-07-06,
           [Judges(10, _sq1), Scramblers(3, _sq1), Runners(4), Delegates(2)],
           VolunteerScorers(_sq1, 2025-07-06))))
