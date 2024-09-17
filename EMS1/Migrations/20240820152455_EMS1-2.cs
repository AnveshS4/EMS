using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS1.Migrations
{
    /// <inheritdoc />
    public partial class EMS12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Department", "Name" },
                values: new object[] { "dvs", "A" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Department", "Name" },
                values: new object[] { "csg", "B" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Department", "Name" },
                values: new object[] { "jhdg", "C" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Department", "Name" },
                values: new object[] { "1", "Action" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Department", "Name" },
                values: new object[] { "2", "Action" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Department", "Name" },
                values: new object[] { "3", "Action" });
        }
    }
}
