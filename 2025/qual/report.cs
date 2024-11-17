#include "_qualified.cs"
#include "_times.cs"

Define("ReportPhase",
    All(
      Header(("Phase " + ToString({1, Number}))),
      (ToString(Length(RegisteredPeopleOnlyInPhase({1, Number}))) + " people"),
      Map(Events(),
          (ToString(Length(Filter(RegisteredPeopleOnlyInPhase({1, Number}),
                                  QualifiedForEventInPhase(Arg<Person>(), Arg<Event>(), 4)))) + (" in " + EventId(Arg<Event>()))))))

ReportPhase(1)
""
ReportPhase(2)
""
ReportPhase(3)
""
ReportPhase(4)
