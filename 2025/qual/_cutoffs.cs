#include "_qualified.cs"
#include "_times.cs"

Define("CutoffCounts",
       If(In({1, Event}, [_666, _777]), [1], [1, 2]))

Define("MadeCutoff",
       (Min(Map(CutoffCounts({2, Event}), Result({1, Person}, RoundForEvent(1, {2, Event}), Arg<Number>()))) <
        {3, AttemptResult}))

Define("CountInPhaseMakingCutoff",
       ((ToString(Length(Filter(RegisteredPeopleOnlyInPhase({1, Number}),
                                And(MadeCutoff(Arg<Person>(), {2, Event}, {3, AttemptResult}),
                                    QualifiedForEventInPhase(Arg<Person>(), {2, Event}, 4))))) + "/") +
         ToString(Length(Filter(RegisteredPeopleOnlyInPhase({1, Number}),
                                QualifiedForEventInPhase(Arg<Person>(), {2, Event}, 4))))))

Define("CutoffReport",
       Map([1, 2, 3, 4],
         All(
           ("Phase " + ToString(Arg<Number>())),
           CountInPhaseMakingCutoff(Arg<Number>(), {1, Event}, {2, AttemptResult}))))
