#include "../lib/_constants.cs"

Table(
  Sort(Persons(BooleanProperty(CORE_STAFF)), NumberProperty(STAFF_TEAM)),
  [
    Column("Name", Name()),
    Column("Team", NumberProperty(STAFF_TEAM)),
    Column("judge", NumJobs("judge")),
    Column("scrambler", NumJobs("scrambler")),
    Column("runner", NumJobs("runner")),
    Column("Delegate", NumJobs("Delegate")),
    Column("total", NumJobs()),
    Column("pref-judge", NumberProperty("percent-judge")),
    Column("pref-scrambler", NumberProperty("percent-scrambler")),
    Column("pref-runner", NumberProperty("percent-runner")),
    Column("pref-Delegate", NumberProperty("percent-Delegate"))])

