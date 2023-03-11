using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudRMS.Migrations
{
    public partial class NewDbMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2af5b904-f999-404e-8dae-a17643febc78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f8ffeb-1e69-4664-8498-99752bc90fe6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d8e2c88-0acf-4f26-ab6b-f1c193d5d7c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3006be-2a29-4eea-8805-ebf641615f76");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa6f6ab3-d476-4f64-9f1c-60081976e541", "a866c249-f512-4e7e-a0b9-29ca3bcb9ffb", "Visitor", "VISITOR" },
                    { "5e47121c-e5a1-4ab6-8b51-95dd818f7de6", "aca8e527-5fcb-4674-a285-ff1315cc21ce", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c3b0ee45-af49-4355-9c0c-5b8a54b3dbf2", 0, "cf71c609-c19d-42e5-9afa-de9248725d20", null, false, "Mg", "Kyaing", false, null, null, null, "admin", null, false, "ba4a4c31-60d6-4cc4-8f91-ed9a571647e7", false, null },
                    { "e3383e26-d296-4dd0-9ed7-e3be02190ead", 0, "abb4edd8-54fe-4763-8407-486e0477fea4", null, false, "Saw ", "Yu Nandar", false, null, null, null, null, null, false, "175c9657-348f-4058-897f-0d56650894da", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e47121c-e5a1-4ab6-8b51-95dd818f7de6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa6f6ab3-d476-4f64-9f1c-60081976e541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3b0ee45-af49-4355-9c0c-5b8a54b3dbf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3383e26-d296-4dd0-9ed7-e3be02190ead");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40f8ffeb-1e69-4664-8498-99752bc90fe6", "8241049b-f13c-4eed-9f2d-e0a9e10b6dfc", "Visitor", "VISITOR" },
                    { "2af5b904-f999-404e-8dae-a17643febc78", "ea508468-2e03-4295-80ce-edc9e597d8ff", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5d8e2c88-0acf-4f26-ab6b-f1c193d5d7c2", 0, "4eb7766c-7238-4d12-bb5e-20e3c29f6275", null, false, "Mg", "Kyaing", false, null, null, null, "admin", null, false, "00971fab-7896-4c33-8fe4-cbc759d5882f", false, null },
                    { "af3006be-2a29-4eea-8805-ebf641615f76", 0, "6eba844f-4b83-47d9-90e9-244d19a53e01", null, false, "Saw ", "Yu Nandar", false, null, null, null, null, null, false, "0e78bf64-bb69-4642-a757-5126aace2d2b", false, null }
                });
        }
    }
}
