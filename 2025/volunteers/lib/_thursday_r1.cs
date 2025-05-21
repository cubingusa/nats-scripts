#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

# Args:
# 1: Stage
Define("ThursdayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _555bf-r1, {1, String}, 2025-07-03,
           [Judges(10, _555bf), Scramblers(3, _555bf), Runners(2), Checkers(1),
            PrimaryDelegate(), SecondaryDelegate()],
           VolunteerScorers(_555bf, 2025-07-03)),
         DoVolunteerAssignments(
           _clock-r1, {1, String}, 2025-07-03,
           [Judges(10, _clock), Scramblers(3, _clock), Runners(4),
            PrimaryDelegate(), SecondaryDelegate()],
           VolunteerScorers(_clock, 2025-07-03)),
         DoVolunteerAssignments(
           _555-r1, {1, String}, 2025-07-03,
           [Judges(10, _555), Scramblers(4, _555), Runners(4),
            PrimaryDelegate(), SecondaryDelegate()],
           VolunteerScorers(_555, 2025-07-03)),
         DoVolunteerAssignments(
           _pyram-r1, {1, String}, 2025-07-03,
           [Judges(10, _pyram), Scramblers(3, _pyram), Runners(4),
            PrimaryDelegate(), SecondaryDelegate()],
           VolunteerScorers(_pyram, 2025-07-03))))
