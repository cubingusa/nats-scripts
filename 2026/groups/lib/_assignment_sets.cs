#include "../../lib/_assigned_stage.cs"
#include "../../lib/_eligible_scramblers.cs"
#include "../../lib/_constants.cs"

Define("NonNAStream", StationExclusionRule(Not(IsNorthAmerican()), In(Arg<Number>(), [1, 2])))

# Args:
# 1: Event
# 2: Number of top people
# 3: Number of tier-2 people.
Define(
  "TopCompetitors",
  [AssignmentSet("top",
                 (PsychSheetPosition({1, Event}) <= {2, Number}),
                 In(Stage(), FinalsStages()),
                 featured=true),
   AssignmentSet("tier-2",
                 (PsychSheetPosition({1, Event}) <= {3, Number}),
                 In(Stage(), FinalsStages()))])

Define(
  "EarlyAssignmentSets",
  [AssignmentSet("data", HasRole(DATAENTRY), (Stage() == BLUE)),
   AssignmentSet("commentators", BooleanProperty(COMMENTATOR), (Stage() == RED)),
   AssignmentSet("unofficial-events", BooleanProperty(UNOFFICIAL_EVENTS), (Stage() == RED))])

# Args:
# 1: Event
# 2: Date
Define(
  "VolunteerAssignmentSets",
  Flatten(Map(
    Stages(),
    [AssignmentSet(("stage-leads-" + Arg<String>()),
                   And(BooleanProperty(STAGE_LEAD),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("scramblers-" + Arg<String>()),
                   And(CanScramble({1, Event}),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("volunteers-" + Arg<String>()),
                   (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>()),
                   (Stage() == Arg<String>()))])))

Define("EveryoneAssignmentSets",  [AssignmentSet("everyone", true, true)])

Define("RoundOneAssignmentSets",
       Concat(
         TopCompetitors({1, Event},
                        (4 * Length(Filter(Groups(RoundForEvent(1, {1, Event})),
                                           In(Stage(Arg<Group>()), FinalsStages())))),
                        Switch({1, Event}, [
                          Tuple(_333, 200),
                          Tuple(_222, 200),
                          Tuple(_444, 200),
                          Tuple(_pyram, 200),
                          Tuple(_333oh, 200),
                          Tuple(_skewb, 200),
                          Tuple(_555, 60),
                          Tuple(_clock, 60),
                          Tuple(_sq1, 40),
                          Tuple(_333bf, 40),
                          Tuple(_666, 40),
                          Tuple(_777, 40),
                          Tuple(_minx, 40),
                          Tuple(_444bf, 22)
                        ])),
         EarlyAssignmentSets(),
         VolunteerAssignmentSets({1, Event}, {2, Date}),
         EveryoneAssignmentSets()))

Define("RoundTwoAssignmentSets",
       [AssignmentSet("Top",
                      (RoundPosition(PreviousRound({1, Round})) <= 4),
                      And(In(Stage(), FinalsStages()), (GroupNumber() == 5)),
                      featured=true),
        AssignmentSet("Five", (RoundPosition(PreviousRound({1, Round})) <= 80), (GroupNumber() == 5)),
        AssignmentSet("Four", (RoundPosition(PreviousRound({1, Round})) <= 160), (GroupNumber() == 4)),
        AssignmentSet("Three", (RoundPosition(PreviousRound({1, Round})) <= 240), (GroupNumber() == 3)),
        AssignmentSet("Two", (RoundPosition(PreviousRound({1, Round})) <= 320), (GroupNumber() == 2)),
        AssignmentSet("One", (RoundPosition(PreviousRound({1, Round})) <= 400), (GroupNumber() == 1))])

Define("SemifinalAssignmentSets",
       [AssignmentSet("Top",
                      (RoundPosition(PreviousRound({1, Round})) <= 6),
                      In(Stage(), FinalsStages()),
                      featured=true),
        AssignmentSet("NextTop",
                      (RoundPosition(PreviousRound({1, Round})) <= 20),
                      In(Stage(), FinalsStages())),
        AssignmentSet("Everyone", true, true)])

Define("FinalsAssignmentSets",
       [AssignmentSet("Evens", Even(RoundPosition(PreviousRound({1, Round}))), (Stage() == RED)),
        AssignmentSet("Odds", Not(Even(RoundPosition(PreviousRound({1, Round})))), (Stage() == BLUE))])
