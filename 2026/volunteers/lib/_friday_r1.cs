#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-03

Define("FridayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _222-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _222), Runners(4), Delegates(2)],
           VolunteerScorers(_222, DATE)),
         DoVolunteerAssignments(
           _666-r1, {1, String}, DATE,
           [Judges(10), Scramblers(4, _666), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_666, DATE),
                  [ConditionalScorer(LikelyToAdvance(_333oh-r2, Arg<Person>()),
                                     true, true, (Arg<Number>() == 2), -50)])),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() < 4)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [Judges(10), Scramblers(4, _444), Runners(4), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>())),
         SetProperty([2013MART03], STAFF_TEAM, 2),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() >= 4), (GroupNumber() <= 7)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [Judges(10), Scramblers(4, _444), Runners(4), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>())),
         SetProperty([2013MART03], STAFF_TEAM, 3),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() > 7)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [Judges(10), Scramblers(4, _444), Runners(4), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>())),
         DoVolunteerAssignments(
           _sq1-r1, {1, String}, DATE,
           [Judges(10), Scramblers(3, _sq1), Runners(4), Delegates(2)],
           Concat(VolunteerScorers(_sq1, DATE),
                  [ConditionalScorer(LikelyToAdvance(_555-r3, Arg<Person>()),
                                     true, true, (Arg<Number>() == 2), -50)])),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
