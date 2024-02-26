using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicResume.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialLinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalStatement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopmentProjects_Resumes_ResumeDataId",
                        column: x => x.ResumeDataId,
                        principalTable: "Resumes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Establishment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attended = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AwardedGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelevantCourses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EduInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Resumes_ResumeDataId",
                        column: x => x.ResumeDataId,
                        principalTable: "Resumes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmploymentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentHistory_Resumes_ResumeDataId",
                        column: x => x.ResumeDataId,
                        principalTable: "Resumes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentProjects_ResumeDataId",
                table: "DevelopmentProjects",
                column: "ResumeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_ResumeDataId",
                table: "Education",
                column: "ResumeDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistory_ResumeDataId",
                table: "EmploymentHistory",
                column: "ResumeDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevelopmentProjects");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EmploymentHistory");

            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
