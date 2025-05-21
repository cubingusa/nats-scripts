#include "../../lib/_assigned_stage.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_eligible_scramblers.cs"

# Args:
# 1: Event
# 2: Number of top people
Define(
  "TopCompetitors",
  If((EventId({1, Event}) == "clock"),
     AssignmentSet("top",
                   (PsychSheetPosition({1, Event}) <= 8),
                   And(In(Stage(), FinalsStages()), (GroupNumber() > 4)),
                   featured=true),
     AssignmentSet("top",
                   (PsychSheetPosition({1, Event}) <= {2, Number}),
                   In(Stage(), FinalsStages()),
                   featured=true)))

# Args:
# 1: Number of Groups.
Define(
  "EarlyAssignmentSets",
  [AssignmentSet("commentators",
                 BooleanProperty(COMMENTATOR),
                 And((Stage() == MAIN_RED),
                     Or((GroupNumber() < {1, Number}),
                        (GroupNumber() <= 3)))),
   AssignmentSet("wca_booth",
                 BooleanProperty(WCA_BOOTH),
                 (Stage() == MAIN_GREEN)),
   AssignmentSet("main_hall_organizers",
                 BooleanProperty(MAIN_HALL_ORGANIZER),
                 (Stage() == MAIN_ORANGE)),
   AssignmentSet("ballroom_organizers",
                 BooleanProperty(BALLROOM_ORGANIZER),
                 (Stage() == SIDE_ORANGE))])

Define(
  "VolunteerAssignmentSetsImpl",
  Flatten(Map(
    {3, Array<Stage>},
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

Define(
    "FinalsStagesVolunteerAssignmentSets",
    VolunteerAssignmentSetsImpl({1, Event}, {2, Date}, FinalsStages()))

Define(
    "OtherVolunteerAssignmentSets",
    VolunteerAssignmentSetsImpl({1, Event}, {2, Date}, NonFinalsStages()))

Define(
  "FinalsStagesAssignmentSet",
  AssignmentSet("finals_stages",
                (PsychSheetPosition({1, Event}) <= {2, Number}),
                In(Stage(), FinalsStages())))

Define(
  "MainHallAssignmentSet",
  AssignmentSet("main_hall",
                And((PsychSheetPosition({1, Event}) > {2, Number}),
                    (PsychSheetPosition({1, Event}) <= {3, Number})),
                And(In(Stage(), MainStages()),
                    Not(In(Stage(), FinalsStages())))))

Define(
  "BallroomAssignmentSet",
  AssignmentSet("ballroom",
                (PsychSheetPosition({1, Event}) > {2, Number}),
                In(Stage(), SideStages())))

# Args:
# 1: Event
# 2: Date
# 3: Top competitors
# 4: Finals stage competitors
# 5: Main hall competitors
# 6: Main hall groups
Define("RoundOneAssignmentSetsImplImpl",
       Concat([TopCompetitors({1, Event}, {3, Number})],
              FinalsStagesVolunteerAssignmentSets({1, Event}, {2, Date}),
              [FinalsStagesAssignmentSet({1, Event}, {4, Number})],
              OtherVolunteerAssignmentSets({1, Event}, {2, Date}),
              EarlyAssignmentSets({6, Number}),
              [MainHallAssignmentSet({1, Event}, {4, Number}, {5, Number}),
               BallroomAssignmentSet({1, Event}, {5, Number})]))

# Args:
# 1: Event
# 2: Date
# 3: Main Hall Groups
# 4: Ballroom Groups
# 5: Number of Competitors
Define("RoundOneAssignmentSetsImpl",
       RoundOneAssignmentSetsImplImpl({1, Event}, {2, Date},
                                      ({3, Number} * 4),
                                      ((({3, Number} * 1.8) / (({3, Number} * 5.8) + ({4, Number} * 4))) * {5, Number}),
                                      ((({3, Number} * 5.8) / (({3, Number} * 5.8) + ({4, Number} * 4))) * {5, Number}),
                                      {3, Number}))

# Args:
# 1: Event
# 2: Date
# 3: Main Hall Groups
# 4: Ballroom Groups
Define("RoundOneAssignmentSets",
       RoundOneAssignmentSetsImpl({1, Event}, {2, Date}, {3, Number}, {4, Number},
                                  Length(Persons(CompetingIn({1, Event})))))
