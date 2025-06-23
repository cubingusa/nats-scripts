#include "_scorers.cs"
#include "../../lib/_constants.cs"

Define("FinalsVolunteerAssignments",
       Map([Tuple(1, MAIN_BLUE), Tuple(2, MAIN_RED)],
            AssignStaff(
              {1, Round},
              (Stage() == Second<String>()),
              Persons((NumberProperty(FINALS_TEAM) == First<Number>())),
              {2, Array<AssignmentJob>},
              DefaultScorers(Date(RoundStartTime({1, Round}))),
              unavailable=Unavailable(Arg<Person>()))))
