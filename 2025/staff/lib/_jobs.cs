#include "../../lib/_constants.cs"
#include "../../lib/_eligible_scramblers.cs"

Define("EligibleJudge", Not(And((WcaId() == "2008YUNS01"),
                                 In({1, Event}, [_skewb, _sq1]))))

Define("Judges", Job("judge", 10,
                     assignStations=true,
                     eligibility=And(EligibleJudge({2, Event}),
                                     Not(HasProperty(STAGE_LEAD)),
                                     BooleanProperty(CORE_STAFF))))
Define("Scramblers", Job("scrambler", {1, Number},
                         eligibility=And(CanScramble({2, Event}),
                                         (NumberProperty("percent-scrambler") > 0),
                                         Not(HasProperty(STAGE_LEAD)),
                                         BooleanProperty(CORE_STAFF))))
Define("Runners", Job("runner", {1, Number},
                      eligibility=And((NumberProperty("percent-runner") > 0),
                                      Not(HasProperty(STAGE_LEAD)),
                                      BooleanProperty(CORE_STAFF))))
Define("Primary Delegate", Job("Primary Delegate", 1, eligibility=BooleanProperty(STAGE_LEAD)))
Define("Secondary Delegate", Job("Secondary Delegate", 1, eligibility=BooleanProperty(STAGE_LEAD)))
