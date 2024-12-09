#include "../lib/_constants.cs"

DeleteRooms(AllStages())
DeleteRooms([LONG_ROOM, MAIN_HALL, LOBBY])

CreateRoom(MAIN_RED, "#ff0000")
CreateRoom(MAIN_BLUE, "#0000ff")
CreateRoom(MAIN_GREEN, "#00ff00")
CreateRoom(MAIN_ORANGE, "#ff8000")
CreateRoom(MAIN_YELLOW, "#ffff00")
CreateRoom(MAIN_WHITE, "#ffffff")

CreateRoom(SIDE_RED, "#c00000", groupNamePrefix="RR")
CreateRoom(SIDE_BLUE, "#000080", groupNamePrefix="BB")
CreateRoom(SIDE_GREEN, "#008000", groupNamePrefix="GG")
CreateRoom(SIDE_ORANGE, "#c06000", groupNamePrefix="OO")

CreateRoom(LONG_ROOM, "#888888")
CreateRoom(MAIN_HALL, "#000088")
CreateRoom(LOBBY, "#000000")

# Long room
CreateGroups(_333mbf-r1-a1, 1, LONG_ROOM, 2025-07-03T13:15, 2025-07-03T14:30, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, LONG_ROOM, 2025-07-05T13:15, 2025-07-05T14:30, useStageName=false)
CreateGroups(_333fm-r1-a1, 1, LONG_ROOM, 2025-07-03T15:15, 2025-07-03T16:30, useStageName=false)
CreateGroups(_333fm-r1-a2, 1, LONG_ROOM, 2025-07-04T15:15, 2025-07-04T16:30, useStageName=false)
CreateGroups(_333fm-r1-a3, 1, LONG_ROOM, 2025-07-05T15:15, 2025-07-05T16:30, useStageName=false)

# Thursday
Map(SideStages(), CreateGroups(_555bf-r1, 1, 2025-07-03T09:00, 2025-07-03T10:00))

Map(MainStages(), CreateGroups(_clock-r1, 6, 2025-07-03T09:30, 2025-07-03T11:00))
Map(SideStages(), CreateGroups(_clock-r1, 5, 2025-07-03T10:00, 2025-07-03T11:15))

Map(MainStages(), CreateGroups(_555-r1, 4, 2025-07-03T11:00, 2025-07-03T12:45))
Map(SideStages(), CreateGroups(_555-r1, 6, 2025-07-03T11:15, 2025-07-03T12:45,
                               extraMinutesByGroup=[Tuple(6, 10)]))

Map(MainStages(), CreateGroups(_333oh-r1, 8, 2025-07-03T13:45, 2025-07-03T15:45))
Map(SideStages(), CreateGroups(_333oh-r1, 8, 2025-07-03T13:45, 2025-07-03T15:45))

Map(MainStages(), CreateGroups(_pyram-r1, 7, 2025-07-03T15:45, 2025-07-03T17:15))
Map(SideStages(), CreateGroups(_pyram-r1, 11, 2025-07-03T15:45, 2025-07-03T18:00))

Map(MainStages(), CreateGroups(_clock-r2, 1, 2025-07-03T17:15, 2025-07-03T17:35))
Map(MainStages(), CreateGroups(_555-r2, 1, 2025-07-03T17:35, 2025-07-03T18:00))

# Friday
Map(MainStages(), CreateGroups(_777-r1, 2, 2025-07-04T09:00, 2025-07-04T09:50))
Map(SideStages(), CreateGroups(_777-r1, 4, 2025-07-04T09:00, 2025-07-04T10:00,
                               extraMinutesByGroup=[Tuple(4, 15)]))

Map(MainStages(), CreateGroups(_222-r1, 9, 2025-07-04T09:50, 2025-07-04T12:05))
Map(SideStages(), CreateGroups(_222-r1, 10, 2025-07-04T10:00, 2025-07-04T12:15))

Map(MainStages(), CreateGroups(_333oh-r2, 1, 2025-07-04T12:05, 2025-07-04T12:25))
Map(AllStages(), CreateGroups(_pyram-r2, 1, 2025-07-04T12:25, 2025-07-04T12:45))

Map(MainStages(), CreateGroups(_444-r1, 6, 2025-07-04T13:45, 2025-07-04T15:55))
Map(SideStages(), CreateGroups(_444-r1, 10, 2025-07-04T13:45, 2025-07-04T16:15,
                               extraMinutesByGroup=[Tuple(7, 10), Tuple(8, 10), Tuple(9, 10), Tuple(10, 10)]))

Map(MainStages(), CreateGroups(_minx-r1, 4, 2025-07-04T15:55, 2025-07-04T17:15))
Map(SideStages(), CreateGroups(_minx-r1, 5, 2025-07-04T16:15, 2025-07-04T17:15,
                               extraMinutesByGroup=[Tuple(5, 10)]))

Map(FinalsStages(), CreateGroups(_555-r3, 1, 2025-07-04T17:30, 2025-07-04T17:50))
Map(FinalsStages(), CreateGroups(_clock-r3, 1, 2025-07-04T17:50, 2025-07-04T18:10))
Map(FinalsStages(), CreateGroups(_pyram-r3, 1, 2025-07-04T18:10, 2025-07-04T18:30))
Map(FinalsStages(), CreateGroups(_333oh-r3, 1, 2025-07-04T18:30, 2025-07-04T18:50))

