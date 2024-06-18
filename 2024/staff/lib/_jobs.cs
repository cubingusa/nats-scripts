#include "../../lib/_eligible_scramblers.cs"

Define("EligibleRunner", Not(And((Name() == "Rachel Feran"),
                                 In({1, Event}, [_222, _333, _333oh, _pyram, _skewb]))))

Define("Judges", Job("judge", 10,
                     assignStations=true,
                     eligibility=And(Not(HasProperty(STAGE_LEAD)),
                                     BooleanProperty(CORE_STAFF))))
Define("Scramblers", Job("scrambler", {1, Number},
                         eligibility=And(CanScramble({2, Event}),
                                         (NumberProperty("percent-scrambler") > 0),
                                         Not(HasProperty(STAGE_LEAD)),
                                         BooleanProperty(CORE_STAFF))))
Define("Runners", Job("runner", {1, Number},
                      eligibility=And(EligibleRunner({2, Event}),
                                      (NumberProperty("percent-runner") > 0),
                                      Not(HasProperty(STAGE_LEAD)),
                                      BooleanProperty(CORE_STAFF))))
Define("Delegate", Job("Delegate", 1, eligibility=BooleanProperty(STAGE_LEAD)))
