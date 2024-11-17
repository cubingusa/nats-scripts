Table(
  Sort(Persons(And(Registered(), (PersonalBest(_333fm) < 80m))), PersonalBest(_333fm), PersonalBest(_333fm, "single")),
  [Column("Name", Name(), WcaLink()),
   Column("Average", PersonalBest(_333fm)),
   Column("Single", PersonalBest(_333fm, "single"))])
