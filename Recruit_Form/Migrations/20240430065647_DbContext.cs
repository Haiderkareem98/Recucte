using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruit_Form.Migrations
{
    /// <inheritdoc />
    public partial class DbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerInform",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fourth_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevel = table.Column<int>(type: "int", nullable: false),
                    ScientificSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conservation = table.Column<int>(type: "int", nullable: false),
                    BirthYaer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    IdentifieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentifieWorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sessions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkplacesExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFamiliesMartyrsAndWounded = table.Column<bool>(type: "bit", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    Appearance = table.Column<int>(type: "int", nullable: false),
                    doctrinal_Information = table.Column<int>(type: "int", nullable: false),
                    SkilledInDriving = table.Column<int>(type: "int", nullable: false),
                    ComputerSkills = table.Column<int>(type: "int", nullable: false),
                    technical_Information = table.Column<int>(type: "int", nullable: false),
                    ProposedAddition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunityCovenant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeOfConfrontation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerInform", x => x.PersonalInformationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerInform");
        }
    }
}
