#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "../../reports/_volunteer_workload.cs"

#define DATE 2026-07-03

Define("JudgesForStage", Judges(If(In({1, String}, [RED, BLUE]), 12, 10)))
Define("RunnersForStage", Runners(If(In({1, String}, [RED, BLUE]), 5, 4)))

Define("FridayAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _222-r1, {1, String}, DATE,
           [JudgesForStage({1, String}), Scramblers(3, _222), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_222, DATE)),
         DoVolunteerAssignments(
           _666-r1, {1, String}, DATE,
           [JudgesForStage({1, String}), Scramblers(4, _666), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_666, DATE)),
         DoVolunteerAssignments(
           _333oh-r2, {1, String}, DATE,
           [JudgesForStage({1, String}), Scramblers(3, _333oh), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_333oh, DATE)),
         DoVolunteerAssignments(
           _pyram-r2, {1, String}, DATE,
           [JudgesForStage({1, String}), Scramblers(3, _pyram), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_pyram, DATE)),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() < 4)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [JudgesForStage({1, String}), Scramblers(4, _444), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>()), overwrite=true),
         SetProperty([2013MART03], STAFF_TEAM, 2),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() >= 4), (GroupNumber() <= 7)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [JudgesForStage({1, String}), Scramblers(4, _444), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>()), overwrite=true),
         SetProperty([2013MART03], STAFF_TEAM, 3),
         AssignStaff(
           _444-r1, And((Stage() == {1, String}), (GroupNumber() > 7)),
           Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})),
           [JudgesForStage({1, String}), Scramblers(4, _444), RunnersForStage({1, String}), Delegates(2)],
           VolunteerScorers(_444, DATE),
           unavailable=Unavailable(Arg<Person>()), overwrite=true),
         DoVolunteerAssignments(
           _sq1-r1, {1, String}, DATE,
           [JudgesForStage({1, String}), Scramblers(3, _sq1), RunnersForStage({1, String}), Delegates(2)],
           Concat(VolunteerScorers(_sq1, DATE),
                  [ConditionalScorer(LikelyToAdvance(_555-r3, Arg<Person>()),
                                     true, true, (Arg<Number>() == 2), -50)])),
         WorkloadReport(Persons((AssignedStage(Arg<Person>(), DATE) == {1, String})))))
