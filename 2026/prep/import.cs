#include "../lib/_constants.cs"

ReadSpreadsheet("1MUfrBhepdqVTJNu7Uu0LIe0Zf3T4CepSQLZ4maJyTl0", offset=1, sheetTitle="Form_Responses")

# Set some derived properties.
DeleteRole(Persons(HasRole(DATAENTRY)), DATAENTRY)
AddRole(
    Persons(
      And(
        (StringProperty("assigned-team") == "Data Entry"),
        (StringProperty("attending") == "Yes")
      )
    ), DATAENTRY)


DeleteProperty(Persons(HasProperty(CORE_VOLUNTEER)), CORE_VOLUNTEER)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "Core Volunteer Team"),
        (StringProperty("attending") == "Yes")
      )
    ), CORE_VOLUNTEER, true)

DeleteProperty(Persons(HasProperty(COMMENTATOR)), COMMENTATOR)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "Live Stream Commentator/Team"),
        (StringProperty("attending") == "Yes")
      )
    ), COMMENTATOR, true)

DeleteProperty(Persons(HasProperty(WCA_BOOTH)), WCA_BOOTH)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "WCA Booth"),
        (StringProperty("attending") == "Yes")
      )
    ), WCA_BOOTH, true)

DeleteProperty(Persons(HasProperty(UNOFFICIAL_EVENTS)), UNOFFICIAL_EVENTS)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "Unofficial Events"),
        (StringProperty("attending") == "Yes")
      )
    ), UNOFFICIAL_EVENTS, true)
SetProperty([2009HAYS01], COMMENTATOR, true)
SetProperty([2018LAND03], COMMENTATOR, true)
SetProperty([2013DICK01], UNOFFICIAL_EVENTS, true)
