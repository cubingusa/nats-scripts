#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

# Args:
# 1: Stage

Define("FridayMorningAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _777-r1, {1, String}, 2025-07-04,
           [Judges(10, _777), Scramblers(4, _777), Runners(2), Delegates(2)],
           VolunteerScorers(_777, 2025-07-04)),
         DoVolunteerAssignments(
           _222-r1, {1, String}, 2025-07-04,
           [Judges(10, _222), Scramblers(3, _222), Runners(4), Delegates(2)],
           VolunteerScorers(_222, 2025-07-04))))

Define("FridayAfternoonAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _444-r1, {1, String}, 2025-07-04,
           [Judges(10, _444), Scramblers(4, _444), Runners(4), Delegates(2)],
           VolunteerScorers(_444, 2025-07-04)),
         DoVolunteerAssignments(
           _minx-r1, {1, String}, 2025-07-04,
           [Judges(10, _minx), Scramblers(4, _minx), Runners(3), Delegates(2)],
           VolunteerScorers(_minx, 2025-07-04))))

Define("FridayAssignmentsForStage",
       All(
         FridayMorningAssignmentsForStage({1, String}),
         FridayAfternoonAssignmentsForStage({1, String}),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), 2025-07-04) == {1, String})))))
