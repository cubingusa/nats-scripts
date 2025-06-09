#include "../lib/_constants.cs"

Define("WorkloadReport",
    Table(
      Sort({1, Array<Person>}, LengthOfJobs()),
      [
        Column("Name", Name()),
        Column("Team", NumberProperty(STAFF_TEAM)),
        Column("Staff Assignments", NumJobs()),
        Column("Registered Events", Length(RegisteredEvents())),
        Column("Hours Working", LengthOfJobs())
      ]))
