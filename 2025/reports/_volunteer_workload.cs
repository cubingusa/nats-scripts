#include "../lib/_constants.cs"

Define("WorkloadReport",
    Table(
      {1, Array<Person>},
      [
        Column("Name", Name()),
        Column("Team", NumberProperty(STAFF_TEAM)),
        Column("Staff Assignments", NumJobs()),
        Column("Registered Events", Length(RegisteredEvents())),
        Column("Hours Working", LengthOfJobs())
      ]))
