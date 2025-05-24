#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"
#include "../lib/_group_counts.cs"

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

#define IS_FINALS_VOLUNTEER_PROPERTY "finals-volunteer"

Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Leads", (StringProperty(STAGE_LEAD) == STAGE_LEAD), 3, 10),
      LimitConstraint("Long Room yes", IsLongRoomYes(), 2, 10),
      LimitConstraint("Long Room maybe", IsLongRoomMaybe(), 3, 10),
      BalanceConstraint("< 18", (Age() < 18), 1),
      BalanceConstraint("delegate", IsDelegate(), 5),
      BalanceConstraint("Unavailable", NumberProperty("unavail"), 5)
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

Define("NPerGroup",
       (PsychSheetPosition({1, Event}) < ({2, Number} * {3, Number})))

Define(
    "SpecificTeams",
    [
      SpecificAssignmentScore(
        "ChineseTeams",
        In(Country(), ["CN", "HK", "TW"]),
        (Arg<Number>() <= 3),
        50),
      SpecificAssignmentScore(
        "ThursdayStrongPreference",
        Or(NPerGroup(_clock, MAIN_CLOCK, 8),
           NPerGroup(_555, MAIN_555, 8),
           NPerGroup(_333oh, MAIN_333OH, 8),
           NPerGroup(_pyram, MAIN_PYRAM, 8)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-03), MainStages()),
        50),
      SpecificAssignmentScore(
        "ThursdayWeakPreference",
        Or(NPerGroup(_clock, MAIN_CLOCK, 20),
           NPerGroup(_555, MAIN_555, 20),
           NPerGroup(_333oh, MAIN_333OH, 20),
           NPerGroup(_pyram, MAIN_PYRAM, 20)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-03), MainStages()),
        30),
      SpecificAssignmentScore(
        "FridayStrongPreference",
        Or(NPerGroup(_777, MAIN_777, 8),
           NPerGroup(_222, MAIN_222, 8),
           NPerGroup(_444, MAIN_444, 8),
           NPerGroup(_minx, MAIN_MINX, 8)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-04), MainStages()),
        50),
      SpecificAssignmentScore(
        "FridayWeakPreference",
        Or(NPerGroup(_777, MAIN_777, 20),
           NPerGroup(_222, MAIN_222, 20),
           NPerGroup(_444, MAIN_444, 20),
           NPerGroup(_minx, MAIN_MINX, 20)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-04), MainStages()),
        30),
      SpecificAssignmentScore(
        "SaturdayStrongPreference",
        Or(NPerGroup(_333bf, MAIN_333BF, 8),
           NPerGroup(_skewb, MAIN_SKEWB, 8),
           NPerGroup(_333, MAIN_333, 8),
           NPerGroup(_666, MAIN_666, 8)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-05), MainStages()),
        50),
      SpecificAssignmentScore(
        "SaturdayWeakPreference",
        Or(NPerGroup(_333bf, MAIN_333BF, 20),
           NPerGroup(_skewb, MAIN_SKEWB, 20),
           NPerGroup(_333, MAIN_333, 20),
           NPerGroup(_666, MAIN_666, 20)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-05), MainStages()),
        30),
      SpecificAssignmentScore(
        "SundayStrongPreference",
        Or(NPerGroup(_444bf, 1, 12),
           NPerGroup(_sq1, MAIN_SQ1, 8)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-06), MainStages()),
        50),
      SpecificAssignmentScore(
        "SundayWeakPreference",
        Or(NPerGroup(_444bf, 1, 20),
           NPerGroup(_sq1, MAIN_SQ1, 20)),
        In(AssignedStageForTeam(Arg<Number>(), 2025-07-06), MainStages()),
        30),
      SpecificAssignmentScore(
          "Bailing", (Name() == "Bailing Hou"), In(Arg<Number>(), [1, 8, 9]), 30)])

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
      SemiConstraints(),
      SpecificTeams()))
