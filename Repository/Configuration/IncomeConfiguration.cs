using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class IncomeConfiguration: IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasData(new Income
            {
                IncomeId = 1,
                Amount = 5000000,
                Date = DateTime.Now,
                Description = "Зарплата с работы 5 млн сум",
                UserId = 1,
                CategoryId = 1
            }, new Income
            {
                IncomeId = 2,
                Amount = 19000000,
                Date = DateTime.Now,
                Description = "Зарплата с работы 19 млн сум",
                UserId = 2,
                CategoryId = 1
            });
        }
    }
}
