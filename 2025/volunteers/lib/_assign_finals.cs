#include "_scorers.cs"
#include "_unavailable.cs"
#include "../../lib/_constants.cs"

Define("FinalsVolunteerAssignments",
       Map([Tuple(1, MAIN_RED), Tuple(2, MAIN_BLUE)],
            AssignStaff(
              {1, Round},
              (Stage() == Second(Arg<Tuple<Number, String>>())),
              Persons((NumberProperty(FINALS_TEAM) == First(Arg<Tuple<Number, String>>()))),
              {2, Array<AssignmentJob>},
              VolunteerScorers(EventForRound({1, Round}), Date(RoundStartTime({1, Round}))),
              unavailable=Unavailable(Arg<Person>()), overwrite=true)))
