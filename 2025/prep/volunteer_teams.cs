#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"
#include "../lib/_group_counts.cs"

#define LONG_ROOM_PREFERENCE "long-room-preference"
#define LONG_ROOM_YES "Yes please! As much as possible."
#define LONG_ROOM_MAYBE "I could do that for some of the competition, but not too much."

Define("FMCEligible",
       And(In(StringProperty(LONG_ROOM_PREFERENCE), [LONG_ROOM_YES, LONG_ROOM_MAYBE]),
           Not(CompetingIn(_333fm)),
           Not(IsStageLead()),
           IsDelegate()))
Define("MultiYes",
       And(In(StringProperty(LONG_ROOM_PREFERENCE), [LONG_ROOM_YES]),
           Not(CompetingIn(_333mbf)),
           Not(IsStageLead()),
           IsDelegate()))
Define("MultiMaybe",
       And(In(StringProperty(LONG_ROOM_PREFERENCE), [LONG_ROOM_YES, LONG_ROOM_MAYBE]),
           Not(CompetingIn(_333mbf)),
           Not(IsStageLead()),
           IsDelegate()))

#define UNOFFICIAL_PREFERENCE "unofficial-preference"
#define UNOFFICIAL_YES "Yes definitely!"
#define UNOFFICIAL_MAYBE "I could help some"

#define IS_FINALS_VOLUNTEER_PROPERTY "finals-volunteer"

Define("FTOEligible",
       And(In(StringProperty(UNOFFICIAL_PREFERENCE), [UNOFFICIAL_YES, UNOFFICIAL_MAYBE]),
           Not(IsStageLead()),
           In("FTO", ArrayProperty("unofficial-events"))))
Define("MirrorBlocksEligible",
       And(In(StringProperty(UNOFFICIAL_PREFERENCE), [UNOFFICIAL_YES, UNOFFICIAL_MAYBE]),
           Not(IsStageLead()),
           In("Mirror Blocks", ArrayProperty("unofficial-events"))))
Define("TeamBLDEligible",
       And((StringProperty(UNOFFICIAL_PREFERENCE) == UNOFFICIAL_YES),
           Not(IsStageLead()),
           In("3x3 (Team BLD)", ArrayProperty("unofficial-events"))))

Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Leads", IsStageLead(), 3, 10),
      BalanceConstraint("Multi yes", MultiYes(), 5),
      LimitConstraint("Multi maybe", MultiMaybe(), 3, 10),
      LimitConstraint("FMC yes", FMCEligible(), 3, 10),
      BalanceConstraint("< 18", (Age() < 18), 1),
      BalanceConstraint("delegate", IsDelegate(), 5),
      BalanceConstraint("Unavailable", NumberProperty("unavail"), 5),
      LimitConstraint("FTOEligible", FTOEligible(), 2, 10),
      LimitConstraint("MirrorBlocksEligible", MirrorBlocksEligible(), 2, 10),
      LimitConstraint("TeamBLDEligible", TeamBLDEligible(), 2, 10)
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
            BalanceConstraint("333fm", CompetingIn(_333fm), 3),
            BalanceConstraint("333mbf", CompetingIn(_333mbf), 3)]))

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

DeleteProperty(Persons(HasProperty(MULTI_VOLUNTEER)), MULTI_VOLUNTEER)
DeleteProperty(Persons(HasProperty(FMC_VOLUNTEER)), FMC_VOLUNTEER)
DeleteProperty(Persons(HasProperty(FTO_VOLUNTEER)), FTO_VOLUNTEER)
DeleteProperty(Persons(HasProperty(MIRROR_BLOCKS_VOLUNTEER)), MIRROR_BLOCKS_VOLUNTEER)
DeleteProperty(Persons(HasProperty(TEAM_BLD_VOLUNTEER)), TEAM_BLD_VOLUNTEER)
# Args:
# 1: Team number
# 2: Max needed
# 3: Property name
# 4: Eligibility
Define("MaybeSelectLongRoomPerson",
       If((Length(Persons(And((NumberProperty(STAFF_TEAM) == {1, Number}),
                               BooleanProperty({3, String})))) < {2, Number}),
          SetProperty(Filter([RandomChoice(Persons(And(
              (NumberProperty(STAFF_TEAM) == {1, Number}),
              {4, Boolean(Person)},
              Not(BooleanProperty(FMC_VOLUNTEER)),
              Not(BooleanProperty(MULTI_VOLUNTEER)))))], Not(IsNull(Arg<Person>()))),
            {3, String}, true),
          ""))

