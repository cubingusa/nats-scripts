#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-04

Define("SaturdayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _333bf-r1, {1, String}, DATE,
           [Judges(10), Scramblers(2, _333bf), Runners(4), Delegates(2)],
           VolunteerScorers(_333bf, DATE)),
         DoVolunteerAssignments(
           _skewb-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _skewb), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_skewb, DATE),
                  [ConditionalScorer(LikelyToAdvance(_444-r2, Arg<Person>()),
                                     true, true, (Arg<Number>() == 9), -50)])),
         DoVolunteerAssignments(
           _333-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _333), Runners(4), Delegates(2)],
           VolunteerScorers(_333, DATE)),
         DoVolunteerAssignments(
           _777-r1, {1, String}, DATE,
           [Judges(10), Scramblers(4, _777), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_777, DATE),
                  [ConditionalScorer(LikelyToAdvance(_444-r3, Arg<Person>()),
                                     true, true, (Arg<Number>() == 2), -50)])),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
