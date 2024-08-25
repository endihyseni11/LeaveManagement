using AutoMapper;
using HR.LeaveManagament.MVC.Contracts;
using HR.LeaveManagament.MVC.Models;
using HR.LeaveManagament.MVC.Services.Base;
using HR.LeaveManagement.MVC.Services.Base;

namespace HR.LeaveManagament.MVC.Services
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {

        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpClient;

        public LeaveTypeService(IMapper mapper, ILocalStorageService localStorageService, IClient httpclient) 
            : base(httpclient, localStorageService)
        {
            _client = httpclient;
            _mapper = mapper;
            _localStorageService = localStorageService;
        }

        public async Task<Response<int>> CreateLeaveType(CreateLeaveTypeVM leaveType)
        {
            try
            {
                var response = new Response<int>();
                CreateLeaveTypeDto leaveTypeDto = _mapper.Map<CreateLeaveTypeDto>(leaveType);
                var apiResponse  = await _client.LeaveTypesPOSTAsync(leaveTypeDto);

                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach(var error in apiResponse.Errors)
                    {
                        response.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException ex) { 
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteLeaveType(int id)
        {
            try
            {
                await _client.LeaveTypesDELETEAsync(id);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<LeaveTypeVM> GetLeaveTypeDetails(int id)
        {
            var leaveType = await _client.LeaveTypesGETAsync(id);
            return _mapper.Map<LeaveTypeVM>(leaveType);
        }

        public async Task<List<LeaveTypeVM>> GetLeaveTypes()
        {
            CancellationToken cancellationToken = CancellationToken.None;
            var leaveTypes = await _client.LeaveTypesAllAsync();
            
            return _mapper.Map<List<LeaveTypeVM>>(leaveTypes);  
        }

        public async Task<Response<int>> UpdateLeaveType(int id, LeaveTypeVM leaveType)
        {
            LeaveTypeDto leaveTypeDto = _mapper.Map<LeaveTypeDto>(leaveType);
            await _client.LeaveTypesPUTAsync(id, leaveTypeDto);
            return new Response<int>() { Success = true }; 
        }
    }
}
