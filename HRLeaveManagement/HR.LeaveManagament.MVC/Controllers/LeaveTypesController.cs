using HR.LeaveManagament.MVC.Contracts;
using HR.LeaveManagament.MVC.Models;
using HR.LeaveManagement.MVC.Services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR.LeaveManagament.MVC.Controllers
{
    
    
    public class LeaveTypesController : Controller
    {
        // GET: LeaveTypesController

        private readonly ILeaveTypeService _leaveTypeRepository;

        public LeaveTypesController(ILeaveTypeService leaveTypeService)
        {
            _leaveTypeRepository = leaveTypeService;
        }

        
        public async Task<ActionResult> Index()
        {
            var model = await _leaveTypeRepository.GetLeaveTypes();
            return View(model);
        }

        // GET: LeaveTypesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _leaveTypeRepository.GetLeaveTypeDetails(id);
            return View(model);
        }

        // GET: LeaveTypesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateLeaveTypeVM leaveTypeVM)
        {
            try
            {
                var response = await _leaveTypeRepository.CreateLeaveType(leaveTypeVM);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: LeaveTypesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _leaveTypeRepository.GetLeaveTypeDetails(id); 
            return View(model);
        }

        // POST: LeaveTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, LeaveTypeVM leaveType) 
        {
            try
            {
                var response = await _leaveTypeRepository.UpdateLeaveType(id, leaveType);
                if (response.Success) {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                
            }
            return View(leaveType);
        }

        // GET: LeaveTypesController/Delete/5
       

        // POST: LeaveTypesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _leaveTypeRepository.DeleteLeaveType(id);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return BadRequest();    
        }
    }
}
