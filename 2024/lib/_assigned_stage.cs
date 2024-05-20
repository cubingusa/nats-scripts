#include "_constants.cs"

Define(
    "AssignedStage",
    If(HasProperty(STAFF_TEAM, {1, Person}),
       At(Stages(), Mod((NumberProperty(STAFF_TEAM, {1, Person}) + Day({2, Date})), 4)),
       "n/a")
    )
