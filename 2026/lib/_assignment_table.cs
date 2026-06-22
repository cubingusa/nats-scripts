Define("PrintGroup",
       ((Stage(AssignedGroup({1, Round})) + " ") + ToString(GroupNumber(AssignedGroup({1, Round})))))

Define("AssignmentTable",
       Table({1, Array<Person>},
             Concat([Column("Name", Name())],
                    {3, Array<Column>},
                    Map({2, Array<Round>},
                        Column(ToString(Arg<Round>()),
                               If(CompetingInRound(Arg<Round>()),
                                  PrintGroup(Arg<Round>()),
                                  ""))))))
