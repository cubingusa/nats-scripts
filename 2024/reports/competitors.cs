"Number competed"
Length(Persons(HasResults()))
""
"Likely no-shows"
Length(Persons(IsPossibleNoShow()))
""
"First event hasn't happened yet"
(Length(Persons(Registered())) - (Length(Persons(IsPossibleNoShow())) + Length(Persons(HasResults()))))
