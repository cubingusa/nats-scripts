#include "../../lib/_constants.cs"
#include "../../lib/_eligible_scramblers.cs"

Define("FinalsJudges", Job("judge", 10,
                           assignStations=true,
                           eligibility=Not(HasRole(ORGANIZER))))
Define("FinalsScramblers", Job("scrambler", {1, Number},
                               eligibility=And(CanScramble({2, Event}),
                                               (NumberProperty("percent-scrambler") > 0),
                                               Not(HasRole(ORGANIZER)))))
Define("FinalsCheckers", Job("ScrambleChecker", {1, Number},
                             eligibility=Not(HasRole(ORGANIZER))))
Define("FinalsRunners", Job("runner", {1, Number},
                            eligibility=And((NumberProperty("percent-runner") > 0),
                                            Not(HasRole(ORGANIZER)))))

Define("FinalsDelegates", Job("Delegate", {1, Number}, eligibility=HasRole(ORGANIZER)))
