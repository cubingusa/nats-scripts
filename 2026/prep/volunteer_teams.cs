#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"

Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Leads", IsStageLead(), 3, 10),
      BalanceConstraint("< 18", (Age() < 18), 1),
      BalanceConstraint("delegate", IsDelegate(), 5),
      BalanceConstraint("Unavailable", NumberProperty("unavail"), 5),
      BalanceConstraint("Uncertain", (StringProperty("uncertain") == "uncertain"), 5)
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
                                                         Not(HasRole("delegate")),
                                                         (NumberProperty("percent-scrambler") > 0)), 8, 5)),
      Map(
        [_555, _sq1, _clock],
        LimitConstraint((EventId() + " semi scramblers"), And(CanScramble(Arg<Event>()),
                                                              Not((PsychSheetPosition() < 75)),
                                                              Not(IsStageLead()),
                                                              (NumberProperty("percent-scrambler") > 0)), 5, 10))))

Define(
    "RoundOneConstraints",
    Concat(Map([_333, _222, _444, _pyram, _skewb, _333oh],
               BalanceConstraint(EventId(), CompetingIn(), 0.05)),
           Map([_555, _666, _777, _333bf, _clock, _sq1, _minx, _444bf],
               BalanceConstraint(EventId(), CompetingIn(), 0.1)),
           [BalanceConstraint("555bf", CompetingIn(_555bf), 3)]))

Define(
    "AdvancementConstraints",
    Concat(
      [BalanceConstraint("333-r2", (PsychSheetPosition(_333) < 400), 0.1)],
      Map([_222, _444, _pyram, _skewb, _333oh],
          BalanceConstraint((EventId() + "-semi"), (PsychSheetPosition() < 150), 2)),
      Map([_333, _555, _333bf, _clock, _sq1],
          BalanceConstraint((EventId() + "-semi"), (PsychSheetPosition() < 75), 2))))

Define(
    "LongRoomConstraints",
    [
      BalanceConstraint("FMC", Or(CompetingIn(_333fm),
                                  In("FMC 1", ArrayProperty(LONG_ROOM_ASSIGNMENTS)),
                                  In("FMC 2", ArrayProperty(LONG_ROOM_ASSIGNMENTS)),
                                  In("FMC 3", ArrayProperty(LONG_ROOM_ASSIGNMENTS))), 5),
      BalanceConstraint("Multi", Or(CompetingIn(_333mbf),
                                    In("Multi 1", ArrayProperty(LONG_ROOM_ASSIGNMENTS)),
                                    In("Multi 2", ArrayProperty(LONG_ROOM_ASSIGNMENTS))), 5)
    ]
)

DeleteProperty(Persons(HasProperty(STAFF_TEAM)), STAFF_TEAM)

Cluster(
    STAFF_TEAM, 4, Persons(Or(BooleanProperty(CORE_VOLUNTEER), IsStageLead())),
    StringProperty("group-number"),
    Concat(
      BasicConstraints(),
      PreferenceConstraints(),
      ScramblerConstraints(),
      LongRoomConstraints(),
      RoundOneConstraints(),
      AdvancementConstraints()))
