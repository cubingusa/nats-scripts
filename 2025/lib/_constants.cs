# Volunteer teams
#define DATAENTRY "staff-dataentry"
#define ORGANIZER "organizer"
#define CORE_VOLUNTEER "core-volunteer"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"
#define STAFF_TEAM "staff-team"
#define WCA_BOOTH "wca-booth"
#define WCA_BOARD "wca-board"
#define MAIN_HALL_BACKUP_STAGE_LEAD "main-hall-organizer"
#define BALLROOM_BACKUP_STAGE_LEAD "ballroom-organizer"
#define FINALS_TEAM "finals-team"
#define FINALS_VOLUNTEER "finals-team-volunteer"
#define DATA_TEAM "data-team"

#define MULTI_VOLUNTEER "multi-volunteer"
#define FMC_VOLUNTEER "fmc-volunteer"

#define FTO_VOLUNTEER "fto"
#define TEAM_BLD_VOLUNTEER "team-bld"
#define MIRROR_BLOCKS_VOLUNTEER "mirror-blocks"

# Stages
#define MAIN_RED "Main Red"
#define MAIN_BLUE "Main Blue"
#define MAIN_GREEN "Main Green"
#define MAIN_ORANGE "Main Orange"
#define MAIN_YELLOW "Main Yellow"
#define MAIN_WHITE "Main White"
#define SIDE_RED "Side Red"
#define SIDE_BLUE "Side Blue"
#define SIDE_GREEN "Side Green"
#define SIDE_ORANGE "Side Orange"

# Rooms
#define LONG_ROOM "Room 607-610"
#define MAIN_HALL "Main Stages (Hall 4EF)"
#define LOBBY "Lobby"
#define BALLROOM "Side Stages (Hall 4AB)"

# Accommodations
#define ACCOMMODATION "accommodation"
#define NO_SATURDAY "sat"
#define NO_SUNDAY_MORNING "sun"
#define NO_FRIDAY_EARLY_AFTERNOON "fri_pm"


Define("AllStages", [MAIN_RED, MAIN_BLUE, MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE,
                     SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])
Define("MainStages", [MAIN_RED, MAIN_BLUE, MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE])
Define("SideStages", [SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])
Define("FinalsStages", [MAIN_RED, MAIN_BLUE])
Define("NonFinalsStages", [MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE,
                           SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])

Define("IsDataEntry", (StringProperty("assigned-team") == DATAENTRY))
Define("IsDelegate", And(BooleanProperty(CORE_VOLUNTEER),
                         (StringProperty("delegate-status") != "Not a WCA Delegate")))
Define("IsStageLead", (StringProperty(STAGE_LEAD) == STAGE_LEAD))

Define("IsStageLeadTogether", And(IsStageLead({1, Person}), IsStageLead({2, Person}),
                                  (StringProperty(STAFF_TEAM, {1, Person}) ==
                                   StringProperty(STAFF_TEAM, {2, Person}))))
