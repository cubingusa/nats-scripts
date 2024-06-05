#include "../lib/_constants.cs"

Table(
    Persons(BooleanProperty(CORE_STAFF)),
    [
      Column("Name", Name()),
      Column("Team", NumberProperty(STAFF_TEAM)),
      Column("Long Room Team", NumberProperty(LONG_ROOM_TEAM)),
      Column("Staff Assignments", NumJobs()),
      Column("Registered Events", Length(RegisteredEvents())),
      Column("Hours Working", LengthOfJobs())
    ])
