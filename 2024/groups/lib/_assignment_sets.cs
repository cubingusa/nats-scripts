#include "../../lib/_assigned_stage.cs"
#include "../../lib/_eligible_scramblers.cs"
#include "../../lib/_constants.cs"

# Args:
# 1: Event
# 2: Number of top people
Define(
  "TopCompetitors",
  [AssignmentSet("top",
                 (PsychSheetPosition({1, Event}) <= {2, Number}),
                 In(Stage(), FinalsStages()),
                 featured=true)])

Define(
  "EarlyAssignmentSets",
  [AssignmentSet("data", HasRole(DATAENTRY), (Stage() == BLUE)),
   AssignmentSet("commentators", BooleanProperty(COMMENTATOR), (Stage() == RED)),
   AssignmentSet("wca-booth", BooleanProperty(WCA_BOOTH), (Stage() == RED))])

# Args:
# 1: Event
# 2: Date
Define(
  "StaffAssignmentSets",
  Flatten(Map(
    Stages(),
    [AssignmentSet(("stage-leads-" + Arg<String>()),
                   And(HasRole("delegate"),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("scramblers-" + Arg<String>()),
                   And(CanScramble({1, Event}),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("staff-" + Arg<String>()),
                   (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>()),
                   (Stage() == Arg<String>()))])))

Define("EveryoneAssignmentSets",  [AssignmentSet("everyone", true, true)])

Define("RoundOneAssignmentSets",
       Concat(
         TopCompetitors({1, Event},
                        (2 * Length(Filter(Groups(RoundForEvent(1, {1, Event})),
                                           In(Stage(Arg<Group>()), FinalsStages()))))),
         EarlyAssignmentSets(),
         StaffAssignmentSets({1, Event}, {2, Date}),
         EveryoneAssignmentSets()))
