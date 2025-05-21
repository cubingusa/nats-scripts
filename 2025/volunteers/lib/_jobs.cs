#include "../../lib/_constants.cs"
#include "../../lib/_eligible_scramblers.cs"

Define("EligibleJudge", Not(And((WcaId() == "2008YUNS01"),
                                 In({1, Event}, [_skewb, _sq1]))))

Define("Judges", Job("judge", 10,
                     assignStations=true,
                     eligibility=And(EligibleJudge({2, Event}),
                                     Not(BooleanProperty(STAGE_LEAD)),
                                     BooleanProperty(CORE_VOLUNTEER))))
Define("Scramblers", Job("scrambler", {1, Number},
                         eligibility=And(CanScramble({2, Event}),
                                         (NumberProperty("percent-scrambler") > 0),
                                         Not(BooleanProperty(STAGE_LEAD)),
                                         BooleanProperty(CORE_VOLUNTEER))))
Define("Checkers", Job("ScrambleChecker", {1, Number},
                       eligibility=And(Not(BooleanProperty(STAGE_LEAD)),
                                       BooleanProperty(CORE_VOLUNTEER))))
Define("Runners", Job("runner", {1, Number},
                      eligibility=And((NumberProperty("percent-runner") > 0),
                                      Not(BooleanProperty(STAGE_LEAD)),
                                      BooleanProperty(CORE_VOLUNTEER))))
Define("PrimaryDelegate", Job("Delegate", 1, eligibility=BooleanProperty(STAGE_LEAD)))
Define("SecondaryDelegate", Job("SecondaryDelegate", 1, eligibility=BooleanProperty(STAGE_LEAD)))
