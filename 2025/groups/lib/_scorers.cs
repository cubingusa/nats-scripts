# TODO: First name clusters
# TODO: Staff stages
# TODO: add time between competing in different rooms.

Define("DefaultScorers",
       [ByMatchingValue(FirstName(), -5),
        ByMatchingValue(Country(), 4, limit=2),
        ByMatchingValue(Country(), -1),
        # Put competitors in Chinese-speaking countries on one of the stages with a Chinese-speaking stage lead.
        ByFilters(In(Country(), ["CN", "HK", "TW", "SG"]),
                  In(Stage(), [MAIN_RED, MAIN_GREEN, SIDE_RED]), 10),
        # Prefer groups 2^k+1. This makes sure that smaller AssignmentSets are effectively spread out, rather than e.g. putting all of the stage leads together.
        ByFilters(true, (Mod(GroupNumber(), 2) == 1), 1),
        ByFilters(true, (Mod(GroupNumber(), 4) == 1), 1),
        ByFilters(true, (Mod(GroupNumber(), 8) == 1), 1)])
