using AutoMapper;
using HR.LeaveManagament.MVC.Models;
using HR.LeaveManagement.MVC.Services.Base;

namespace HR.LeaveManagament.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<CreateLeaveTypeDto, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
            CreateMap<CreateLeaveTypeVM, CreateLeaveTypeDto>().ReverseMap();
            
        }
    }
}
