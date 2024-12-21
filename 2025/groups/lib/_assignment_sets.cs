#include "../../lib/_constants.cs"

# Args:
# 1: Event
# 2: Number of top people
Define(
  "TopCompetitors",
  AssignmentSet("top",
                (PsychSheetPosition({1, Event}) <= {2, Number}),
                In(Stage(), FinalsStages()),
                featured=true))

# TODO: Early assignment sets: data, commentators, WCA booth, others

# TODO: Staff

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
Define("RoundOneAssignmentSetsImplImpl",
       [TopCompetitors({1, Event}, {3, Number}),
        FinalsStagesAssignmentSet({1, Event}, {4, Number}),
        MainHallAssignmentSet({1, Event}, {4, Number}, {5, Number}),
        BallroomAssignmentSet({1, Event}, {5, Number})])

# Args:
# 1: Event
# 2: Date
# 3: Main Hall Groups
# 4: Ballroom Groups
# 5: Number of Competitors
Define("RoundOneAssignmentSetsImpl",
       RoundOneAssignmentSetsImplImpl({1, Event}, {2, Date},
                                      ({3, Number} * 4),
                                      ((({3, Number} * 2) / (({3, Number} * 6) + ({4, Number} * 4))) * {5, Number}),
                                      ((({3, Number} * 6) / (({3, Number} * 6) + ({4, Number} * 4))) * {5, Number})))

# Args:
# 1: Event
# 2: Date
# 3: Main Hall Groups
# 4: Ballroom Groups
Define("RoundOneAssignmentSets",
       RoundOneAssignmentSetsImpl({1, Event}, {2, Date}, {3, Number}, {4, Number},
                                  Length(Persons(CompetingIn({1, Event})))))
