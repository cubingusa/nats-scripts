#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

Define("ThursdayMidcompAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _clock-r2, {1, String}, 2025-07-03,
           [Judges(10, _clock), Scramblers(3, _clock), Runners(4), Delegates(2)],
           VolunteerScorers(_clock, 2025-07-03)),
         DoVolunteerAssignments(
           _555-r2, {1, String}, 2025-07-03,
           [Judges(10, _555), Scramblers(4, _555), Runners(4), Delegates(2)],
           VolunteerScorers(_555, 2025-07-03))))
