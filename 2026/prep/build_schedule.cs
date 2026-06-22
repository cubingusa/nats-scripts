#include "../lib/_constants.cs"

DeleteRooms([MAIN_HALL, SIDE_ROOMS])
CreateRoom(MAIN_HALL, "#884488")
CreateRoom(SIDE_ROOMS, "#FFD700")

CreateStage(RED, MAIN_HALL, "#ff0000")
CreateStage(BLUE, MAIN_HALL, "#0000ff")
CreateStage(GREEN, MAIN_HALL, "#00ff00")
CreateStage(ORANGE, MAIN_HALL, "#ff8800")

# Long room
 CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind", "other-multi", SIDE_ROOMS, 2026-07-02T08:30, 2026-07-02T09:30)
CreateGroups(_333mbf-r1-a1, 1, SIDE_ROOMS, 2026-07-02T12:45, 2026-07-02T14:00, useStageName=false)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind", "other-multi", SIDE_ROOMS, 2026-07-04T08:30, 2026-07-04T09:30)
CreateGroups(_333mbf-r1-a2, 1, SIDE_ROOMS, 2026-07-04T13:15, 2026-07-04T14:30, useStageName=false)
CreateGroups(_333fm-r1-a1, 1, SIDE_ROOMS, 2026-07-03T09:00, 2026-07-03T10:15, useStageName=false)
CreateGroups(_333fm-r1-a2, 1, SIDE_ROOMS, 2026-07-03T13:00, 2026-07-03T14:15, useStageName=false)
CreateGroups(_333fm-r1-a3, 1, SIDE_ROOMS, 2026-07-03T14:15, 2026-07-03T15:30, useStageName=false)

# Thursday
CreateMiscActivity("Check-in opens", "other-checkin", MAIN_HALL, 2026-07-02T08:00, 2026-07-02T09:00)

Map([RED, BLUE], CreateGroups(_555bf-r1, 1, 2026-07-02T09:00, 2026-07-02T09:45))
Map(Stages(), CreateGroups(_555-r1, 3, 2026-07-02T09:45, 2026-07-02T10:55))
Map([RED, BLUE, ORANGE], CreateGroups(_clock-r1, 3, 2026-07-02T10:55, 2026-07-02T11:50))

CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2026-07-02T11:50, 2026-07-02T12:45)

Map(Stages(), CreateGroups(_333oh-r1, 9, 2026-07-02T12:45, 2026-07-02T15:00))
Map(Stages(), CreateGroups(_pyram-r1, 9, 2026-07-02T15:00, 2026-07-02T17:15))
Map([RED, BLUE, GREEN], CreateGroups(_555-r2, 1, 2026-07-02T17:15, 2026-07-02T17:45))
Map([RED, BLUE, GREEN], CreateGroups(_clock-r2, 1, 2026-07-02T17:45, 2026-07-02T18:05))

CreateMiscActivity("Opening Ceremony", "other-misc", MAIN_HALL, 2026-07-02T18:15, 2026-07-02T19:00)
CreateMiscActivity("Rubik's Regions Relay", "other-misc", MAIN_HALL, 2026-07-02T19:00, 2026-07-02T20:00)

# Friday
CreateMiscActivity("Check-in opens", "other-checkin", MAIN_HALL, 2026-07-03T08:00, 2026-07-03T09:00)
Map(Stages(), CreateGroups(_222-r1, 10, 2026-07-03T08:45, 2026-07-03T11:00))
Map(Stages(), CreateGroups(_666-r1, 2, 2026-07-03T11:00, 2026-07-03T11:40))
Map(Stages(), CreateGroups(_333oh-r2, 1, 2026-07-03T11:40, 2026-07-03T12:00))
Map(Stages(), CreateGroups(_pyram-r2, 1, 2026-07-03T12:00, 2026-07-03T12:30))

CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2026-07-03T12:30, 2026-07-03T13:30)

