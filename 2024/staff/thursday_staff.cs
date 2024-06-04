#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_minx-r1, 2024-07-18,
                   [Judges(), Scramblers(4, _minx), Runners(3, _minx), Delegate()],
                   StaffScorers(_minx))
DoStaffAssignments(_sq1-r1, 2024-07-18,
                   [Judges(), Scramblers(3, _sq1), Runners(4, _sq1), Delegate()],
                   StaffScorers(_sq1))
DoStaffAssignments(_555-r1, 2024-07-18,
                   [Judges(), Scramblers(3, _555), Runners(4, _555), Delegate()],
                   StaffScorers(_555))
DoStaffAssignments(_clock-r1, 2024-07-18,
                   [Judges(), Scramblers(3, _clock), Runners(4, _clock), Delegate()],
                   StaffScorers(_clock))
DoStaffAssignments(_666-r1, 2024-07-18,
                   [Judges(), Scramblers(4, _666), Runners(3, _666), Delegate()],
                   StaffScorers(_666))
