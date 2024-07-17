#include "../lib/_constants.cs"

Map(
    [2024-07-18, 2024-07-19, 2024-07-20, 2024-07-21],
    NoPageBreak(All(
        Header(Weekday(Arg<Date>())),
        Table(
          Sort(Filter(AllGroups(),
                      And(Or(And((Stage() == RED), (GroupNumber() > 2), (RoundNumber(Round()) == 1)),
                             And((Stage() == ORANGE), (GroupNumber() <= 2), (RoundNumber(Round()) == 1)),
                             And((Stage() == RED), (RoundNumber(Round()) > 1))),
                          (Date(StartTime()) == Arg<Date>()))),
               StartTime()),
          [Column("Group", GroupName()), Column("Start", FormatTime(StartTime()))]))))
