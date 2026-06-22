#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"

SetProperty([2017WOFF01], "group-number", 1)
Define(
    "PreferenceConstraints",
    Map(["judge", "scrambler", "runner"],
        BalanceConstraint((Arg<String>() + " Preference"), NumberProperty(("percent-" + Arg<String>())), 1)))

Define(
    "ScramblerConstraints",
    Map(
      [_555, _666, _777, _minx, _sq1, _clock],
      LimitConstraint((EventId() + " scramblers"), CanScramble(Arg<Event>()), 5, 5)))

DeleteProperty(Persons(HasProperty(FINALS_TEAM)), FINALS_TEAM)

Cluster(
    FINALS_TEAM, 2, Persons(BooleanProperty(FINALS_VOLUNTEER)),
    StringProperty("group-number"),
    Concat(PreferenceConstraints(), ScramblerConstraints()))
SetProperty([2017WOFF01], "group-number", 29)
