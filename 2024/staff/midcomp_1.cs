#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_minx-r2, 2024-07-18,
                   [Judges(), Scramblers(4, _minx), Runners(3, _minx), Delegate()],
                   StaffScorers(_minx, 2024-07-18))
DoStaffAssignments(_sq1-r2, 2024-07-18,
                   [Judges(), Scramblers(3, _sq1), Runners(4, _sq1), Delegate()],
                   StaffScorers(_sq1, 2024-07-18))
DoStaffAssignments(_555-r2, 2024-07-18,
                   [Judges(), Scramblers(4, _555), Runners(3, _555), Delegate()],
                   StaffScorers(_555, 2024-07-18))
