#include "lib/_assignment_sets.cs"
#include "lib/_group_scorers.cs"

#include "../lib/_constants.cs"

Define("Sets", RoundOneAssignmentSets({1, Event}, 2026-07-05))
Define("Scorers", DefaultScorers(2026-07-05, {1, Event}))

AssignGroups(_444bf-r1,
             [AssignmentSet("RB", (PsychSheetPosition(_444bf) <= 16), In(Stage(), FinalsStages())),
              AssignmentSet("GO", (PsychSheetPosition(_444bf) > 16), Not(In(Stage(), FinalsStages())))],
             Scorers(_444bf),
             stationRules=[StationAssignmentRule(true, "ascending", PsychSheetPosition(_444bf),
                                                 stationExclusionRules=[NonNAStream()])])
AssignGroups(_minx-r1, Sets(_minx), Scorers(_minx))

#include "../lib/_assignment_table.cs"
AssignmentTable(
    Sort(Persons(IsStageLead()),
         AssignedStage(Arg<Person>(), 2026-07-05)),
    [_minx-r1],
    [Column("Stage", AssignedStage(Arg<Person>(), 2026-07-05))])
