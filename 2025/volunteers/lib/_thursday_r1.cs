#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

Define("ThursdayMorningAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _555bf-r1, {1, String}, 2025-07-03,
           [Judges(10, _555bf), Scramblers(3, _555bf), Runners(2), Checkers(1), Delegates(2)],
           VolunteerScorers(_555bf, 2025-07-03)),
         DoVolunteerAssignments(
           _clock-r1, {1, String}, 2025-07-03,
           [Judges(10, _clock), Scramblers(3, _clock), Runners(4), Delegates(2)],
           VolunteerScorers(_clock, 2025-07-03)),
         DoVolunteerAssignments(
           _555-r1, {1, String}, 2025-07-03,
           [Judges(10, _555), Scramblers(4, _555), Runners(4), Delegates(2)],
           VolunteerScorers(_555, 2025-07-03))))

Define("ThursdayAfternoonAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _333oh-r1, {1, String}, 2025-07-03,
           [Judges(10, _333oh), Scramblers(3, _333oh), Runners(4), Delegates(2)],
           VolunteerScorers(_333oh, 2025-07-03)),
         DoVolunteerAssignments(
           _pyram-r1, {1, String}, 2025-07-03,
           [Judges(10, _pyram), Scramblers(3, _pyram), Runners(4), Delegates(2)],
           VolunteerScorers(_pyram, 2025-07-03))))

# Args:
# 1: Stage
Define("ThursdayAssignmentsForStage",
    All(
      ThursdayMorningAssignmentsForStage({1, String}),
      ThursdayAfternoonAssignmentsForStage({1, String}),
      WorkloadReport(Persons((AssignedStage(Arg<Person>(), 2025-07-03) == {1, String})))))
