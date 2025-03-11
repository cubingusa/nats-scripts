# Volunteer teams
#define DATAENTRY "staff-dataentry"
#define CORE_VOLUNTEER "core-volunteer"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"
#define STAFF_TEAM "staff-team"

# Stages
#define MAIN_RED "Red Stage"
#define MAIN_BLUE "Blue Stage"
#define MAIN_GREEN "Green Stage"
#define MAIN_ORANGE "Orange Stage"
#define MAIN_YELLOW "Yellow Stage"
#define MAIN_WHITE "White Stage"
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

Define("IsDataEntry", (StringProperty("assigned-team") == DATAENTRY))
