#include "../lib/_constants.cs"

Map(
    [2025-07-03, 2025-07-04, 2025-07-05, 2025-07-06],
    NoPageBreak(All(
        Header(Weekday(Arg<Date>())),
        Table(
          Sort(Filter(AllGroups(),
                      And((Stage() == MAIN_RED), (Date(StartTime()) == Arg<Date>()))),
               StartTime()),
          [Column("Group", GroupName()), Column("Start", FormatTime(StartTime()))]))))

Map(
    [2025-07-03, 2025-07-04, 2025-07-05, 2025-07-06],
    NoPageBreak(All(
        Header(Weekday(Arg<Date>())),
        Table(
          Sort(Filter(AllGroups(),
                      And((Stage() == SIDE_RED), (Date(StartTime()) == Arg<Date>()))),
               StartTime()),
          [Column("Group", GroupName()), Column("Start", FormatTime(StartTime()))]))))
