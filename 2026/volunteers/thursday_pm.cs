#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

#define DATE 2026-07-02

Map(Stages(),
    All(DoVolunteerAssignments(
            _555-r2, Arg<String>(), DATE,
            [Judges(12), Scramblers(4, _555), Runners(4), Delegates(2)],
            VolunteerScorers(_555, DATE)),
        DoVolunteerAssignments(
            _clock-r2, Arg<String>(), DATE,
            [Judges(12), Scramblers(4, _clock), Runners(5), Delegates(2)],
            VolunteerScorers(_clock, DATE))))
