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
    public class ExpenseConfiguration: IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(new Expense
            {
                ExpenseId = 1,
                Amount = 1411800,
                Date = DateTime.Now,
                Description = "Кредит",
                CategoryId = 4,
                UserId = 1,

            },new Expense
            {
                ExpenseId = 2,
                Amount = 700000,
                Date = DateTime.Now,
                Description = "Маме",
                CategoryId = 3,
                UserId = 1,
            }, new Expense
            {
                ExpenseId = 3,
                Amount = 200000,
                Date = DateTime.Now,
                Description = "Папе",
                CategoryId = 2,
                UserId = 1,
            });
        }
    }
}
