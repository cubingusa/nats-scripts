#include "lib/_assigned_stage.cs"
#include "lib/_constants.cs"

Table(
  Sort(Persons(BooleanProperty(STAGE_LEAD)), NumberProperty(STAFF_TEAM)),
  Concat([Column("Name", Name())],
         Map([2024-07-18, 2024-07-19, 2024-07-20, 2024-07-21],
             Column(Weekday(Arg<Date>()), AssignedStage(Arg<Person>(), Arg<Date>())))))
