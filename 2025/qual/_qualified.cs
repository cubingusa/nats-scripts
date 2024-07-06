#include "_times.cs"

Define("QualifiedForPhase",
       In(true, Map(Phase({2, Number}),
                    (PersonalBest(First(Arg<Tuple<Event, AttemptResult>>()), {1, Person}) <
                     Second(Arg<Tuple<Event, AttemptResult>>())))))

Define("QualifiedForEventInPhase",
       (PersonalBest({2, Event}, {1, Person}) < QualTimeInPhase({2, Event}, {3, Number})))
