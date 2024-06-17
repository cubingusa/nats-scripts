#include "../../lib/_eligible_scramblers.cs"

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

# Commentators with a PR under this time are favored.
Define("CommentaryTargets",
       [Tuple(_333, 10s),
        Tuple(_222, 4s),
        Tuple(_444, 0:45s),
        Tuple(_555, 1:15s),
        Tuple(_666, 2:30s),
        Tuple(_777, 3:30s),
        Tuple(_333bf, 1:00s),
        Tuple(_333oh, 20s),
        Tuple(_sq1, 15s),
        Tuple(_clock, 8s),
        Tuple(_pyram, 5s),
        Tuple(_minx, 1:15s),
        Tuple(_skewb, 8s),
        Tuple(_444bf, 10:00s)])

Define("StandardJobNames", ["judge", "scrambler", "runner", "Delegate"])

Define("StaffScorers",
       [
         PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
         PreferenceScorer(weight=5, prefix="percent-", prior=15, allJobs=StandardJobNames()),
         SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
         ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),
         MismatchedStationScorer(-10),
         SolvingSpeedScorer({1, Event},
                            Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                            Switch({1, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         FollowingGroupScorer(-50),
         SameJobScorer(40, -10, 5, jobs=["Commentator"]),
         SolvingSpeedScorer({1, Event},
                            Switch({1, Event}, CommentaryTargets()),
                            10,
                            ["Commentator"])
       ])
