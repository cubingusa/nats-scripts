#include "_constants.cs"

Define("StaffingThursdayMulti", In(NumberProperty(LONG_ROOM_TEAM), [1, 2]))
Define("StaffingThursdayFMC", In(NumberProperty(LONG_ROOM_TEAM), [1]))
Define("StaffingFridayMulti", Or(In(NumberProperty(LONG_ROOM_TEAM), [1, 2]), (Name() == "James Hildreth")))
Define("StaffingFridayFMC", In(NumberProperty(LONG_ROOM_TEAM), [2]))
Define("StaffingSaturday5BLD", In(NumberProperty(LONG_ROOM_TEAM), [1, 2, 3]))
Define("StaffingSaturdayFMC", In(NumberProperty(LONG_ROOM_TEAM), [1]))
