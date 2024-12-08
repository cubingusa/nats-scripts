Define(
  "PsychSheetTable",
  Table(
    {1, Array<Person>},
    ([Column("Name", Name(), WcaLink())] +
     Map(Events(),
         Column(EventId(), PsychSheetPosition()))
    )
  )
)
