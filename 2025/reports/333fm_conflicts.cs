Header("Thursday")
"OH groups"
Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_333oh))), EndTime(AssignedGroup(_333oh-r1))),
     [Column("Name", Name()),
      Column("OH Group", ((Stage(AssignedGroup(_333oh-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_333oh-r1))))),
      Column("OH EndTime", EndTime(AssignedGroup(_333oh-r1)))])

"Pyra groups"
Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_pyram))), StartTime(AssignedGroup(_pyram-r1))),
     [Column("Name", Name()),
      Column("Pyra Group", ((Stage(AssignedGroup(_pyram-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_pyram-r1))))),
      Column("Pyra StartTime", EndTime(AssignedGroup(_pyram-r1)))])

Header("Friday")
Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_444))), EndTime(AssignedGroup(_444-r1))),
     [Column("Name", Name()),
      Column("Email", Email()),
      Column("4x4 Group", ((Stage(AssignedGroup(_444-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_444-r1))))),
      Column("4x4 EndTime", EndTime(AssignedGroup(_444-r1)))])

Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_minx))), EndTime(AssignedGroup(_minx-r1))),
     [Column("Name", Name()),
      Column("Mega Group", ((Stage(AssignedGroup(_minx-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_minx-r1))))),
      Column("Mega EndTime", EndTime(AssignedGroup(_minx-r1)))])

Header("Saturday")
Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_333))), EndTime(AssignedGroup(_333-r1))),
     [Column("Name", Name()),
      Column("3x3 Group", ((Stage(AssignedGroup(_333-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_333-r1))))),
      Column("3x3 EndTime", EndTime(AssignedGroup(_333-r1)))])

Table(
     Sort(Persons(And(CompetingIn(_333fm), CompetingIn(_666))), EndTime(AssignedGroup(_666-r1))),
     [Column("Name", Name()),
      Column("6x6 Group", ((Stage(AssignedGroup(_666-r1)) + " ") + ToString(GroupNumber(AssignedGroup(_666-r1))))),
      Column("6x6 EndTime", EndTime(AssignedGroup(_666-r1)))])
