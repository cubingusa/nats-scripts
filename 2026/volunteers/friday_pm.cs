#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

#define DATE 2026-07-02

Map(FinalsStages(),
    All(FinalsAssignments(
            _555-r3, Arg<String>(),
            [Judges(10), Scramblers(4, _555), Runners(5), FinalsDelegates(2)],
            VolunteerScorers(_555, DATE)),
        FinalsAssignments(
            _clock-r3, Arg<String>(),
            [Judges(10), Scramblers(4, _clock), Runners(5), FinalsDelegates(2)],
            VolunteerScorers(_clock, DATE)),
        FinalsAssignments(
            _pyram-r3, Arg<String>(),
            [Judges(10), Scramblers(4, _pyram), Runners(5), FinalsDelegates(2)],
            VolunteerScorers(_clock, DATE)),
        FinalsAssignments(
            _333oh-r3, Arg<String>(),
            [Judges(10), Scramblers(4, _333oh), Runners(5), FinalsDelegates(2)],
            VolunteerScorers(_clock, DATE))))
