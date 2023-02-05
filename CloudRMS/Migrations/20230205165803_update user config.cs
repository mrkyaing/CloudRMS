using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudRMS.Migrations
{
    public partial class updateuserconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a1d3be57-d906-479c-813d-702d45116266");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d8f01441-647b-434e-a3e7-ba955299f79e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "45c7d0c0-b8dd-4f11-a5e4-7177394bff65");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "52655b31-1fa1-4cad-9b8a-b3b1bc704a32");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac61139a-6399-49bf-ac65-413f977e15f0", "33bb3989-35c9-4e01-9ab4-9b9885326911", "Visitor", "VISITOR" },
                    { "f03555f8-8cfe-4473-a729-f7107995979d", "185596e2-af87-4fac-866a-a90802cf36ce", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "510bb7ba-d915-4416-a418-a61646c66680", 0, "1011eb6b-2477-4862-92a9-db32083a22b0", null, false, "Mg", "Kyaing", false, null, null, null, "admin", null, false, "62b77539-d5a3-467e-b521-cecefbd0b645", false, null },
                    { "3311ce0d-ff28-402c-ae8f-6ff251731093", 0, "9168fc6f-1d38-48bf-8de5-fbf5a384b0bd", null, false, "Saw ", "Yu Nandar", false, null, null, null, null, null, false, "8b446015-7880-4041-b1f6-09a357c1c959", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ac61139a-6399-49bf-ac65-413f977e15f0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f03555f8-8cfe-4473-a729-f7107995979d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3311ce0d-ff28-402c-ae8f-6ff251731093");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "510bb7ba-d915-4416-a418-a61646c66680");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1d3be57-d906-479c-813d-702d45116266", "b66cc4f7-279a-4188-bf38-9a676f9e4f1f", "Visitor", "VISITOR" },
                    { "d8f01441-647b-434e-a3e7-ba955299f79e", "06b0553a-cb33-46c1-801f-2969fd6446fb", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45c7d0c0-b8dd-4f11-a5e4-7177394bff65", 0, "575a80d3-dd84-4c88-8678-c354dc0fcce6", null, false, "Mg", "Kyaing", false, null, null, null, null, null, false, "8619d980-70e8-41ff-95c9-a6df369f4d0f", false, null },
                    { "52655b31-1fa1-4cad-9b8a-b3b1bc704a32", 0, "4b68e22e-c1cd-4ded-be68-7a8bce4f67f3", null, false, "Saw ", "Yu Nandar", false, null, null, null, null, null, false, "9fd457cb-9e1d-4bc6-8589-7ddfbc8c843c", false, null }
                });
        }
    }
}
