#include "../lib/_constants.cs"

2003DICK01
2009HILD01
2011WELC01
2004CHAN04
2008YOUN02
2010AMBR01
2014GARB01
2005REYN01

Map([1, 2, 3, 4],
    All(
      ManuallyAssign([2004CHAN04], _333-r4, MAIN_RED, Arg<Number>(), "staff-judge"),
      ManuallyAssign([2008YOUN02], _333-r4, MAIN_RED, Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2011WELC01], _333-r4, MAIN_RED, Arg<Number>(), "staff-runner"),
      ManuallyAssign([2013DICK01], _333-r4, MAIN_RED, Arg<Number>(), "staff-Checker"),
      ManuallyAssign([2014GARB01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-judge"),
      ManuallyAssign([2005REYN01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2010AMBR01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-runner"),
      ManuallyAssign([2009HILD01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-Checker")))

Map([5, 6, 7, 8],
    All(
      ManuallyAssign([2013DICK01], _333-r4, MAIN_RED, Arg<Number>(), "staff-judge"),
      ManuallyAssign([2011WELC01], _333-r4, MAIN_RED, Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2008YOUN02], _333-r4, MAIN_RED, Arg<Number>(), "staff-runner"),
      ManuallyAssign([2004CHAN04], _333-r4, MAIN_RED, Arg<Number>(), "staff-Checker"),
      ManuallyAssign([2010AMBR01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-judge"),
      ManuallyAssign([2009HILD01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-scrambler"),
      ManuallyAssign([2005REYN01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-runner"),
      ManuallyAssign([2010AMBR01], _333-r4, MAIN_BLUE, Arg<Number>(), "staff-Checker")))
