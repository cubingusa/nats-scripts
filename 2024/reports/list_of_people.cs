#include "../lib/_constants.cs"

# List of people for printing name badges.
Table(
  Sort(Persons(Or(Registered(), BooleanProperty(CORE_STAFF))), LastName()),
  [
    Column("Name", Name()),
    Column("WCA ID", WcaId()),
    Column("Country", Country()),
    Column("Groups Link", CompetitionGroups()),
    Column("Is Staff", Or(BooleanProperty(CORE_STAFF),
                          BooleanProperty(DATAENTRY),
                          BooleanProperty(COMMENTATOR),
                          HasRole("organizer"),
                          HasRole("delegate"))),
    Column("Is Organizer", HasRole("organizer")),
    Column("Is Delegate", HasRole("delegate"))])
