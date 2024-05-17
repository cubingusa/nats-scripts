#include "lib/_constants.cs"
#include "lib/_eligible_scramblers.cs"

# TODO: limit number of stage leads per group.
# TODO: balance unavailability.
# TODO: add person avoidance.
Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2)
    ])

Define(
    "PreferenceConstraints",
    Map(["judge", "scrambler", "runner"],
        BalanceConstraint((Arg<String>() + " Preference"), NumberProperty(("percent-" + Arg<String>())), 1)))

Define(
    "ScramblerConstraints",
    Concat(
      Map(
        [_555, _666, _777, _minx, _sq1, _clock],
        LimitConstraint((EventId() + " scramblers"), And(CanScramble(Arg<Event>()),
                                                         Not(HasRole("delegate"))), 8, 5)),
      Map(
        [_555, _minx, _sq1, _clock],
        LimitConstraint((EventId() + " semi scramblers"), And(CanScramble(Arg<Event>()),
                                                              (PsychSheetPosition() > 150),
                                                              Not(HasRole("delegate"))), 4, 5))))

Define(
    "RoundOneConstraints",
    Concat(Map([_333, _222, _444, _pyram, _skewb, _333oh],
               BalanceConstraint(EventId(), CompetingIn(), 0.05)),
           Map([_555, _666, _777, _333bf, _clock, _sq1, _minx, _444bf],
               BalanceConstraint(EventId(), CompetingIn(), 0.1)),
           Map([_333mbf, _333fm, _555bf],
               BalanceConstraint(EventId(), CompetingIn(), 1))))

Define(
    "RoundTwoConstraints",
    Map([_333, _222],
        BalanceConstraint((EventId() + "-r2"), (PsychSheetPosition() < 500), 0.1)))

Define(
    "SemiConstraints",
    Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _pyram, _skewb, _sq1, _minx],
      BalanceConstraint((EventId() + "-semi"), (PsychSheetPosition() < 125), 0.2)))

DeleteProperty(Persons(HasProperty(STAFF_TEAM)), STAFF_TEAM)

# TODO: switch to 4 teams once more people have filled out the form.
Cluster(
    STAFF_TEAM, 3, Persons(BooleanProperty(CORE_STAFF)),
    "",  # TODO: use the preassigned group IDs.
    Concat(
      BasicConstraints(),
      PreferenceConstraints(),
      ScramblerConstraints(),
      RoundOneConstraints(),
      RoundTwoConstraints(),
      SemiConstraints()))
