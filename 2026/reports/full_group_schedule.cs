#include "../lib/_constants.cs"

Map(
    [2026-07-02, 2026-07-03, 2026-07-04, 2026-07-05],
    NoPageBreak(All(
        Header(Weekday(Arg<Date>())),
        Table(
          Sort(Filter(AllGroups(),
                      And((Stage() == RED), (Date(StartTime()) == Arg<Date>()))),
               StartTime()),
          [Column("Group", GroupName()), Column("Start", FormatTime(StartTime()))]))))
