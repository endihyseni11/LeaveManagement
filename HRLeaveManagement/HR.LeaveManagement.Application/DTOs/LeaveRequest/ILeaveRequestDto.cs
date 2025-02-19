﻿using HR.LeaveManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public interface ILeaveRequestDto
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int  LeaveTypeId { get; set; }
    }
}
