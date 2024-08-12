using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinanceControl.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Заработная плата с работы", "Salary", 1 },
                    { 2, "Из зарплаты отдать папе", "Give Money to Dad", 2 },
                    { 3, "Из зарплаты отдать маме", "Give Money to mom", 2 },
                    { 4, "Кредит", "Credit", 2 },
                    { 5, "Фриланс", "Freelance", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateRegister", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(5943), "P_Test", "U_Test" },
                    { 2, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(5952), "P_Vata", "Vata" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "CategoryId", "Date", "Description", "UserId" },
                values: new object[,]
                {
                    { 1, 1411800m, 4, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(6090), "Кредит", 1 },
                    { 2, 700000m, 3, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(6092), "Маме", 1 },
                    { 3, 200000m, 2, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(6093), "Папе", 1 }
                });

            migrationBuilder.InsertData(
                table: "Incomes",
                columns: new[] { "IncomeId", "Amount", "CategoryId", "Date", "Description", "UserId" },
                values: new object[,]
                {
                    { 1, 5000000m, 1, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(6052), "Зарплата с работы 5 млн сум", 1 },
                    { 2, 19000000m, 1, new DateTime(2024, 8, 12, 5, 12, 9, 409, DateTimeKind.Local).AddTicks(6054), "Зарплата с работы 19 млн сум", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "IncomeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "IncomeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
