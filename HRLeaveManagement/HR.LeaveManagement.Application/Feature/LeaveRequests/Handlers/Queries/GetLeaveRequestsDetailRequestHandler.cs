using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Feature.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Feature.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestsDetailRequestHandler : IRequestHandler<GetLeaveRequestsDetailRequest, LeaveRequestDto>
    {

        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestsDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;

        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestsDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.getLeaveRequestWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}


//IRequestHandler<GetLeaveRequestsDetailRequest, LeaveRequestDto>