Map(Stages(), CreateGroups(_444-r1, 9, 2026-07-03T13:30, 2026-07-03T16:20))
Map([RED, BLUE, ORANGE], CreateGroups(_sq1-r1, 2, 2026-07-03T16:20, 2026-07-03T17:00))
Map([RED, BLUE], CreateGroups(_555-r3, 1, 2026-07-03T17:00, 2026-07-03T17:30))
Map([RED, BLUE], CreateGroups(_clock-r3, 1, 2026-07-03T17:30, 2026-07-03T18:00))
Map([RED, BLUE], CreateGroups(_pyram-r3, 1, 2026-07-03T18:00, 2026-07-03T18:30))
Map([RED, BLUE], CreateGroups(_333oh-r3, 1, 2026-07-03T18:30, 2026-07-03T19:00))

# Saturday
CreateMiscActivity("Check-in opens", "other-checkin", MAIN_HALL, 2026-07-04T08:00, 2026-07-04T09:00)

Map([RED, BLUE, ORANGE], CreateGroups(_333bf-r1, 2, 2026-07-04T08:45, 2026-07-04T09:25))
Map(Stages(), CreateGroups(_skewb-r1, 9, 2026-07-04T09:25, 2026-07-04T11:30))
Map(Stages(), CreateGroups(_444-r2, 1, 2026-07-04T11:30, 2026-07-04T12:00))
Map(Stages(), CreateGroups(_222-r2, 1, 2026-07-04T12:00, 2026-07-04T12:20))
Map(Stages(), CreateGroups(_sq1-r2, 1, 2026-07-04T12:20, 2026-07-04T12:40))

CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2026-07-04T12:40, 2026-07-04T13:30)

Map(Stages(), CreateGroups(_333-r1, 11, 2026-07-04T13:30, 2026-07-04T16:15))
Map(Stages(), CreateGroups(_777-r1, 2, 2026-07-04T16:15, 2026-07-04T17:00))
Map([RED, BLUE], CreateGroups(_444-r3, 1, 2026-07-04T17:00, 2026-07-04T17:30))
Map([RED, BLUE], CreateGroups(_sq1-r3, 1, 2026-07-04T17:30, 2026-07-04T18:00))
Map([RED, BLUE], CreateGroups(_222-r3, 1, 2026-07-04T18:00, 2026-07-04T18:30))
Map([RED, BLUE], CreateGroups(_666-r2, 1, 2026-07-04T18:30, 2026-07-04T19:00))

# Sunday
Map(Stages(), CreateGroups(_444bf-r1, 1, 2026-07-05T08:45, 2026-07-05T09:30))
Map(Stages(), CreateGroups(_333-r2, 4, 2026-07-05T09:30, 2026-07-05T10:30))
Map(Stages(), CreateGroups(_minx-r1, 2, 2026-07-05T10:30, 2026-07-05T11:15))
Map(Stages(), CreateGroups(_skewb-r2, 1, 2026-07-05T11:15, 2026-07-05T11:35))
Map(Stages(), CreateGroups(_333bf-r2, 1, 2026-07-05T11:35, 2026-07-05T12:05))

CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2026-07-05T12:05, 2026-07-05T13:00)

Map(Stages(), CreateGroups(_333-r3, 1, 2026-07-05T13:00, 2026-07-05T13:30))

Map([RED, BLUE], CreateGroups(_777-r2, 1, 2026-07-05T13:30, 2026-07-05T14:00))
Map([RED, BLUE], CreateGroups(_skewb-r3, 1, 2026-07-05T14:00, 2026-07-05T14:30))
Map([RED, BLUE], CreateGroups(_minx-r2, 1, 2026-07-05T14:30, 2026-07-05T15:00))
Map([RED, BLUE], CreateGroups(_333bf-r3, 1, 2026-07-05T15:00, 2026-07-05T15:30))
Map([RED, BLUE], CreateGroups(_333-r4, 8, 2026-07-05T15:45, 2026-07-05T17:05))
CreateMiscActivity("Awards", "other-awards", MAIN_HALL, 2026-07-05T17:15, 2026-07-05T18:00)
