using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalInvest.FundingPlatform.Migrations
{
    public partial class CreateDbAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fundings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Target = table.Column<double>(nullable: false),
                    Investment = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fundings", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fundings");
        }
    }
}
