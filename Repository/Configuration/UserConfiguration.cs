using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                UserId = 1,
                DateRegister = DateTime.Now,
                UserName = "U_Test",
                Password = "P_Test"
            }, new User
            {
                UserId = 2,
                DateRegister = DateTime.Now,
                UserName = "Vata",
                Password = "P_Vata"
            });
        }
    }
}
