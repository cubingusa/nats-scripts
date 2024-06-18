#include "../lib/_constants.cs"

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

DeleteProperty(Persons(HasProperty(STAGE_LEAD)), STAGE_LEAD)
SetProperty([2010AMBR01, 2008YOUN02, 2013DICK01, 2014NIEL03, 2020LONG05, 2017WOFF01, 2015COHE02, 2015ROYC01],
            STAGE_LEAD, true)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-judge", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-scrambler", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-runner", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-Delegate", 100)

DeleteProperty(Persons(HasProperty(WCA_BOARD)), WCA_BOARD)
SetProperty(Filter([2014PRID01, 2010THOM03, 2019JARM01, 2016CHAI03, 2016SILV08], Not(IsNull(Arg<Person>()))), WCA_BOARD, true)

DeleteProperty(Persons(HasProperty(WCA_BOOTH)), WCA_BOOTH)
SetProperty([2008CLEM01, 2013KLEM01], WCA_BOOTH, true)
