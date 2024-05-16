#include "lib/_constants.cs"

ReadSpreadsheet("1-KNvZD5o6A4oeqwypppvSwgMnpLMjElo6B-kPvr4dco", offset=1, sheetTitle="Preferences")

# Set some derived properties.
DeleteRole(Persons(HasRole(DATAENTRY)), DATAENTRY)
AddRole(
    Persons(
      And(
        (StringProperty("staff-team-form") == "Data Entry"),
        (NumberProperty("attending") > 2)
      )
    ), DATAENTRY)


DeleteProperty(Persons(HasProperty(CORE_STAFF)), CORE_STAFF)
SetProperty(
    Persons(
      And(
        (StringProperty("staff-team-form") == "Core Staff"),
        (NumberProperty("attending") > 2)
      )
    ), CORE_STAFF, true)

DeleteProperty(Persons(HasProperty(COMMENTATOR)), COMMENTATOR)
SetProperty(
    Persons(
      And(
        (StringProperty("staff-team-form") == "Live Stream Commentator"),
        (NumberProperty("attending") > 2)
      )
    ), COMMENTATOR, true)
