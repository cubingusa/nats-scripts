#include "../../lib/_constants.cs"
#include "../../lib/_eligible_scramblers.cs"

Define("Judges", Job("judge", {1, Number},
                     assignStations=true))
Define("Scramblers", Job("scrambler", {1, Number},
                         eligibility=And(CanScramble({2, Event}),
                                         (NumberProperty("percent-scrambler") > 0))))
Define("Runners", Job("runner", {1, Number},
                      eligibility=(NumberProperty("percent-runner") > 0)))
Define("Checkers", Job("ScrambleChecker", {1, Number}))

Define("Delegates", Job("Delegate", {1, Number}, eligibility=BooleanProperty(STAGE_LEAD)))
Define("FinalsDelegates", Job("Delegate", {1, Number}, eligibility=BooleanProperty(FINALS_STAGE_LEAD)))
