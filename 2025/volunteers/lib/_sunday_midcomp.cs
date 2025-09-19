#include "_assign.cs"
#include "_jobs.cs"
#include "_scorers.cs"

Define("SundayMidcompAssignmentsForStage",
       All(
         DoVolunteerAssignments(
           _sq1-r1, {1, String}, 2025-07-06,
           [Judges(10, _sq1), Scramblers(3, _sq1), Runners(4), Delegates(2)],
           VolunteerScorers(_sq1, 2025-07-06)),
         DoVolunteerAssignments(
           _333-r2, {1, String}, 2025-07-06,
           [Judges(10, _333), Scramblers(4, _333), Runners(2), Delegates(2)],
           VolunteerScorers(_333, 2025-07-06)),
         DoVolunteerAssignments(
           _666-r2, {1, String}, 2025-07-06,
           [Judges(10, _666), Scramblers(4, _666), Runners(3), Delegates(2)],
           VolunteerScorers(_666, 2025-07-06)),
         DoVolunteerAssignments(
           _skewb-r2, {1, String}, 2025-07-06,
           [Judges(10, _skewb), Scramblers(3, _skewb), Runners(4), Delegates(2)],
           VolunteerScorers(_skewb, 2025-07-06)),
         DoVolunteerAssignments(
           _333bf-r2, {1, String}, 2025-07-06,
           [Judges(10, _333bf), Scramblers(2, _333bf), Runners(3), Delegates(2)],
           VolunteerScorers(_333bf, 2025-07-06))))

Define("SquareOneSemiAssignments",
       Map(MainStages(),
           DoVolunteerAssignments(_sq1-r2, Arg<String>(), 2025-07-06,
                                  [Judges(10, _sq1), Scramblers(3, _sq1), Runners(5), Delegates(2)],
                                  VolunteerScorers(_sq1, 2025-07-06))))

Define("ThreeSemiAssignments",
       Map(MainStages(),
           DoVolunteerAssignments(_333-r3, Arg<String>(), 2025-07-06,
                                  [Judges(10, _333), Scramblers(3, _333), Runners(5),
                                   Checkers(1), Delegates(2)],
                                  Concat(VolunteerScorers(_333, 2025-07-06),
                                         [ConditionalScorer(HasProperty(FINALS_TEAM),
                                                            In(Stage(), FinalsStages()),
                                                            (Arg<String>() == "runner"),
                                                            true, 20)]))))
