//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "5148ac31-4618-4531-acbc-4f82f54be3ff",
                    UserId = "7ecdb327-a498-4935-aa63-3ef59fc3954b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "c508e904-5b5f-4d3a-89c8-0f049d14fdac",
                    UserId = "82aaf256-3710-4609-bf94-9c537732ce1d"
                }
                );
        }

       
    }
}
