﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {

        private readonly LeaveManagementDbContext _context;

        public LeaveTypeRepository(LeaveManagementDbContext context) : base(context) 
            {
                _context = context;
            }
        }
    }