SetProperty(Persons(MultiYes()), MULTI_VOLUNTEER, true)
Persons(And((NumberProperty(STAFF_TEAM) == 1), MultiMaybe(), Not(BooleanProperty(FMC_VOLUNTEER)),
               Not(BooleanProperty(MULTI_VOLUNTEER))))
Map([1, 2, 3, 4, 5],
    All(
      MaybeSelectLongRoomPerson(Arg<Number>(), 2, MULTI_VOLUNTEER, MultiMaybe()),
      MaybeSelectLongRoomPerson(Arg<Number>(), 2, MULTI_VOLUNTEER, MultiMaybe())))
Map([1, 2, 3, 4, 5],
    MaybeSelectLongRoomPerson(Arg<Number>(), 1, FMC_VOLUNTEER, FMCEligible()))
Map([6, 7, 8, 9, 10],
    All(
      MaybeSelectLongRoomPerson(Arg<Number>(), 3, MULTI_VOLUNTEER, MultiMaybe()),
      MaybeSelectLongRoomPerson(Arg<Number>(), 3, MULTI_VOLUNTEER, MultiMaybe()),
      MaybeSelectLongRoomPerson(Arg<Number>(), 3, MULTI_VOLUNTEER, MultiMaybe())))

SetProperty([2010AMBR01], FMC_VOLUNTEER, true)
SetProperty([2010AMBR01], MULTI_VOLUNTEER, true)

Map([1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    SetProperty(Filter([RandomChoice(Persons(And(
            FTOEligible(),
            Not(BooleanProperty(FMC_VOLUNTEER)),
            Not(BooleanProperty(MULTI_VOLUNTEER)),
            (NumberProperty(STAFF_TEAM) == Arg<Number>()))))], Not(IsNull(Arg<Person>()))),
      FTO_VOLUNTEER, true))

Map([1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    SetProperty(Filter([RandomChoice(Persons(And(
            MirrorBlocksEligible(),
            Not(BooleanProperty(FMC_VOLUNTEER)),
            Not(BooleanProperty(MULTI_VOLUNTEER)),
            Or(Not(BooleanProperty(FTO_VOLUNTEER)),
               (StringProperty(UNOFFICIAL_PREFERENCE) == UNOFFICIAL_YES)),
            (NumberProperty(STAFF_TEAM) == Arg<Number>()))))], Not(IsNull(Arg<Person>()))),
      MIRROR_BLOCKS_VOLUNTEER, true))

Map([1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    SetProperty(Filter([RandomChoice(Persons(And(
            TeamBLDEligible(),
            Not(BooleanProperty(FMC_VOLUNTEER)),
            Not(BooleanProperty(MULTI_VOLUNTEER)),
            (NumberProperty(STAFF_TEAM) == Arg<Number>()))))], Not(IsNull(Arg<Person>()))),
      TEAM_BLD_VOLUNTEER, true))

Header("FMC Volunteers")
Persons(BooleanProperty(FMC_VOLUNTEER))
Header("Multi Volunteers")
Persons(BooleanProperty(MULTI_VOLUNTEER))

Header("FTO Volunteers")
Persons(BooleanProperty(FTO_VOLUNTEER))
Header("Mirror Blocks Volunteers")
Persons(BooleanProperty(MIRROR_BLOCKS_VOLUNTEER))
Header("Team Blind Volunteer")
Persons(BooleanProperty(TEAM_BLD_VOLUNTEER))
