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
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                CategoryId = 1,
                Description = "Заработная плата с работы",
                Name = "Salary",
                Type = 1
            },new Category
            {
                CategoryId = 2,
                Description = "Из зарплаты отдать папе",
                Name = "Give Money to Dad",
                Type = 2
            }, new Category
            {
                CategoryId = 3,
                Description = "Из зарплаты отдать маме",
                Name = "Give Money to mom",
                Type = 2
            }, new Category
            {
                CategoryId = 4,
                Description = "Кредит",
                Name = "Credit",
                Type = 2
            }, new Category
            {
                CategoryId = 5,
                Description = "Фриланс",
                Name = "Freelance",
                Type = 1
            });
        }
    }
}
