#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-05

Define("SundayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _444bf-r1, {1, String}, DATE,
           [Judges(9), Scramblers(2, _444bf), Runners(2), Checkers(1), Delegates(2)],
           VolunteerScorers(_444bf, DATE)),
         DoVolunteerAssignments(
           _minx-r1, {1, String}, DATE,
           [Judges(10), Scramblers(4, _minx), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_minx, DATE),
                  [ConditionalScorer(LikelyToAdvance(_skewb-r2, Arg<Person>()),
                                     true, true, (Arg<Number>() == 2), -50)])),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
