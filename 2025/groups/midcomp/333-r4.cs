#include "../../lib/_constants.cs"

AssignGroups(
    _333-r4,
    [
      AssignmentSet("16", (RoundPosition(_333-r3) == 16), And((GroupNumber() == 1), (Stage() == RED))),
      AssignmentSet("14", (RoundPosition(_333-r3) == 14), And((GroupNumber() == 2), (Stage() == RED))),
      AssignmentSet("12", (RoundPosition(_333-r3) == 12), And((GroupNumber() == 3), (Stage() == RED))),
      AssignmentSet("10", (RoundPosition(_333-r3) == 10), And((GroupNumber() == 4), (Stage() == RED))),
      AssignmentSet("8", (RoundPosition(_333-r3) == 8), And((GroupNumber() == 5), (Stage() == RED))),
      AssignmentSet("6", (RoundPosition(_333-r3) == 6), And((GroupNumber() == 6), (Stage() == RED))),
      AssignmentSet("4", (RoundPosition(_333-r3) == 4), And((GroupNumber() == 7), (Stage() == RED))),
      AssignmentSet("2", (RoundPosition(_333-r3) == 2), And((GroupNumber() == 8), (Stage() == RED))),
      AssignmentSet("15", (RoundPosition(_333-r3) == 15), And((GroupNumber() == 1), (Stage() == BLUE))),
      AssignmentSet("13", (RoundPosition(_333-r3) == 13), And((GroupNumber() == 2), (Stage() == BLUE))),
      AssignmentSet("11", (RoundPosition(_333-r3) == 11), And((GroupNumber() == 3), (Stage() == BLUE))),
      AssignmentSet("9", (RoundPosition(_333-r3) == 9), And((GroupNumber() == 4), (Stage() == BLUE))),
      AssignmentSet("7", (RoundPosition(_333-r3) == 7), And((GroupNumber() == 5), (Stage() == BLUE))),
      AssignmentSet("5", (RoundPosition(_333-r3) == 5), And((GroupNumber() == 6), (Stage() == BLUE))),
      AssignmentSet("3", (RoundPosition(_333-r3) == 3), And((GroupNumber() == 7), (Stage() == BLUE))),
      AssignmentSet("1", (RoundPosition(_333-r3) == 1), And((GroupNumber() == 8), (Stage() == BLUE)))])
