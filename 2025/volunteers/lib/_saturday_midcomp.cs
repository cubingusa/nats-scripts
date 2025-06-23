#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

Define("SaturdayMidcompAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _skewb-r1, {1, String}, 2025-07-05,
           [Judges(10, _skewb), Scramblers(3, _skewb), Runners(4), Delegates(2)],
           VolunteerScorers(_skewb, 2025-07-05)),
         DoVolunteerAssignments(
           _777-r2, {1, String}, 2025-07-05,
           [Judges(10, _777), Scramblers(4, _777), Runners(2), Delegates(2)],
           VolunteerScorers(_777, 2025-07-05)),
         DoVolunteerAssignments(
           _minx-r2, {1, String}, 2025-07-05,
           [Judges(10, _minx), Scramblers(4, _minx), Runners(4), Delegates(2)],
           VolunteerScorers(_minx, 2025-07-05)),
         DoVolunteerAssignments(
           _444-r2, {1, String}, 2025-07-05,
           [Judges(10, _444), Scramblers(4, _444), Runners(4), Delegates(2)],
           VolunteerScorers(_444, 2025-07-05)),
         DoVolunteerAssignments(
           _222-r2, {1, String}, 2025-07-05,
           [Judges(10, _222), Scramblers(3, _222), Runners(4), Delegates(2)],
           VolunteerScorers(_222, 2025-07-05))))
