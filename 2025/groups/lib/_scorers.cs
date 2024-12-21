# TODO: First name clusters
# TODO: Staff stages
# TODO: add time between competing in different rooms.
# TODO: Limit max value of matching countries.

Define("DefaultScorers",
       [ByMatchingValue(FirstName(), -5),
        ByMatchingValue(Country(), 10)])
