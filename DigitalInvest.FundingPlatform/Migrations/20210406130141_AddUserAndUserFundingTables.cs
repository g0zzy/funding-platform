using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalInvest.FundingPlatform.Migrations
{
    public partial class AddUserAndUserFundingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("11cbf0c7-e2cb-4bcd-9e3a-7a79a139e2ec"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("31e31705-a939-4469-ae7e-34f0e085a64a"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("635141f1-dd57-4c05-a91b-78edc2c96a53"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("691e9bf2-9e22-436b-b48c-f25bcbdca3d1"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("7ed0bc0b-3b5f-4105-b71d-46d115782023"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("8514bc6c-75dc-4169-a12c-6778edb0ec64"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("9b416e32-06c3-43c8-b70c-d9afd91bdf9c"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("b4892525-4bbb-4a8a-8895-0f5e012d6829"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("c10d4c86-c332-4db2-bcdd-9cc7f75fd143"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("c92b8fc3-4205-47ea-9ffb-941752a8d50d"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("cae5b156-19ee-4a0c-a154-1ceef75ff1e7"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("cfe7745d-fa31-4720-9b90-d3d27c89513d"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("e9bb08ec-4048-42ae-8038-7fd10f962909"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("fe23d2c3-0edf-4b10-8af8-e2459484f100"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFundings",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    FundingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFundings", x => new { x.FundingId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserFundings_Fundings_FundingId",
                        column: x => x.FundingId,
                        principalTable: "Fundings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFundings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fundings",
                columns: new[] { "Id", "CreatedOn", "ExpirationDate", "Investment", "Name", "Target" },
                values: new object[,]
                {
                    { new Guid("1a21525c-82ff-4f35-8454-721536faad8d"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 2, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 1", 945985.0 },
                    { new Guid("c85ebf69-0027-4b58-8860-6acab9c10e69"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 4, 28, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 2", 907841.0 },
                    { new Guid("82f91880-36c3-4497-861c-f03049b1eabd"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 12, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 3", 950173.0 },
                    { new Guid("5bca3eba-41f2-452c-8bd4-f529d5dbc6df"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 10, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 4", 978610.0 },
                    { new Guid("373c3bdb-d801-498b-8b18-f3bad23c89b2"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 5", 999466.0 },
                    { new Guid("90e0d05b-4dfe-4110-ba50-979f1a0990e5"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 1, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 6", 838081.0 },
                    { new Guid("f061b128-0ccd-4d3f-aa56-386b042a36c5"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 4, 29, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 7", 627099.0 },
                    { new Guid("ee3ebda2-06a6-43b9-a0f9-c30ab8ae82df"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 7, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 8", 981597.0 },
                    { new Guid("e050eddb-c19f-4322-9c44-fe399a4588cb"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 4, 29, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 9", 885480.0 },
                    { new Guid("4f2a1f46-e471-49d2-9e5c-1ec995a6e4ce"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 9, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 10", 808577.0 },
                    { new Guid("9c9f3618-2a50-4bbb-8e2b-c014dbb960ac"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 4, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 11", 614505.0 },
                    { new Guid("214ec603-f538-4153-a1bb-1744068cbb6b"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 12, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 12", 897899.0 },
                    { new Guid("2f7a7fd7-6b46-4bbb-a2fc-f88eda0fef8b"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 4, 27, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 13", 628771.0 },
                    { new Guid("f6323637-4de4-4778-90c8-8ec70a3f9260"), new DateTime(2021, 4, 6, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), new DateTime(2021, 5, 1, 13, 1, 40, 80, DateTimeKind.Utc).AddTicks(6032), 0.0, "Property 14", 624257.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFundings_UserId",
                table: "UserFundings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFundings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("1a21525c-82ff-4f35-8454-721536faad8d"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("214ec603-f538-4153-a1bb-1744068cbb6b"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("2f7a7fd7-6b46-4bbb-a2fc-f88eda0fef8b"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("373c3bdb-d801-498b-8b18-f3bad23c89b2"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("4f2a1f46-e471-49d2-9e5c-1ec995a6e4ce"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("5bca3eba-41f2-452c-8bd4-f529d5dbc6df"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("82f91880-36c3-4497-861c-f03049b1eabd"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("90e0d05b-4dfe-4110-ba50-979f1a0990e5"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("9c9f3618-2a50-4bbb-8e2b-c014dbb960ac"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("c85ebf69-0027-4b58-8860-6acab9c10e69"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("e050eddb-c19f-4322-9c44-fe399a4588cb"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("ee3ebda2-06a6-43b9-a0f9-c30ab8ae82df"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("f061b128-0ccd-4d3f-aa56-386b042a36c5"));

            migrationBuilder.DeleteData(
                table: "Fundings",
                keyColumn: "Id",
                keyValue: new Guid("f6323637-4de4-4778-90c8-8ec70a3f9260"));

            migrationBuilder.InsertData(
                table: "Fundings",
                columns: new[] { "Id", "CreatedOn", "ExpirationDate", "Investment", "Name", "Target" },
                values: new object[,]
                {
                    { new Guid("e9bb08ec-4048-42ae-8038-7fd10f962909"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 1", 710867.0 },
                    { new Guid("635141f1-dd57-4c05-a91b-78edc2c96a53"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 30, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 2", 512358.0 },
                    { new Guid("cae5b156-19ee-4a0c-a154-1ceef75ff1e7"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 24, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 3", 699383.0 },
                    { new Guid("b4892525-4bbb-4a8a-8895-0f5e012d6829"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 26, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 4", 614863.0 },
                    { new Guid("7ed0bc0b-3b5f-4105-b71d-46d115782023"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 6, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 5", 835391.0 },
                    { new Guid("9b416e32-06c3-43c8-b70c-d9afd91bdf9c"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 9, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 6", 554932.0 },
                    { new Guid("11cbf0c7-e2cb-4bcd-9e3a-7a79a139e2ec"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 7", 947473.0 },
                    { new Guid("cfe7745d-fa31-4720-9b90-d3d27c89513d"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 8", 765839.0 },
                    { new Guid("c10d4c86-c332-4db2-bcdd-9cc7f75fd143"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 29, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 9", 795119.0 },
                    { new Guid("691e9bf2-9e22-436b-b48c-f25bcbdca3d1"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 26, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 10", 716728.0 },
                    { new Guid("31e31705-a939-4469-ae7e-34f0e085a64a"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 29, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 11", 750120.0 },
                    { new Guid("fe23d2c3-0edf-4b10-8af8-e2459484f100"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 25, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 12", 699202.0 },
                    { new Guid("8514bc6c-75dc-4169-a12c-6778edb0ec64"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 5, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 13", 646972.0 },
                    { new Guid("c92b8fc3-4205-47ea-9ffb-941752a8d50d"), new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 4, 27, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315), 0.0, "Property 14", 841235.0 }
                });
        }
    }
}
