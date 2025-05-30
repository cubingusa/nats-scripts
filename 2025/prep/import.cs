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
SetProperty([2018HOUB01], COMMENTATOR, true)

DeleteProperty(Persons(HasProperty(WCA_BOOTH)), WCA_BOOTH)
SetProperty(
    Persons(
      And(
        (StringProperty("assigned-team") == "WCA Booth"),
        (NumberProperty("attending") > 2)
      )
    ), WCA_BOOTH, true)

DeleteProperty(Persons(HasProperty(MAIN_HALL_BACKUP_STAGE_LEAD)), MAIN_HALL_BACKUP_STAGE_LEAD)
SetProperty([2009HILD01, 2014GARB01], MAIN_HALL_BACKUP_STAGE_LEAD, true)
DeleteProperty(Persons(HasProperty(BALLROOM_BACKUP_STAGE_LEAD)), BALLROOM_BACKUP_STAGE_LEAD)
SetProperty([2008YOUN02, 2013DICK01], BALLROOM_BACKUP_STAGE_LEAD, true)

SetProperty([2010THOM03, 2016SILV08, 2018SMIT42], WCA_BOARD, true)
