# Staff teams
#define DATAENTRY "staff-dataentry"
#define CORE_VOLUNTEER "core-volunteer"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"
#define UNOFFICIAL_EVENTS "unofficial"

#define STAFF_TEAM "staff-team"
#define LONG_ROOM_ASSIGNMENTS "long-room-assignments"

# Stages
#define MAIN_HALL "Main Hall"
#define RED "Red Stage"
#define BLUE "Blue Stage"
#define GREEN "Green Stage"
#define ORANGE "Orange Stage"
#define SIDE_ROOMS "Side Rooms"

Define("Stages", [RED, BLUE, GREEN, ORANGE])
Define("FinalsStages", [RED, BLUE])
Define("IsVolunteer", Or(BooleanProperty(DATAENTRY),
                         BooleanProperty(CORE_VOLUNTEER),
                         BooleanProperty(COMMENTATOR),
                         BooleanProperty(STAGE_LEAD),
                         HasRole("organizer")))
Define("IsStageLead", (StringProperty(STAGE_LEAD) == STAGE_LEAD))
Define("IsDelegate", In(StringProperty("delegate-status"),
                        ["WCA Full Delegate", "WCA Junior Delegate", "WCA Trainee Delegate"]))

# Other roles
#define WCA_BOOTH "wca-booth"
#define FINALS_TEAM "finals-team"
#define FINALS_VOLUNTEER "finals-volunteer"

# These are all the NA countries represented at NAC 2026. Future NACs should update this list.
Define("IsNorthAmerican", In(Country(), ["US", "MX", "CA", "GT", "PA"]))
