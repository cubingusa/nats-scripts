#include "../lib/_constants.cs"

Define("CompetingTimes",
       Map(Filter(AssignedGroups({1, Person}), {2, Boolean(Group)}), StartTime()))

Define("MainStageCompetingTimes",
       Map(Filter(AssignedGroups({1, Person}), 
                  And({2, Boolean(Group)},
                      Not(In(Round(), [_333fm-r1, _333mbf-r1, _555bf-r1])))),
           StartTime()))

# Nick Silvestri
SetStaffUnavailable([2016SILV08], [UnavailableBetween(2024-07-21T15:30, 2024-07-21T23:59)])

# Brock Burgi
SetStaffUnavailable([2015BURG02], [UnavailableBetween(2024-07-21T00:00, 2024-07-21T11:00)])
SetProperty([2015BURG02], UNAVAILABLE, 1)

# Dalton Padgett
SetStaffUnavailable([2015PADG01], [UnavailableBetween(2024-07-19T20:53, 2024-07-20T20:52)])
SetProperty([2015PADG01], UNAVAILABLE, 2)

# Nancy Hartman
SetStaffUnavailable([2017HART11], [DuringTimes(MainStageCompetingTimes(2016HART02, IsFinal(Round())))])

# Wendy Nieuwland
SetStaffUnavailable([2023NIEU03], [DuringTimes(MainStageCompetingTimes(2018NIEU01, true))])

# Abdullah Gulab
SetStaffUnavailable([2014GULA02], [UnavailableBetween(2024-07-19T13:00, 2024-07-19T15:00)])

# Max Murphy
SetStaffUnavailable([2016MURP05], [UnavailableBetween(2024-07-21T00:00, 2024-07-21T09:30)])

# Kristin Knowles
SetStaffUnavailable([2016WILE01], [UnavailableBetween(2024-07-18T08:00, 2024-07-18T16:30)])
SetProperty([2016WILE02], UNAVAILABLE, 2)

# Stephen Griggs
SetStaffUnavailable([2014GRIG01], [UnavailableBetween(2024-07-21T00:00, 2024-07-21T23:59)])
SetProperty([2014GRIG01], UNAVAILABLE, 2)

# Aaron Mack
SetStaffUnavailable([p340272], [DuringTimes(MainStageCompetingTimes(2018MACK04, (RoundNumber(Round()) > 1)))])

# Dylan Govic
SetStaffUnavailable([2015GOVI01], [BeforeTimes(CompetingTimes(2015GOVI01, In(EventForRound(Round()), [_333oh])))])

# Michael Willow Pahl
SetStaffUnavailable([2019PAHL02], [UnavailableBetween(2024-07-20T14:15, 2024-07-20T16:45)])
SetProperty([2019PAHL02], UNAVAILABLE, 1)

# Braden Richards
SetStaffUnavailable([2017RICH02], [DuringTimes(CompetingTimes(2017RICH02, In(Round(), [_555-r2])))])

# Ledger Ramirez
SetStaffUnavailable([2022RAMI15], [BeforeTimes(CompetingTimes(2022RAMI15, In(EventForRound(Round()), [_clock])))])

# Ethan Coolidge
SetStaffUnavailable([2017COOL02], [UnavailableBetween(2024-07-20T16:45, 2024-07-20T23:59)])
SetProperty([2017COOL02], UNAVAILABLE, 1)

# Orion Donovan
SetStaffUnavailable([2016DONO02], [UnavailableBetween(2024-07-21T15:00, 2024-07-21T23:59)])

# Zachary Miller
SetStaffUnavailable([2017MILL04], [UnavailableBetween(2024-07-18T10:00, 2024-07-18T12:00),
                                 UnavailableBetween(2024-07-18T17:00, 2024-07-18T19:00)])
SetProperty([2017MILL04], UNAVAILABLE, 1)

# Jack Chicoine
SetStaffUnavailable([2022CHIC02], [BeforeTimes(CompetingTimes(2022CHIC02, In(EventForRound(Round()), [_clock])))])

# Nico Bezzerides
SetStaffUnavailable([2019BEZZ01], [UnavailableBetween(2024-07-21T00:00, 2024-07-21T12:00)])
SetProperty([2019BEZZ01], UNAVAILABLE, 1)

# Draco Tong
SetStaffUnavailable([2020TONG02], [UnavailableBetween(2024-07-18T13:00, 2024-07-18T15:00),
                                 UnavailableBetween(2024-07-19T13:00, 2024-07-19T15:00)])
SetProperty([2020TONG02], UNAVAILABLE, 1)
