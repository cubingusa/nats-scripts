# Staff teams
#define DATAENTRY "staff-dataentry"
#define CORE_STAFF "core-staff"
#define COMMENTATOR "commentator"
#define STAGE_LEAD "stage-lead"

#define STAFF_TEAM "staff-team"
#define LONG_ROOM_TEAM "long-room-team"

# Stages
#define RED "Red Stage"
#define BLUE "Blue Stage"
#define GREEN "Green Stage"
#define ORANGE "Orange Stage"
#define SIDE "Side Room"

Define("Stages", [RED, BLUE, GREEN, ORANGE])
Define("FinalsStages", [RED, BLUE])
Define("IsStaff", Or(BooleanProperty(DATAENTRY),
                     BooleanProperty(CORE_STAFF),
                     BooleanProperty(COMMENTATOR),
                     BooleanProperty(STAGE_LEAD),
                     HasRole("organizer")))

# Other roles
#define WCA_BOARD "wca-board"
#define WCA_BOOTH "wca-booth"
