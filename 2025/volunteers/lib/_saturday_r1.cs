#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

# Args:
# 1: Stage

Define("SaturdayMorningAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _333bf-r1, {1, String}, 2025-07-05,
           [Judges(10, _333bf), Scramblers(2, _333bf), Runners(3), Delegates(2)],
           VolunteerScorers(_333bf, 2025-07-05)),
         DoVolunteerAssignments(
           _skewb-r1, {1, String}, 2025-07-05,
           [Judges(10, _skewb), Scramblers(3, _skewb), Runners(4), Delegates(2)],
           VolunteerScorers(_skewb, 2025-07-05))))

Define("SaturdayAfternoonAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _333-r1, {1, String}, 2025-07-05,
           [Judges(10, _333), Scramblers(3, _333), Runners(4), Delegates(2)],
           VolunteerScorers(_333, 2025-07-05)),
         DoVolunteerAssignments(
           _666-r1, {1, String}, 2025-07-05,
           [Judges(10, _666), Scramblers(4, _666), Runners(3), Delegates(2)],
           VolunteerScorers(_666, 2025-07-05))))

Define("SaturdayAssignmentsForStage",
       All(
         SaturdayMorningAssignmentsForStage({1, String}),
         SaturdayAfternoonAssignmentsForStage({1, String}),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), 2025-07-05) == {1, String})))))
