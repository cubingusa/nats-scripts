#include "../lib/_constants.cs"

Define("StageLeadAssignments",
       Table(
         Sort(Persons(And(IsStageLead(), CompetingInRound({1, Round}))), NumberProperty(STAFF_TEAM)),
         [
           Column("Name", Name()),
           Column("WcaId", WcaId()),
           Column("Team", NumberProperty(STAFF_TEAM)),
           Column("Assigned Group", GroupName(AssignedGroup({1, Round}))),
           Column("Stage Name", Stage(AssignedGroup({1, Round})))
         ]))
