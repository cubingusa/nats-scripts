#include "../lib/_constants.cs"

ReadSpreadsheet("1i2J6fDlzheW0FP6eli5DbXoybGPD12WKTSh42Di4oBE", offset=1, sheetTitle="Responses")

# Set some derived properties.
DeleteRole(Persons(HasRole(DATAENTRY)), DATAENTRY)
AddRole(
    Persons(
      And(
        (StringProperty("assigned-team") == "Data Entry"),
        (NumberProperty("attending") > 2)
      )
    ), DATAENTRY)


DeleteProperty(Persons(HasProperty(CORE_VOLUNTEER)), CORE_VOLUNTEER)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "Core Volunteer Team"),
        (NumberProperty("attending") > 2)
      )
    ), CORE_VOLUNTEER, true)

DeleteProperty(Persons(HasProperty(COMMENTATOR)), COMMENTATOR)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "Live Stream Commentator"),
        (NumberProperty("attending") > 2)
      )
    ), COMMENTATOR, true)
