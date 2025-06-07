#include "../../lib/_constants.cs"

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
             Tuple(2015PADG01, [UnavailableBetween(2025-07-04T00:00, 2025-07-04T23:59)]),  # Dalton Padgett
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
             Tuple(2023GROS05, [UnavailableBetween(2025-07-05T00:00, 2025-07-05T23:59)]),  # Zalman Grossbaum
             Tuple(2022DAYJ01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T12:00)]),  # Joey Day
             Tuple(2017OSUD01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T23:59)]),  # Peter Osudar
             Tuple(2019BEZZ01, [UnavailableBetween(2025-07-06T00:00, 2025-07-06T12:00)]),  # Nico Bezzerides
             Tuple(2008WARL01, [UnavailableBetween(2025-07-05T16:30, 2025-07-05T23:59)]),  # Jackson Warley
             Tuple(2019BURG06, [UnavailableBetween(2025-07-05T00:00, 2025-07-05T10:00)]),  # Brendan Burgess
             Tuple(2022GRAI02, [DuringTimes(CompetingTimes(2018GRAI01, In(EventForRound(Round()), [_clock, _minx])))]),  # Kirsty Grainger
             Tuple(2018GONZ09, [DuringTimes(CompetingTimes(2018PERE37, true))]),  # Lorenzo Gonzalez
             Tuple(2020TONG02, [UnavailableBetween(2025-07-03T00:00, 2025-07-03T12:45)]),  # Draco Tong
             Tuple(2013FRAI01, [UnavailableBetween(2025-07-05T11:45, 2025-07-05T12:25)]),  # Diego Fraile
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
             Tuple(2011MASS01, [UnavailableBetween(2025-07-05T17:50, 2025-07-05T18:35),
                                UnavailableBetween(2025-07-03T14:45, 2025-07-03T15:15)]), # Nikolai Masson
             Tuple(2018HOUB01, [UnavailableBetween(2025-07-04T13:45, 2025-07-04T14:15),
                                UnavailableBetween(2025-07-05T09:40, 2025-07-05T10:10)]), # Bailing Hou
             Tuple(2019TAMU01, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T16:30),
                                UnavailableBetween(2025-07-04T15:15, 2025-07-04T16:30),
                                UnavailableBetween(2025-07-05T15:15, 2025-07-05T16:30)]), # Takumi Tamura
             Tuple(2019SULE01, [UnavailableBetween(2025-07-05T16:00, 2025-07-05T23:59)]), # Daniyal Suleimen
             Tuple(2012CANT02, [UnavailableBetween(2025-07-03T10:00, 2025-07-03T11:00)]), # Simone Cantarelli
             Tuple(2013DIPI01, [UnavailableBetween(2025-07-03T11:45, 2025-07-03T12:45)]), # Guido DiPietro
             Tuple(2015MACK06, [UnavailableBetween(2025-07-03T14:15, 2025-07-03T15:00)]), # Zeke Mackay
             Tuple(2018DAIN02, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T15:45)]), # Peri Le Dain
             Tuple(2019KUCA01, [UnavailableBetween(2025-07-03T15:15, 2025-07-03T15:45)]), # Lisa Kucala
             Tuple(2015KUCA01, [UnavailableBetween(2025-07-04T09:30, 2025-07-04T10:30)]), # Carter Kucala
             Tuple(2014GOSL01, [UnavailableBetween(2025-07-04T10:30, 2025-07-04T12:00)]), # Raymond Goslow
             Tuple(2015SPEN01, [UnavailableBetween(2025-07-04T14:15, 2025-07-04T15:15)]), # Sam Spendla
             Tuple(2022HEXT01, [UnavailableBetween(2025-07-04T14:15, 2025-07-04T15:15)]), # Oliver Hexter
             Tuple(2013DICK01, [UnavailableBetween(2025-07-04T15:15, 2025-07-04T16:15)]), # Matthew Dickman
             Tuple(2020LONG05, [UnavailableBetween(2025-07-05T09:30, 2025-07-05T11:00)]), # Shain Longbehn
             Tuple(2016LOPE37, [UnavailableBetween(2025-07-05T14:30, 2025-07-05T15:15)]) # Ruben Lopez de Juan
           ]),
           If(BooleanProperty(FMC_VOLUNTEER),
              [UnavailableBetween(2025-07-03T14:45, 2025-07-03T17:20),
               UnavailableBetween(2025-07-04T14:45, 2025-07-04T17:20),
               UnavailableBetween(2025-07-05T14:45, 2025-07-05T17:20)], []),
           If(BooleanProperty(MULTI_VOLUNTEER),
              [UnavailableBetween(2025-07-03T10:00, 2025-07-03T15:00),
               UnavailableBetween(2025-07-05T10:00, 2025-07-05T15:00)], [])
       ))