# Saturday
Map(MainStages(), CreateGroups(_333bf-r1, 2, 2025-07-05T09:00, 2025-07-05T09:40))
Map(SideStages(), CreateGroups(_333bf-r2, 4, 2025-07-05T09:00, 2025-07-05T10:20))

Map(MainStages(), CreateGroups(_skewb-r1, 8, 2025-07-05T09:40, 2025-07-05T11:25))
Map(SideStages(), CreateGroups(_skewb-r1, 10, 2025-07-05T10:20, 2025-07-05T12:20))

Map(MainStages(), CreateGroups(_777-r2, 1, 2025-07-05T11:25, 2025-07-05T11:45))
Map(MainStages(), CreateGroups(_minx-r2, 1, 2025-07-05T11:45, 2025-07-05T12:05))
Map(MainStages(), CreateGroups(_444-r2, 1, 2025-07-05T12:05, 2025-07-05T12:25))
Map(AllStages(), CreateGroups(_pyram-r2, 1, 2025-07-05T12:25, 2025-07-05T12:45))

Map(AllStages(), CreateGroups(_333-r1, 10, 2025-07-05T13:45, 2025-07-05T16:15))
Map(MainStages(), CreateGroups(_666-r1, 3, 2025-07-05T16:15, 2025-07-05T17:15))
Map(SideStages(), CreateGroups(_666-r1, 4, 2025-07-05T16:15, 2025-07-05T17:15,
                               extraMinutesByGroup=[Tuple(4, 10)]))

Map(FinalsStages(), CreateGroups(_444-r3, 1, 2025-07-05T17:30, 2025-07-05T17:50))
Map(FinalsStages(), CreateGroups(_minx-r3, 1, 2025-07-05T17:50, 2025-07-05T18:10))
Map(FinalsStages(), CreateGroups(_222-r3, 1, 2025-07-05T18:10, 2025-07-05T18:30))
Map(FinalsStages(), CreateGroups(_777-r3, 1, 2025-07-05T18:30, 2025-07-05T18:50))

# Sunday
Map(AllStages(), CreateGroups(_444bf-r1, 1, 2025-07-06T08:30, 2025-07-06T09:30))
Map(MainStages(), CreateGroups(_sq1-r1, 4, 2025-07-06T09:30, 2025-07-06T10:40))
Map(SideStages(), CreateGroups(_sq1-r1, 5, 2025-07-06T09:30, 2025-07-06T10:45,
                               extraMinutesByGroup=[Tuple(5, 5)]))
Map(MainStages(), CreateGroups(_333-r2, 3, 2025-07-06T10:40, 2025-07-06T11:30))
Map(SideStages(), CreateGroups(_333-r2, 5, 2025-07-06T10:45, 2025-07-06T12:00))

Map(MainStages(), CreateGroups(_666-r2, 1, 2025-07-06T11:30, 2025-07-06T11:50))
Map(MainStages(), CreateGroups(_333bf-r2, 1, 2025-07-06T11:50, 2025-07-06T12:10))
Map(AllStages(), CreateGroups(_skewb-r2, 1, 2025-07-06T12:10, 2025-07-06T12:30))
Map(MainStages(), CreateGroups(_sq1-r2, 1, 2025-07-06T12:30, 2025-07-06T12:50))

Map(MainStages(), CreateGroups(_333-r3, 1, 2025-07-06T13:50, 2025-07-06T14:30))

Map(FinalsStages(), CreateGroups(_skewb-r3, 1, 2025-07-06T14:40, 2025-07-06T15:00))
Map(FinalsStages(), CreateGroups(_666-r3, 1, 2025-07-06T15:00, 2025-07-06T15:20))
Map(FinalsStages(), CreateGroups(_sq1-r3, 1, 2025-07-06T15:20, 2025-07-06T15:40))
Map(FinalsStages(), CreateGroups(_333bf-r3, 1, 2025-07-06T15:40, 2025-07-06T16:00))

Map(FinalsStages(), CreateGroups(_333-r4, 8, 2025-07-06T16:15, 2025-07-06T17:45))

# Misc
CreateMiscActivity("Check-in opens", "other-checkin", LOBBY, 2025-07-03T08:00, 2025-07-03T09:00)
CreateMiscActivity("Check-in opens", "other-checkin", LOBBY, 2025-07-04T08:00, 2025-07-04T09:00)
CreateMiscActivity("Check-in opens", "other-checkin", LOBBY, 2025-07-05T08:00, 2025-07-05T09:00)
CreateMiscActivity("Check-in opens", "other-checkin", LOBBY, 2025-07-06T08:00, 2025-07-06T09:00)
CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2025-07-03T12:45, 2025-07-03T13:45)
CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2025-07-04T12:45, 2025-07-04T13:45)
CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2025-07-05T12:45, 2025-07-05T13:45)
CreateMiscActivity("Lunch", "other-lunch", MAIN_HALL, 2025-07-06T12:50, 2025-07-06T13:50)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind", "other-multi", LONG_ROOM, 2025-07-03T08:45, 2025-07-03T10:00)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind", "other-multi", LONG_ROOM, 2025-07-05T08:45, 2025-07-05T10:00)
CreateMiscActivity("Opening Ceremony", "other-misc", MAIN_HALL, 2025-07-03T18:00, 2025-07-03T19:00)
CreateMiscActivity("Rubik's Nations Cup", "other-misc", MAIN_HALL, 2025-07-03T19:00, 2025-07-03T20:30)
CreateMiscActivity("Awards", "other-awards", MAIN_HALL, 2025-07-06T18:00, 2025-07-06T19:00)
