#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-02

Define("ThursdayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _555bf-r1, {1, String}, DATE,
           [Judges(9), Scramblers(2, _555bf), Runners(2), Checkers(1), Delegates(2)],
           VolunteerScorers(_555bf, DATE)),
         DoVolunteerAssignments(
           _555-r1, {1, String}, DATE,
           [Judges(10), Scramblers(4, _555), Runners(4), Delegates(2)],
           VolunteerScorers(_555, DATE)),
         DoVolunteerAssignments(
           _clock-r1, {1, String}, DATE,
           [Judges(10), Scramblers(4, _clock), Runners(4), Delegates(2)],
           VolunteerScorers(_clock, DATE)),
         DoVolunteerAssignments(
           _333oh-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _333oh), Runners(4), Delegates(2)],
           VolunteerScorers(_333oh, DATE)),
         DoVolunteerAssignments(
           _pyram-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _pyram), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_pyram, DATE),
                  [ConditionalScorer(LikelyToAdvance(_555-r2, Arg<Person>()),
                                     true, true, (Arg<Number>() == 9), -50)])),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
