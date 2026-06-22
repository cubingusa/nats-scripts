Table(
  Persons(Or((PsychSheetPosition(_333) <= 60),
             (PsychSheetPosition(_222) <= 30),
             (PsychSheetPosition(_444) <= 30),
             (PsychSheetPosition(_555) <= 30),
             (PsychSheetPosition(_666) <= 30),
             (PsychSheetPosition(_777) <= 30),
             (PsychSheetPosition(_333bf) <= 30),
             (PsychSheetPosition(_333oh) <= 30),
             (PsychSheetPosition(_333fm) <= 10),
             (PsychSheetPosition(_clock) <= 30),
             (PsychSheetPosition(_minx) <= 30),
             (PsychSheetPosition(_pyram) <= 30),
             (PsychSheetPosition(_skewb) <= 30),
             (PsychSheetPosition(_sq1) <= 30),
             (PsychSheetPosition(_444bf) <= 10),
             (PsychSheetPosition(_555bf) <= 10),
             (PsychSheetPosition(_333mbf) <= 10))),
  ([Column("Name", Name(), WcaLink()), Column("WCA ID", WcaId()), Column("Email", Email())] +
   Map(Events(),
       Column(EventId(), PsychSheetPosition()))
  )
)
