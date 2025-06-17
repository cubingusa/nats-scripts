#include "../../lib/_eligible_scramblers.cs"
#include "../../lib/_constants.cs"

Define("ScrambleSpeedWeight",
       [Tuple(_333, 3),
        Tuple(_222, 3),
        Tuple(_444, 5),
        Tuple(_555, 5),
        Tuple(_666, 8),
        Tuple(_777, 8),
        Tuple(_sq1, 5),
        Tuple(_clock, 5),
        Tuple(_pyram, 3),
        Tuple(_minx, 8),
        Tuple(_skewb, 3),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1),
        Tuple(_333mbf, 3),
        Tuple(_444bf, 3),
        Tuple(_555bf, 3)])

Define("StandardJobNames", ["judge", "scrambler", "runner", "Delegate"])

Define("VolunteerScorers",
       [
         PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
         PriorAssignmentScorer(-2, 0, 2025-07-03T00:00),
         PreferenceScorer(weight=5, prefix="percent-", prior=15, allJobs=["judge", "scrambler", "runner"]),
         SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
         ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),
         ConsecutiveJobScorer(30, -5, 0, jobs=["scrambler"]),
         MismatchedStationScorer(-10),
         SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                            Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                            Switch({1, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         FollowingGroupScorer(-50, maxMinutes=10, personFilter=Not(IsStageLead(Arg<Person>()))),
         FollowingGroupScorer(-10, maxMinutes=10, personFilter=IsStageLead(Arg<Person>())),
         ConditionalScorer(In(StringProperty("delegate-status"), ["WCA Full Delegate", "WCA Junior Delegate"]),
                           In(Stage(), FinalsStages()),
                           (Arg<String>() == "judge"),
                           (Arg<Number>() == 1),
                           50),
         ConditionalScorer(In(StringProperty("delegate-status"), ["WCA Trainee Delegate"]),
                           In(Stage(), FinalsStages()),
                           (Arg<String>() == "judge"),
                           (Arg<Number>() == 1),
                           25),
         ConditionalScorer(Or(BooleanProperty(MAIN_HALL_BACKUP_STAGE_LEAD),
                              BooleanProperty(BALLROOM_BACKUP_STAGE_LEAD)),
                           true, true, true, -100),
         # Since I asked Peri to scramble 7x7 despite her not listing it as a preference.
         ConditionalScorer((Name() == "Peri Le Dain"), (EventId(Event()) == "777"), (Arg<String>() == "scrambler"), true, -50)
       ])
