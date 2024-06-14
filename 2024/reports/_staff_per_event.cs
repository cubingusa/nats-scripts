#include "lib/_constants.cs"
Table(
  Sort(Events(), (Length(Persons(And(CompetingIn(), IsStaff()))) / Length(Persons(CompetingIn())))),
  [
    Column("Event", EventId()),
    Column("People", Length(Persons(CompetingIn()))),
    Column("Staff", Length(Persons(And(CompetingIn(), IsStaff())))),
    Column("Pct", (Length(Persons(And(CompetingIn(), IsStaff()))) / Length(Persons(CompetingIn()))))
])
