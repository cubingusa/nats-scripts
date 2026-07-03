#include "../lib/_assigned_stage.cs"
#include "../lib/_constants.cs"

# Args:
# 1: Stage
# 2: Date
Define("AssignmentReportForOneStage",
       AssignmentReport(
         Persons((AssignedStage(Arg<Person>(), {2, Date}) == {1, String})),
         Filter(AllGroups(),
                And((Date(StartTime(Arg<Group>())) == {2, Date}),
                    (Stage() == {1, String}),
                    (RoundNumber(Round()) < 3))),
         (Weekday({2, Date}) + (" - " + {1, String})),
         ignoreStage={1, String}))
