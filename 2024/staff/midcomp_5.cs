#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_clock-r3, 2024-07-21,
                   [Judges(), Scramblers(4, _clock), Runners(4, _clock), Delegate()],
                   StaffScorers(_clock, 2024-07-21))
DoStaffAssignments(_555-r3, 2024-07-21,
                   [Judges(), Scramblers(4, _555), Runners(3, _555), Delegate()],
                   StaffScorers(_555, 2024-07-21))
DoStaffAssignments(_pyram-r3, 2024-07-21,
                   [Judges(), Scramblers(3, _pyram), Runners(4, _pyram), Delegate()],
                   StaffScorers(_pyram, 2024-07-21))
DoStaffAssignments(_444-r3, 2024-07-21,
                   [Judges(), Scramblers(4, _444), Runners(3, _444), Delegate()],
                   StaffScorers(_444, 2024-07-21))
DoStaffAssignments(_skewb-r3, 2024-07-21,
                   [Judges(), Scramblers(3, _skewb), Runners(4, _skewb), Delegate()],
                   StaffScorers(_skewb, 2024-07-21))
DoStaffAssignments(_333oh-r3, 2024-07-21,
                   [Judges(), Scramblers(3, _333oh), Runners(4, _333oh), Delegate()],
                   StaffScorers(_333oh, 2024-07-21))
DoStaffAssignments(_222-r4, 2024-07-21,
                   [Judges(), Scramblers(3, _222), Runners(4, _222), Delegate()],
                   StaffScorers(_222, 2024-07-21))
DoStaffAssignments(_333bf-r3, 2024-07-21,
                   [Judges(), Scramblers(2, _333bf), Runners(3, _333bf), Delegate()],
                   StaffScorers(_333bf, 2024-07-21))
