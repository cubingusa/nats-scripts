#include "../../lib/_constants.cs"
#include "../../lib/_advancement.cs"

Define("CompetingTimes",
       Map(Filter(AssignedGroups({1, Person}),
                  And({2, Boolean(Group)},
                      Not(In(Event(), [_333fm, _333mbf])))), StartTime()))

Define("Unavailable",
       Concat(
         Switch(
           {1, Person},
           [
             Tuple(2017PRES02, [UnavailableBetween(2025-07-04T16:00, 2025-07-04T23:59)]),  # Peter Preston
             Tuple(2010BENT01, [UnavailableBetween(2025-07-03T14:45, 2025-07-03T15:15),
                                UnavailableBetween(2025-07-04T14:45, 2025-07-04T15:15),
                                UnavailableBetween(2025-07-05T14:45, 2025-07-05T15:15)]),  # Jan Bentlage
             Tuple(2018NEVE02, [UnavailableBetween(2025-07-03T14:45, 2025-07-03T15:15),
                                UnavailableBetween(2025-07-04T14:45, 2025-07-04T15:15),
                                UnavailableBetween(2025-07-05T14:45, 2025-07-05T15:15)]),  # Adrian Neveu
             Tuple(2014GULA02, [UnavailableBetween(2025-07-04T12:00, 2025-07-04T15:00)]),  # Abdullah Gulab
             Tuple(2015PADG01, [UnavailableBetween(2025-07-05T00:00, 2025-07-05T23:59)]),  # Dalton Padgett
             Tuple(2023NIEU03, [DuringTimes(CompetingTimes(2018NIEU01, true))]),  # Wendy Nieuwland
             Tuple(2015SETT01, [UnavailableBetween(2025-07-05T15:00, 2025-07-05T23:59)]),  # Fabian Settelen
             Tuple(2016MURP05, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T09:30)]),  # Max Murphy
             Tuple(p130670, [DuringTimes(CompetingTimes(2016HOBB01, (EventForRound(Round()) == _pyram)))]),  # Jeff Hobbs
             Tuple(2015SRIN02, [UnavailableBetween(2025-07-03T12:30, 2025-07-03T13:00),
                                UnavailableBetween(2025-07-05T12:30, 2025-07-05T13:00)]),  # Swami Srinivasan
             Tuple(2015BURG02, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T12:00)]),  # Brock Burgi
             Tuple(2023KRAS01, [DuringTimes(CompetingTimes(2022KRAS02, true))]),  # David Krasne
             Tuple(2020EYOU01, [DuringTimes(CompetingTimes(2019EYOU01, In(EventForRound(Round()), [_pyram, _666]))),
                                DuringTimes(CompetingTimes(2018EYOU02, In(EventForRound(Round()), [_pyram, _666])))]),  # Wee-Yeong Eyou
             Tuple(p484684, [DuringTimes(CompetingTimes(2019EYOU01, In(EventForRound(Round()), [_pyram, _666]))),
                             DuringTimes(CompetingTimes(2018EYOU02, In(EventForRound(Round()), [_pyram, _666])))]),  # Reeta Eyou
             Tuple(2022KUCA01, [DuringTimes(CompetingTimes(2015KUCA01, (EventForRound(Round()) == _skewb)))]),  # Joe Kucala
             Tuple(2021VOAI01, [UnavailableBetween(2025-07-05T17:30, 2025-07-05T23:59)]),  # Aileen Vo
             Tuple(2018GREN02, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T11:00)]),  # William Greninger
             Tuple(2023GROS05, [UnavailableBetween(2025-07-05T00:00, 2025-07-06T23:59)]),  # Zalman Grossbaum
             Tuple(2022DAYJ01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T12:00)]),  # Joey Day
             Tuple(2017OSUD01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T23:59)]),  # Peter Osudar
             Tuple(2019BEZZ01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T12:00)]),  # Nico Bezzerides
             Tuple(2008WARL01, [UnavailableBetween(2025-07-05T16:30, 2025-07-05T23:59)]),  # Jackson Warley
             Tuple(2017PLEI01, [UnavailableBetween(2025-07-04T11:30, 2025-07-05T12:45)]),  # Coleton Pleiss
             Tuple(2019BURG06, [UnavailableBetween(2025-07-05T00:00, 2025-07-05T10:00),
                                DuringTimes(CompetingTimes(2018BURG03, (EventForRound(Round()) == _pyram)))]),  # Brendan Burgess
             Tuple(2022GRAI02, [DuringTimes(CompetingTimes(2018GRAI01, In(EventForRound(Round()), [_clock, _minx])))]),  # Kirsty Grainger
             Tuple(2018GONZ09, [DuringTimes(CompetingTimes(2018PERE37, true))]),  # Lorenzo Gonzalez
             Tuple(2020TONG02, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T12:45)]),  # Draco Tong
             Tuple(2013FRAI01, [UnavailableBetween(2025-07-05T11:45, 2025-07-05T12:25)]),  # Diego Fraile
             Tuple(2006KRUE01, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T12:00)]),  # Chris Krueger
             Tuple(2007SEID01, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T11:00)]),  # Alex Seidler
             Tuple(2018LAWS02, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T14:00)]),  # Benson Lawson
             Tuple(2022CHOW14, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T14:00)]),  # Winston Chow
             Tuple(2009GUIL01, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T13:00)]),  # Kevin Guillamound
             Tuple(2018TRAN09, [UnavailableForDate(2025-07-03)]),  # Tien Tran
             Tuple(2014STEL02, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T11:00)]),  # Noah Stelting
             Tuple(2023HINC04, [UnavailableBetween(2025-07-03T00:00, 2025-07-05T12:00)]),  # Chan Ho Hin
             Tuple(2022CHES04, [DuringTimes(CompetingTimes(2022CHES03, true))]),  # Tommy Chestnutt
             Tuple(2017HART11, [DuringTimes(CompetingTimes(2016HART02, IsFinal(Round())))]),  # Nancy Hartman
             Tuple(2011HAYS01, [DuringTimes(CompetingTimes(2009HAYS01, true))]),  # Paul Hays
             Tuple(2011HAYS02, [DuringTimes(CompetingTimes(2009HAYS01, true))]),  # Donna Hays
             Tuple(p308553, [DuringTimes(CompetingTimes(2018KUCZ01, true))]),  # Dawn Kuczaj
             Tuple(2017MARQ06, [DuringTimes(CompetingTimes(2014MARQ02, true))]),  # Lais Helena Rega Serra Marques
             Tuple(2012BUBE01, [DuringTimes(CompetingTimes(2024ARRA01, true))]),  # Alina Arranhado
             Tuple(2023RUSH01, [DuringTimes(CompetingTimes(2018RUSH01, (RoundNumber(Round()) > 1)))]),  # Catherine Rush
             Tuple(2022RUSH01, [DuringTimes(CompetingTimes(2023RUSH01, true)),
                                DuringTimes(CompetingTimes(2018RUSH01, true))]),  # Anthony Kalaya Rush
             Tuple(2019BLAC02, [DuringTimes(CompetingTimes(2017BLAC06, (EventForRound(Round()) == _skewb)))]),  # Sonja Black
             Tuple(2019BUCH04, [DuringTimes(CompetingTimes(2015SPEN01, true))]),  # Rachel Spendla
             Tuple(2005STIL01, [DuringTimes(CompetingTimes(2003LEEJ01, true))]),  # Peter Still
             Tuple(2023MONE01, [DuringTimes(CompetingTimes(2023MONE03, true)),
                                DuringTimes(CompetingTimes(2023MONE02, true))]),  # Dean Money
             Tuple(2024CHEW09, [DuringTimes(CompetingTimes(2024CHEW02, true))]),  # Joanne Chew
             Tuple(2019BURG06, [DuringTimes(CompetingTimes(2018BURG03, true))]),  # Brendan Burgess
             Tuple(p464503, [DuringTimes(CompetingTimes(2021RAPO01, true))]),  # Mat Rapoza
             Tuple(2013BURL01, [UnavailableBetween(2025-07-03T00:00, 2025-07-06T23:59)]), # Łukasz Burliga
             Tuple(2012HAID01, [UnavailableBetween(2025-07-03T00:00, 2025-07-06T23:59)]), # Ammar Haider
             Tuple(2018HORD01, [UnavailableBetween(2025-07-03T00:00, 2025-07-06T23:59)]), # Vlad Hordiienko
             Tuple(2020ISAI01, [UnavailableBetween(2025-07-03T00:00, 2025-07-06T23:59)]), # Panayiotis Isaia
             Tuple(2012PONC02, [UnavailableBetween(2025-07-03T12:25, 2025-07-03T12:45)]), # Patrick Ponce
             Tuple(2011MASS01, [UnavailableBetween(2025-07-05T17:50, 2025-07-05T18:35),
                                UnavailableBetween(2025-07-03T14:45, 2025-07-03T15:15)]), # Nikolai Masson
             Tuple(2018HOUB01, [UnavailableBetween(2025-07-04T13:45, 2025-07-04T14:15),
                                UnavailableBetween(2025-07-05T09:40, 2025-07-05T10:10),
                                UnavailableBetween(2025-07-05T15:15, 2025-07-05T23:59),
                                UnavailableForDate(2025-07-06)]), # Bailing Hou
             Tuple(2019TAMU01, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T16:30),
                                UnavailableBetween(2025-07-04T15:15, 2025-07-04T16:30),
                                UnavailableBetween(2025-07-05T15:15, 2025-07-05T16:30)]), # Takumi Tamura
             Tuple(2019SULE01, [UnavailableBetween(2025-07-05T16:00, 2025-07-05T23:59)]), # Daniyal Suleimen
             Tuple(2012CANT02, [UnavailableBetween(2025-07-03T10:00, 2025-07-03T11:00)]), # Simone Cantarelli
             Tuple(2013DIPI01, [UnavailableBetween(2025-07-03T11:45, 2025-07-03T12:45)]), # Guido DiPietro
             Tuple(2015MACK06, [UnavailableBetween(2025-07-03T14:15, 2025-07-03T15:00)]), # Zeke Mackay
             Tuple(2018DAIN02, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T15:45),
                                UnavailableBetween(2025-07-05T09:45, 2025-07-05T11:15)]), # Peri Le Dain
             Tuple(2019KUCA01, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T15:45),
                                DuringTimes(CompetingTimes(2015KUCA01, true))]), # Lisa Kucala
             Tuple(2015KUCA01, [UnavailableBetween(2025-07-04T09:30, 2025-07-04T10:30),
                                UnavailableBetween(2025-07-05T10:50, 2025-07-05T11:20)]), # Carter Kucala
             Tuple(2014GOSL01, [UnavailableBetween(2025-07-04T10:30, 2025-07-04T12:00)]), # Raymond Goslow
             Tuple(2015SPEN01, [UnavailableBetween(2025-07-04T14:15, 2025-07-04T15:15)]), # Sam Spendla
             Tuple(2022HEXT01, [UnavailableBetween(2025-07-04T14:15, 2025-07-04T15:15)]), # Oliver Hexter
             Tuple(2013DICK01, [UnavailableBetween(2025-07-04T15:15, 2025-07-04T16:15)]), # Matthew Dickman
             Tuple(2020LONG05, [UnavailableBetween(2025-07-05T09:30, 2025-07-05T11:00)]), # Shain Longbehn
             Tuple(2016BEAU03, [UnavailableBetween(2025-07-05T10:30, 2025-07-05T11:00)]), # Maria Beausang
             Tuple(2016LOPE37, [UnavailableBetween(2025-07-05T14:30, 2025-07-05T15:15)]), # Ruben Lopez de Juan
             Tuple(2019JOHN03, [UnavailableBetween(2025-07-05T16:15, 2025-07-05T17:15)]), # Roxana Johnson
             Tuple(2015SOAR01, [UnavailableBetween(2025-07-04T16:20, 2025-07-04T16:55)]), # Nikhil Soares
             # Unofficial events
             Tuple(2017BRYA06, [UnavailableBetween(2025-07-03T09:00, 2025-07-03T10:15),
                                UnavailableBetween(2025-07-04T12:00, 2025-07-04T14:45)]), # Aedan Bryant
             Tuple(2020OREN01, [UnavailableBetween(2025-07-03T09:00, 2025-07-03T11:15)]), # Kinkajou Oren
             Tuple(2022KHAN05, [UnavailableBetween(2025-07-03T09:45, 2025-07-03T12:15)]), # Nupur Khandelwal
             Tuple(2022STON03, [UnavailableBetween(2025-07-03T10:45, 2025-07-03T13:15)]), # Tuval Stone
             Tuple(2014MELL03, [UnavailableBetween(2025-07-03T11:45, 2025-07-03T13:15),
                                UnavailableBetween(2025-07-03T16:45, 2025-07-03T18:00),
                                UnavailableBetween(2025-07-04T11:45, 2025-07-04T13:15)]), # Gabriel Sageiro Gomes de Mello
             Tuple(2022LEAV01, [UnavailableBetween(2025-07-03T12:00, 2025-07-03T14:15),
                                UnavailableBetween(2025-07-04T10:45, 2025-07-04T13:15),
                                UnavailableBetween(2025-07-05T12:00, 2025-07-05T14:15)]), # Orion Leavitt-Lytle
             Tuple(2020TONG02, [UnavailableBetween(2025-07-03T12:00, 2025-07-03T15:15)]), # Draco Tong
             Tuple(2023VINC03, [UnavailableBetween(2025-07-03T13:45, 2025-07-03T16:15)]), # Addison Vincelli
             Tuple(2003HARD01, [UnavailableBetween(2025-07-03T14:45, 2025-07-03T17:15),
                                UnavailableBetween(2025-07-04T09:00, 2025-07-04T10:15),
                                UnavailableBetween(2025-07-04T16:45, 2025-07-04T18:15)]), # Chris Hardwick
             Tuple(2015MACD03, [UnavailableBetween(2025-07-03T15:45, 2025-07-03T18:15),
                                UnavailableBetween(2025-07-04T09:00, 2025-07-04T11:15),
                                UnavailableBetween(2025-07-05T16:45, 2025-07-05T18:15)]), # James Macdiarmid
             Tuple(2019BLAC02, [UnavailableBetween(2025-07-04T09:45, 2025-07-04T12:15),
                                UnavailableBetween(2025-07-05T10:45, 2025-07-05T12:15)]), # Sonja Black
             Tuple(2017CAST41, [UnavailableBetween(2025-07-04T12:00, 2025-07-04T15:15),
                                UnavailableBetween(2025-07-05T13:45, 2025-07-05T16:15)]), # Raymos Castillo
             Tuple(2022TIND01, [UnavailableBetween(2025-07-04T14:15, 2025-07-04T16:15),
                                UnavailableBetween(2025-07-05T09:00, 2025-07-05T11:15)]), # Anthony Tindal
             Tuple(2017OSUD01, [UnavailableBetween(2025-07-04T14:45, 2025-07-04T17:15)]), # Peter Osudar
             Tuple(2017LAMB06, [UnavailableBetween(2025-07-04T15:45, 2025-07-04T18:15),
                                UnavailableBetween(2025-07-05T15:45, 2025-07-05T18:15)]), # Andreas Lambropoulos
             Tuple(2023GRAY10, [UnavailableBetween(2025-07-05T09:00, 2025-07-05T10:15),
                                UnavailableBetween(2025-07-05T11:45, 2025-07-05T13:00)]), # Will Gray
             Tuple(2024BASS05, [UnavailableBetween(2025-07-05T10:45, 2025-07-05T13:00)]), # Malikai Bass
             Tuple(2023MAKA02, [UnavailableBetween(2025-07-05T12:00, 2025-07-05T15:15)]), # Amethyst Mak
             Tuple(2023MAKA02, [UnavailableBetween(2025-07-05T14:45, 2025-07-05T17:15)]) # Michael Angelo Zafra
           ],
           defaultValue=[]),
           If(BooleanProperty(FMC_VOLUNTEER),
              [UnavailableBetween(2025-07-03T14:45, 2025-07-03T17:20),
               UnavailableBetween(2025-07-04T14:45, 2025-07-04T17:20),
               UnavailableBetween(2025-07-05T14:45, 2025-07-05T17:20)], []),
           If(BooleanProperty(MULTI_VOLUNTEER),
              [UnavailableBetween(2025-07-03T10:00, 2025-07-03T15:00),
               UnavailableBetween(2025-07-05T10:00, 2025-07-05T15:00)], []),
           If(CompetingIn(_333mbf),
              [UnavailableBetween(2025-07-03T12:25, 2025-07-03T14:30),
               UnavailableBetween(2025-07-03T12:25, 2025-07-03T14:30)], []),
           If(LikelyToAdvance(_clock-r2, Arg<Person>()),
              [UnavailableBetween(2025-07-03T17:00, 2025-07-03T18:00)], []),
           If(LikelyToAdvance(_555-r2, Arg<Person>()),
              [UnavailableBetween(2025-07-03T17:15, 2025-07-03T18:00)], [])
       ))
