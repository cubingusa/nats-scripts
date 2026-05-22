#include "_volunteer_lib.cs"

ClearCompetitionGroupsAssignments(Persons(true))
CreateCompetitionGroupsAssignments([2017WOFF01], "Multi Blind Scrambling", 2025-11-01T09:30, 2025-11-01T11:45)
CreateCompetitionGroupsAssignments([2013BROW04], "Multi Blind Scrambling", 2025-11-01T10:00, 2025-11-01T11:45)
CreateCompetitionGroupsAssignments([2015MACK06], "Multi Blind Scrambling", 2025-11-01T11:00, 2025-11-01T11:45)
CreateCompetitionGroupsAssignments([2023KRAS01], "Check-In", 2025-11-01T08:00, 2025-11-01T10:00)

AssignStaff(_333mbf-r1,
            true,
            [2017WOFF01, 2019KUCA01, 2022KUCA01, 2011WELC01, 2015MACK06],
            [Job("Judge", 4)],
            [],
            unavailable=If((Name() == "Walker Welch"), [UnavailableForDate(2025-11-02)], []))

CreateCompetitionGroupsAssignments([2017WOFF01, 2005REYN01, 2015MACK06], "Multi Blind Scrambling", 2025-11-02T08:30, 2025-11-02T09:45)

AssignStaff(_333fm-r1, true, [2014GRIG01, 2014GARB01], [Job("Judge", 1)], [],
            unavailable=Switch(Name(), [Tuple("Stephen Griggs", [UnavailableForDate(2025-11-02)]),
                                        Tuple("Zachary Garber", [UnavailableForDate(2025-11-01)])]))

Map([_skewb-r1, _555bf-r1, _444-r1], DefaultAssignment(Arg<Round>()))

AssignStaff(_222-r1,
            (GroupNumber() < 3),
            Persons(IsVolunteer()),
            Jobs(_222),
            Scorers(_222),
            unavailable=Unavailable(Arg<Person>()))

AssignStaff(_666-r1,
            true,
            Persons(And(IsVolunteer(), Not(CompetingIn(_skewb)))),
            Jobs(_666),
            Scorers(_666),
            unavailable=Unavailable(Arg<Person>()))
AssignStaff(_skewb-r2,
            true,
            Persons(And(IsVolunteer(), Not(CompetingIn(_skewb)))),
            Jobs(_skewb),
            Scorers(_skewb),
            unavailable=Unavailable(Arg<Person>()))

Map([_minx-r1, _sq1-r1, _333-r1, _pyram-r1, _333oh-r1, _777-r1], DefaultAssignment(Arg<Round>()))
