# TODO: First name clusters
# TODO: Staff stages
# TODO: add time between competing in different rooms.

Define("DefaultScorers",
       [ByMatchingValue(FirstName(), -5),
        ByMatchingValue(Country(), 4, limit=2),
        ByMatchingValue(Country(), -1)])
