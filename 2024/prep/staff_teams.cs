#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"

#define LONG_ROOM_PREFERENCE "long-room-preference"
#define LONG_ROOM_YES "Yes please! As much as possible"
#define LONG_ROOM_MAYBE "I could do that for some of the competition, but not too much"

Define("IsLongRoomYes",
       And((StringProperty(LONG_ROOM_PREFERENCE) == LONG_ROOM_YES),
           Not(CompetingIn(_333fm)),
           Not(CompetingIn(_333mbf)),
           Not(CompetingIn(_555bf)),
           Not(HasProperty(STAGE_LEAD))))
Define("IsLongRoomMaybe",
       And(In(StringProperty(LONG_ROOM_PREFERENCE), [LONG_ROOM_YES, LONG_ROOM_MAYBE]),
           Not(CompetingIn(_555bf)),
           Not(HasProperty(STAGE_LEAD))))

# TODO: balance unavailability.
# TODO: add person avoidance.
Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Leads", HasProperty(STAGE_LEAD), 2, 10),
      LimitConstraint("Long Room yes", IsLongRoomYes(), 2, 10),
      LimitConstraint("Long Room maybe", IsLongRoomMaybe(), 3, 10)
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

Cluster(
    STAFF_TEAM, 4, Persons(BooleanProperty(CORE_STAFF)),
    StringProperty("staff-team-id"),
    Concat(
      BasicConstraints(),
      PreferenceConstraints(),
      ScramblerConstraints(),
      RoundOneConstraints(),
      RoundTwoConstraints(),
      SemiConstraints()))

DeleteProperty(Persons(HasProperty(LONG_ROOM_TEAM)), LONG_ROOM_TEAM)
Map([1, 2, 3, 4],
    If((Arg<Number>() == NumberProperty(STAFF_TEAM, 2014GULA02)),
        SetProperty([2014GULA02], LONG_ROOM_TEAM, 1),
        SetProperty([RandomChoice(Persons(And((NumberProperty(STAFF_TEAM) == Arg<Number>()),
                                              IsLongRoomYes())))],
                    LONG_ROOM_TEAM, 1)))

Map([1, 2, 3, 4],
    SetProperty([RandomChoice(Persons(And(Not(HasProperty(LONG_ROOM_TEAM)),
                                          IsLongRoomYes())))],
                LONG_ROOM_TEAM, 2))

Map([1, 2, 3, 4],
    SetProperty([RandomChoice(Persons(And(Not(HasProperty(LONG_ROOM_TEAM)),
                                          IsLongRoomMaybe())))],
                LONG_ROOM_TEAM, 3))
"Long room teams"
Map([1, 2, 3], All(Arg<Number>(), Persons((NumberProperty(LONG_ROOM_TEAM) == Arg<Number>()))))
