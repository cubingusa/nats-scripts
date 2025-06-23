#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

Define("FridayMidcompAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _222-r1, {1, String}, 2025-07-04,
           [Judges(10, _222), Scramblers(3, _222), Runners(4), Delegates(2)],
           VolunteerScorers(_222, 2025-07-04)),
         DoVolunteerAssignments(
           _333oh-r2, {1, String}, 2025-07-04,
           [Judges(10, _333oh), Scramblers(3, _333oh), Runners(4), Delegates(2)],
           VolunteerScorers(_333oh, 2025-07-04)),
         DoVolunteerAssignments(
           _pyram-r2, {1, String}, 2025-07-04,
           [Judges(10, _pyram), Scramblers(3, _pyram), Runners(4), Delegates(2)],
           VolunteerScorers(_pyram, 2025-07-04))))
