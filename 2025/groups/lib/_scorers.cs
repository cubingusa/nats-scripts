# TODO: First name clusters
# TODO: Staff stages
# TODO: add time between competing in different rooms.

Define("DefaultScorers",
       [ByMatchingValue(FirstName(), -5),
        ByMatchingValue(Country(), 4, limit=2),
        ByMatchingValue(Country(), -1),
        # Prefer groups 2^k+1. This makes sure that smaller AssignmentSets are effectively spread out, rather than e.g. putting all of the stage leads together.
        ByFilters(true, (Mod(GroupNumber(), 2) == 1), 1),
        ByFilters(true, (Mod(GroupNumber(), 4) == 1), 1),
        ByFilters(true, (Mod(GroupNumber(), 8) == 1), 1)])
