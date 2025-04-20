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

DeleteProperty(Persons(HasProperty(WCA_BOOTH)), WCA_BOOTH)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "WCA Booth"),
        (NumberProperty("attending") > 2)
      )
    ), WCA_BOOTH, true)

# TODO: figure out which organizers are in which room
DeleteProperty(Persons(HasProperty(MAIN_HALL_ORGANIZER)), MAIN_HALL_ORGANIZER)
SetProperty([2005REYN01, 2014GARB01, 2014GRIG01, 2007BARR01, 2011WELC01, 2010AMBR01,
             2008YOUN02, 2009HILD01, 2004CHAN04, 2006SHEU01, 2013DICK01],
            MAIN_HALL_ORGANIZER, true)
