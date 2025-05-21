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

Define("StandardJobNames", ["judge", "scrambler", "runner", "Primary Delegate", "Secondary Delegate"])

Define("VolunteerScorers",
       [
         PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
         PreferenceScorer(weight=5, prefix="percent-", prior=15, allJobs=StandardJobNames()),
         SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
         ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),
         MismatchedStationScorer(-10),
         SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                            Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                            Switch({1, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         FollowingGroupScorer(-50),
         ConditionalScorer((StringProperty("delegate-status") == "Not a WCA Delegate"),
                           In(Stage(), FinalsStages()),
                           (Arg<String>() == "judge"),
                           (Arg<Number>() == 1),
                           -50)
       ])
