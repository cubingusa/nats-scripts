#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-02

Define("ThursdayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _333oh-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _333oh), Runners(4), Delegates(2)],
           VolunteerScorers(_333oh, DATE)),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
