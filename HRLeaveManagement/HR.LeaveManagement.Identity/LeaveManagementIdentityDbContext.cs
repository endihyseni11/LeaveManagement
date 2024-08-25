﻿using HR.LeaveManagement.Identity.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HR.LeaveManagement.Identity.Configurations;

namespace HR.LeaveManagement.Identity
{
    public class LeaveManagementIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public LeaveManagementIdentityDbContext(DbContextOptions<LeaveManagementIdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
