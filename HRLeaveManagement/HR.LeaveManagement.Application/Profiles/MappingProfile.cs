﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<CreateLeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<CreateLeaveRequestDto, LeaveRequest>().ReverseMap();
            CreateMap<CreateLeaveAllocationDto, LeaveAllocation>().ReverseMap();
            CreateMap<UpdateLeaveAllocationDto, LeaveAllocation>().ReverseMap();
            CreateMap<UpdateLeaveRequestDto, LeaveRequest>().ReverseMap();
            //CreateMap<CreateLeaveTypeDto, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();

        }
    }
}
