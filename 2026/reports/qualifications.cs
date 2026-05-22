Define("QualStats",
       (EventId({1, Event}) +
        (": " +
         (ToString(Length(Persons(And(Registered(), CompetingIn({1, Event}))))) +
         (" / " + ToString(Length(Persons(And(Registered(), (PersonalBest({1, Event}) < {2, AttemptResult}))))))))))

QualStats(_555, 1:08s)
QualStats(_666, 2:00s)
QualStats(_777, 3:10s)
QualStats(_333bf, 1:10s)
QualStats(_clock, 6s)
QualStats(_minx, 53s)
QualStats(_sq1, 11.5s)
QualStats(_444bf, 4:00s)
QualStats(_555bf, 7:00s)

""
"Proposed"
QualStats(_555, 1:12s)
QualStats(_666, 2:05s)
QualStats(_777, 3:15s)
QualStats(_333bf, 1:20s)
QualStats(_clock, 7s)
QualStats(_minx, 55s)
QualStats(_sq1, 12.5s)
QualStats(_444bf, 5:00s)
QualStats(_555bf, 10:00s)

""
"Open Events"
QualStats(_333, 9:59s)
QualStats(_222, 9:59s)
QualStats(_444, 9:59s)
QualStats(_333oh, 9:59s)
QualStats(_pyram, 9:59s)
QualStats(_skewb, 9:59s)
