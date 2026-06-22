#include "../../lib/_advancement.cs"
#include "../../lib/_constants.cs"
#include "../../lib/_long_room_volunteers.cs"

Define("CompetingTimes",
       Map(Filter(AssignedGroups({1, Person}),
                  And({2, Boolean(Group)},
                      Not(In(Event(), [_333fm, _333mbf])))), StartTime()))

Define("Unavailable",
       Concat(
         Switch(
           {1, Person},
           [
             Tuple(2023KRAS01, [DuringTimes(CompetingTimes(2022KRAS02, true))]), # David Krasne
             Tuple(2014GULA02, [UnavailableBetween(2026-07-03T13:00, 2026-07-03T15:00)]), # Abdullah Gulab
             Tuple(2015WEBS01, [UnavailableBetween(2026-07-05T00:00, 2026-07-05T10:30)]), # Garrett Webster
             Tuple(2015BURG02, [UnavailableBetween(2026-07-05T00:00, 2026-07-05T13:00)]), # Brock Burgi
             Tuple(2017HADE01, [UnavailableBetween(2026-07-05T00:00, 2026-07-05T11:00)]), # Rustin Haderlie
             Tuple(2022DAYJ01, [UnavailableBetween(2026-07-05T00:00, 2026-07-05T12:00)]), # Joey Day
             Tuple(2015PADG01, [UnavailableBetween(2026-07-04T00:00, 2026-07-04T23:59),
                                UnavailableBetween(2026-07-02T10:55, 2026-07-02T12:00)]), # Dalton Padgett
             Tuple(p540853, [DuringTimes(CompetingTimes(2022PRZE01, true))]), # Holly Prze
             Tuple(2022DONA04, [UnavailableBetween(2026-07-02T16:30, 2026-07-02T23:59),
                                UnavailableBetween(2026-07-03T16:30, 2026-07-03T23:59),
                                UnavailableBetween(2026-07-04T16:30, 2026-07-04T23:59),
                                UnavailableBetween(2026-07-05T12:00, 2026-07-05T23:59)]), # Ishan Donavalli
             Tuple(2024THAN02, [UnavailableBetween(2026-07-05T12:00, 2026-07-05T23:59)]), # Hiêu Thành Pham
             Tuple(p540509, [UnavailableBetween(2026-07-02T17:00, 2026-07-02T23:59),
                             DuringTimes(CompetingTimes(2021RAME01, true))]), # Ramesh Subramaniam
             Tuple(2011ALLU01, [UnavailableBetween(2026-07-05T00:00, 2026-07-05T23:59)]), # John Allums
             Tuple(2011HAYS01, [DuringTimes(CompetingTimes(2009HAYS01, true))]),  # Paul Hays
             Tuple(2011HAYS02, [DuringTimes(CompetingTimes(2009HAYS01, true))]),  # Donna Hays
             Tuple(2022KUCA01, [DuringTimes(CompetingTimes(2015KUCA01, true))]),  # Joe Kucala
             Tuple(2005STIL01, [DuringTimes(CompetingTimes(2003LEEJ01, true))]),  # Peter Still
             Tuple(2003LEEJ01, [DuringTimes(CompetingTimes(2005STIL01, true))]),  # Jasmine Lee
             Tuple(2023PRIN03, [DuringTimes(CompetingTimes(2023PRIN02, true))]),  # Kavin Prince
             Tuple(2017HART11, [DuringTimes(CompetingTimes(2016HART02, true)),
                                DuringTimes(CompetingTimes(2015CHER07, true))]),  # Nancy Hartman
             Tuple(2015LANE01, [UnavailableBetween(2026-07-02T00:00, 2026-07-02T09:45),
                                UnavailableBetween(2026-07-04T00:00, 2026-07-04T09:45)]),  # Phillip Lane
             Tuple(2022KUMA32, [UnavailableBetween(2026-07-02T00:00, 2026-07-02T11:00)])  # Arnav Kumar
           ],
           defaultValue=[]),
           If(FMC1Volunteer(),
              [UnavailableBetween(2026-07-03T08:30, 2026-07-03T11:00)], []),
           If(FMC2Volunteer(),
              [UnavailableBetween(2026-07-03T12:30, 2026-07-03T15:00)], []),
           If(FMC3Volunteer(),
              [UnavailableBetween(2026-07-03T13:30, 2026-07-03T16:15)], []),
           If(Multi1Volunteer(),
              [UnavailableBetween(2026-07-02T09:15, 2026-07-02T14:45)], []),
           If(Multi2Volunteer(),
              [UnavailableBetween(2026-07-04T09:15, 2026-07-04T15:00)], []),
           If(CompetingIn(_333mbf),
              [UnavailableBetween(2026-07-02T12:45, 2026-07-02T14:30),
               UnavailableBetween(2026-07-04T12:15, 2026-07-04T15:00)], []),
           If(CompetingIn(_333fm),
              [UnavailableBetween(2026-07-03T08:00, 2026-07-03T10:40),
               UnavailableBetween(2026-07-03T12:15, 2026-07-03T16:00)], [])
       ))
