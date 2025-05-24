# Volunteer teams
#define DATAENTRY "staff-dataentry"
#define CORE_VOLUNTEER "core-volunteer"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"
#define STAFF_TEAM "staff-team"
#define WCA_BOOTH "wca-booth"
#define MAIN_HALL_ORGANIZER "main-hall-organizer"
#define BALLROOM_ORGANIZER "ballroom-organizer"
#define FINALS_TEAM "finals-team"
#define FINALS_VOLUNTEER "finals-team-volunteer"

# Stages
#define MAIN_RED "Main Red"
#define MAIN_BLUE "Main Blue"
#define MAIN_GREEN "Main Green"
#define MAIN_ORANGE "Main Orange"
#define MAIN_YELLOW "Main Yellow"
#define MAIN_WHITE "Main White"
#define SIDE_RED "Ballroom Red"
#define SIDE_BLUE "Ballroom Blue"
#define SIDE_GREEN "Ballroom Green"
#define SIDE_ORANGE "Ballroom Orange"

# Rooms
#define LONG_ROOM "Room 607-610"
#define MAIN_HALL "Hall 4"
#define LOBBY "Lobby"
#define BALLROOM "Ballroom 6"

Define("AllStages", [MAIN_RED, MAIN_BLUE, MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE,
                     SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])
Define("MainStages", [MAIN_RED, MAIN_BLUE, MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE])
Define("SideStages", [SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])
Define("FinalsStages", [MAIN_RED, MAIN_BLUE])
Define("NonFinalsStages", [MAIN_GREEN, MAIN_ORANGE, MAIN_YELLOW, MAIN_WHITE,
                           SIDE_RED, SIDE_BLUE, SIDE_GREEN, SIDE_ORANGE])

Define("IsDataEntry", (StringProperty("assigned-team") == DATAENTRY))
Define("IsDelegate", (And((StringProperty("assigned-team") == CORE_VOLUNTEER),
                          (StringProperty("delegate-status") != "Not a WCA Delegate"))))
