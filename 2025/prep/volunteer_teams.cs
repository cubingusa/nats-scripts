#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"

#define LONG_ROOM_PREFERENCE "long-room-preference"
#define LONG_ROOM_YES "Yes please! As much as possible"
#define LONG_ROOM_MAYBE "I could do that for some of the competition, but not too much"

Define("IsLongRoomYes",
       And((StringProperty(LONG_ROOM_PREFERENCE) == LONG_ROOM_YES),
           Not((PsychSheetPosition(_333fm) <= 50)),
           Not((PsychSheetPosition(_333mbf) <= 50)),
           Not(HasProperty(STAGE_LEAD))))
Define("IsLongRoomMaybe",
       And(In(StringProperty(LONG_ROOM_PREFERENCE), [LONG_ROOM_YES, LONG_ROOM_MAYBE]),
           Not(HasProperty(STAGE_LEAD))))

#define UNOFFICIAL_PREFERENCE "unofficial-preference"
#define UNOFFICIAL_YES "Yes definitely!"
#define UNOFFICIAL_MAYBE "I could help some"

#define STAGE_LEAD_CAPTAIN "stage-lead-captain"
#define STAGE_LEAD_REGULAR "stage-lead-regular"
#define IS_FINALS_VOLUNTEER_PROPERTY "finals-volunteer"

Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Lead Captains", (StringProperty(STAGE_LEAD) == STAGE_LEAD_CAPTAIN), 1, 10),
      LimitConstraint("Stage Leads", (StringProperty(STAGE_LEAD) == STAGE_LEAD_REGULAR), 2, 10),
      LimitConstraint("Long Room yes", IsLongRoomYes(), 2, 10),
      LimitConstraint("Long Room maybe", IsLongRoomMaybe(), 3, 10),
      BalanceConstraint("delegate", (StringProperty("delegate-status") != "Not a WCA Delegate"), 5)
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
                                                              Not(HasRole("delegate"))), 5, 10))))

Define(
    "RoundOneConstraints",
    Concat(Map([_333, _222, _444, _pyram, _skewb, _333oh],
               BalanceConstraint(EventId(), CompetingIn(), 0.05)),
           Map([_555, _666, _777, _333bf, _clock, _sq1, _minx, _444bf],
               BalanceConstraint(EventId(), CompetingIn(), 0.1)),
           [BalanceConstraint("555bf", CompetingIn(_555bf), 3),
            BalanceConstraint("333fm", (PsychSheetPosition(_333fm) <= 30), 3),
            BalanceConstraint("333mbf", (PsychSheetPosition(_333mbf) <= 20), 3)]))

Define(
    "RoundTwoConstraints",
    Map([_333, _222],
        BalanceConstraint((EventId() + "-r2"), (PsychSheetPosition() < 800), 0.1)))

Define(
    "SemiConstraints",
    Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _pyram, _skewb, _sq1, _minx],
      BalanceConstraint((EventId() + "-semi"), (PsychSheetPosition() < 200), 2)))

DeleteProperty(Persons(HasProperty(STAFF_TEAM)), STAFF_TEAM)

Cluster(
    STAFF_TEAM, 10, Persons(BooleanProperty(CORE_VOLUNTEER)),
    StringProperty("group-number"),
    Concat(
      BasicConstraints(),
      PreferenceConstraints(),
      ScramblerConstraints(),
      RoundOneConstraints(),
      RoundTwoConstraints(),
      SemiConstraints()))
