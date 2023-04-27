using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeveloperTicket",
                columns: table => new
                {
                    DevelopersId = table.Column<int>(type: "int", nullable: false),
                    TicketsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperTicket", x => new { x.DevelopersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Developers_DevelopersId",
                        column: x => x.DevelopersId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Diabetes" },
                    { 2, "Hypertension" },
                    { 3, "Asthma" },
                    { 4, "Depression" },
                    { 5, "Arthritis" },
                    { 6, "Allergy" },
                    { 7, "Flu" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Doaa" },
                    { 2, "Emy" },
                    { 3, "Rowan" },
                    { 4, "Miriam" },
                    { 5, "Yasmeen " },
                    { 6, "Rosy= 1 " },
                    { 7, "Andrew " },
                    { 8, "Ammar " },
                    { 9, "Tasha" },
                    { 10, "Max" },
                    { 11, "Bridge 2 " },
                    { 12, "Juan" },
                    { 13, "Krysta 10 " },
                    { 14, "Erma" },
                    { 15, "Orland 6 " },
                    { 16, "Leen " },
                    { 17, "Lama" },
                    { 18, "Joe" },
                    { 19, "Youmna8 " },
                    { 20, "Ola " },
                    { 21, "Sophy= 6 " },
                    { 22, "Erenie" },
                    { 23, "Bamba" },
                    { 24, "amal= 7 " },
                    { 25, "Gamal= 2 " },
                    { 26, "Jeje" },
                    { 27, "Michael= 6 " },
                    { 28, "Maggie " },
                    { 29, "Sally" },
                    { 30, "Karim" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "DepartmentId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Doaa", "Hematology" },
                    { 2, 2, "Doaa", "Hematology" },
                    { 3, 3, "Doaa", "Hematology" },
                    { 4, 4, "Doaa", "Hematology" },
                    { 5, 5, "Doaa", "Hematology" },
                    { 6, 6, "Doaa", "Hematology" },
                    { 7, 7, "Doaa", "Hematology" },
                    { 8, 5, "Doaa", "Hematology" },
                    { 9, 7, "Doaa", "Hematology" },
                    { 10, 3, "Doaa", "Hematology" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperTicket_TicketsId",
                table: "DeveloperTicket",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DepartmentId",
                table: "Tickets",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperTicket");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
