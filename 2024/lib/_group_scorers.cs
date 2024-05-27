#include "_assigned_stage.cs"
#include "_constants.cs"

# Arg 1: date
Define("DefaultScorers",
       Concat([ByMatchingValue(StringProperty("first-name-cluster"), -5)],
              Map(Stages(),
                  ByFilters((AssignedStage(Arg<Person>(), {1, Date}) == Arg<String>()),
                            (Stage() == Arg<String>()), 10))))
