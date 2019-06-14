using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamesAmos.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyPrayer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Verse = table.Column<string>(nullable: true),
                    Book = table.Column<string>(nullable: true),
                    Chapter = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPrayer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HeaderImageUrl = table.Column<string>(nullable: true),
                    HeaderTitle = table.Column<string>(nullable: true),
                    HeaderSubTitle = table.Column<string>(nullable: true),
                    WhyTitle1 = table.Column<string>(nullable: true),
                    WhyText1 = table.Column<string>(nullable: true),
                    CardOneImageUrl = table.Column<string>(nullable: true),
                    CardOneTitle = table.Column<string>(nullable: true),
                    CardOneText = table.Column<string>(nullable: true),
                    CardTwoImageUrl = table.Column<string>(nullable: true),
                    CardThreeImageUrl = table.Column<string>(nullable: true),
                    CardThreeTitle = table.Column<string>(nullable: true),
                    CardThreeText = table.Column<string>(nullable: true),
                    CommitmentHeader = table.Column<string>(nullable: true),
                    CommitTitle1 = table.Column<string>(nullable: true),
                    CommitText1 = table.Column<string>(nullable: true),
                    CommitTitle2 = table.Column<string>(nullable: true),
                    CommitText2 = table.Column<string>(nullable: true),
                    CommitTitle3 = table.Column<string>(nullable: true),
                    CommitText3 = table.Column<string>(nullable: true),
                    DailyVerseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HomePage_DailyPrayer_DailyVerseID",
                        column: x => x.DailyVerseID,
                        principalTable: "DailyPrayer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_DailyVerseID",
                table: "HomePage",
                column: "DailyVerseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePage");

            migrationBuilder.DropTable(
                name: "DailyPrayer");
        }
    }
}
