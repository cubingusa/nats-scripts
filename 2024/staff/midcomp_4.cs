#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_skewb-r2, 2024-07-21,
                   [Judges(), Scramblers(3, _skewb), Runners(4, _skewb), Delegate()],
                   StaffScorers(_skewb, 2024-07-21))
DoStaffAssignments(_333-r3, 2024-07-21,
                   [Judges(), Scramblers(3, _333), Runners(4, _333), Delegate()],
                   StaffScorers(_333, 2024-07-21))
DoStaffAssignments(_222-r3, 2024-07-21,
                   [Judges(), Scramblers(3, _222), Runners(4, _222), Delegate()],
                   StaffScorers(_222, 2024-07-21))
