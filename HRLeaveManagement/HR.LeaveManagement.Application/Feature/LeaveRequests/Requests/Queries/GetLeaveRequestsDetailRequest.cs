using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Feature.LeaveRequests.Requests.Queries
{
    public  class GetLeaveRequestsDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
