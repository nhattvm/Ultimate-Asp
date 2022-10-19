using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations;

public partial class AddedRolesToDb : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.InsertData(
			table: "AspNetRoles",
			columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
			values: new object[] { "4ac8240a-8498-4869-bc86-60e5dc982d27", "f84dd4cd-0053-444a-85bf-c5bbf8672516", "Manager", "MANAGER" });

		migrationBuilder.InsertData(
			table: "AspNetRoles",
			columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
			values: new object[] { "562419f5-eed1-473b-bcc1-9f2dbab182b4", "5f3ffe4c-d566-49e4-9fc3-101836de5eeb", "Administrator", "ADMINISTRATOR" });
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DeleteData(
			table: "AspNetRoles",
			keyColumn: "Id",
			keyValue: "4ac8240a-8498-4869-bc86-60e5dc982d27");

		migrationBuilder.DeleteData(
			table: "AspNetRoles",
			keyColumn: "Id",
			keyValue: "562419f5-eed1-473b-bcc1-9f2dbab182b4");
	}
}
