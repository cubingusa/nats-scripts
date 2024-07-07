#include "_constants.cs"

Define(
    "AssignedStageForTeam",
    At(Stages(), Mod(({1, Number} + Day({2, Date})), 4)))

Define(
    "AssignedStage",
    If(HasProperty(STAFF_TEAM, {1, Person}),
       AssignedStageForTeam(NumberProperty(STAFF_TEAM, {1, Person}), {2, Date}),
       If(BooleanProperty(COMMENTATOR), RED, "n/a"))
    )
