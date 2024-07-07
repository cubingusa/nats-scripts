#include "../../lib/_constants.cs"
#include "../../lib/_long_room_staff.cs"

Define("CompetingTimes",
       Map(Filter(AssignedGroups({1, Person}), {2, Boolean(Group)}), StartTime()))

Define("MainStageCompetingTimes",
       Map(Filter(AssignedGroups({1, Person}),
                  And({2, Boolean(Group)},
                      Not(In(Round(), [_333fm-r1, _333mbf-r1, _555bf-r1])))),
           StartTime()))

Define("Unavailable",
       Concat(
         Switch(
           {1, Person},
           [
             Tuple(2015BURG02, [UnavailableBetween(2024-07-21T00:00, 2024-07-21T11:00)]),  # Brock Burgi
             Tuple(2015PADG01, [UnavailableBetween(2024-07-19T20:53, 2024-07-20T20:52)]),  # Dalton Padgett
             Tuple(2017HART11, [DuringTimes(MainStageCompetingTimes(2016HART02, IsFinal(Round())))]),  # Nancy Hartman
             Tuple(2023NIEU03, [DuringTimes(MainStageCompetingTimes(2018NIEU01, true))]),  # Wendy Nieuwland
             Tuple(2014GULA02, [UnavailableBetween(2024-07-18T00:00, 2024-07-18T12:00),  # For long room setup
                                UnavailableBetween(2024-07-19T00:00, 2024-07-19T12:00),  # For long room setup
                                UnavailableBetween(2024-07-20T10:30, 2024-07-20T10:30),  # For long room setup
                                UnavailableBetween(2024-07-19T13:00, 2024-07-19T15:00)]),  # Abdullah Gulab
             Tuple(2016MURP05, [UnavailableBetween(2024-07-21T00:00, 2024-07-21T09:30)]),  # Max Murphy
             Tuple(2016WILE01, [UnavailableBetween(2024-07-18T08:00, 2024-07-18T16:30)]),  # Kristin Knowles
             Tuple(2014GRIG01, [UnavailableBetween(2024-07-21T00:00, 2024-07-21T23:59)]),  # Stephen Griggs
             Tuple(p340272, [DuringTimes(MainStageCompetingTimes(2018MACK04, (RoundNumber(Round()) > 1)))]),  # Aaron Mack
             Tuple(2015GOVI01, [BeforeTimes(CompetingTimes(2015GOVI01, In(EventForRound(Round()), [_333oh])))]),  # Dylan Govic
             Tuple(2019PAHL02, [UnavailableBetween(2024-07-20T14:15, 2024-07-20T16:45)]),  # Michael Willow Pahl
             Tuple(2017RICH02, [DuringTimes(CompetingTimes(2017RICH02, In(Round(), [_555-r2])))]),  # Braden Richards
             Tuple(2022RAMI15, [BeforeTimes(CompetingTimes(2022RAMI15, In(EventForRound(Round()), [_clock])))]),  # Ledger Ramirez
             Tuple(2017COOL02, [UnavailableBetween(2024-07-20T16:45, 2024-07-20T23:59)]),  # Ethan Coolidge
             Tuple(2016DONO02, [UnavailableBetween(2024-07-21T15:00, 2024-07-21T23:59)]),  # Orion Donovan
             Tuple(2017MILL04, [UnavailableBetween(2024-07-18T10:00, 2024-07-18T12:00),
                                UnavailableBetween(2024-07-18T17:00, 2024-07-18T19:00)]),  # Zachary Miller
             Tuple(2022CHIC02, [BeforeTimes(CompetingTimes(2022CHIC02, In(EventForRound(Round()), [_clock])))]),  # Jack Chicoine
             Tuple(2019BEZZ01, [UnavailableBetween(2024-07-21T00:00, 2024-07-21T12:00)]),  # Nico Bezzerides
             Tuple(2020TONG02, [UnavailableBetween(2024-07-18T13:00, 2024-07-18T15:00),
                                UnavailableBetween(2024-07-19T13:00, 2024-07-19T15:00)]),  # Draco Tong
             Tuple(2022KOTO01, [UnavailableBetween(2024-07-18T00:00, 2024-07-18T14:30)]),  # Rex Kotovich
             Tuple(2015KUCA01, [UnavailableBetween(2024-07-18T09:30, 2024-07-18T10:15)]),  # Carter Kucala
             Tuple(2019KUCA01, [UnavailableBetween(2024-07-18T10:30, 2024-07-18T11:00)]),  # Lisa Kucala
             Tuple(2014GROV01, [UnavailableBetween(2024-07-18T16:15, 2024-07-18T17:00)]),  # Saransh Grover
             Tuple(2014GOSL01, [UnavailableBetween(2024-07-19T09:30, 2024-07-19T10:30)]),  # Raymond Goslow
             Tuple(2013DICK01, [UnavailableBetween(2024-07-19T11:00, 2024-07-19T11:45)]),  # Matthew Dickman
             Tuple(2015MACK06, [UnavailableBetween(2024-07-19T15:45, 2024-07-19T16:30)]),  # Zeke Mackay
             Tuple(2020LONG05, [UnavailableBetween(2024-07-20T10:00, 2024-07-20T11:30)]),  # Shain Longbehn
             Tuple(2018AMSB02, [UnavailableBetween(2024-07-20T11:00, 2024-07-20T12:00)]),  # Stone Amsbaugh
             Tuple(2013ESPA01, [UnavailableBetween(2024-07-20T16:00, 2024-07-20T16:30)])],  # Jonathan Esparaz
           defaultValue=[]),
         If(StaffingThursdayFMC(Arg<Person>()),
            [UnavailableBetween(2024-07-18T14:00, 2024-07-18T14:15),
             UnavailableBetween(2024-07-18T15:30, 2024-07-18T16:00)], []),
         If(StaffingFridayFMC(Arg<Person>()),
            [UnavailableBetween(2024-07-19T14:00, 2024-07-19T14:15),
             UnavailableBetween(2024-07-19T15:30, 2024-07-19T16:00)], []),
         If(StaffingSaturdayFMC(Arg<Person>()),
            [UnavailableBetween(2024-07-20T14:00, 2024-07-20T14:15),
             UnavailableBetween(2024-07-20T15:30, 2024-07-20T16:00)], []),
         If(StaffingThursdayMulti(Arg<Person>()),
            [UnavailableBetween(2024-07-18T09:30, 2024-07-18T12:15),
             UnavailableBetween(2024-07-18T13:30, 2024-07-18T14:00)], []),
         If(StaffingFridayMulti(Arg<Person>()),
            [UnavailableBetween(2024-07-19T09:30, 2024-07-19T12:15),
             UnavailableBetween(2024-07-19T13:30, 2024-07-19T14:00)], []),
         If(StaffingSaturday5BLD(Arg<Person>()),
            [UnavailableBetween(2024-07-20T11:00, 2024-07-20T12:15),
             UnavailableBetween(2024-07-20T13:30, 2024-07-20T14:00)], []),
         If(CompetingIn(_333mbf),
            [UnavailableBetween(2024-07-18T11:30, 2024-07-18T12:15),
             UnavailableBetween(2024-07-19T11:30, 2024-07-19T12:15)], []),
         If(CompetingIn(_555bf),
            [UnavailableBetween(2024-07-20T11:30, 2024-07-20T12:15)], [])))
