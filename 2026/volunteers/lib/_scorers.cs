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

Define("StandardJobNames", ["judge", "scrambler", "runner"])
Define("AllJobNames", ["judge", "scrambler", "runner", "ScrambleChecker", "Delegate"])

Define("VolunteerScorers",
       [
         PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
         PriorAssignmentScorer(-2, 0, 2026-07-02T00:00),
         PreferenceScorer(weight=5, prefix="percent-", prior=15, allJobs=StandardJobNames()),
         SameJobScorer(60, -5, 4, jobs=AllJobNames()),
         ConsecutiveJobScorer(90, -3, 0, jobs=AllJobNames()),
         ConsecutiveJobScorer(30, -10, 0, jobs=["scrambler"]),
         ConsecutiveJobScorer(40, -50, 0, jobs=["scrambler"]),
         MismatchedStationScorer(-10),
         SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                            Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                            Switch({1, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         FollowingGroupScorer(-50),
         ConditionalScorer(In(StringProperty("delegate-status"), ["WCA Full Delegate", "WCA Junior Delegate"]),
                           In(Stage(), FinalsStages()),
                           (Arg<String>() == "judge"),
                           (Arg<Number>() < 3),
                           50),
         ConditionalScorer(In(StringProperty("delegate-status"), ["WCA Trainee Delegate"]),
                           In(Stage(), FinalsStages()),
                           (Arg<String>() == "judge"),
                           (Arg<Number>() < 3),
                           25),
         ConditionalScorer(And(BooleanProperty(STAGE_LEAD), (NumberProperty(STAFF_TEAM) != 4)),
                           true, true, true, -20),
         ConditionalScorer(And(BooleanProperty(STAGE_LEAD), (NumberProperty(STAFF_TEAM) == 4)),
                           true, true, true, -5)
       ])
