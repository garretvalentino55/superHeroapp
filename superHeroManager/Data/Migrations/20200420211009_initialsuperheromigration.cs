using Microsoft.EntityFrameworkCore.Migrations;


namespace superHeroManager.Data.Migrations
{
    public partial class initialsuperheromigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superHero",
                columns: table => new
                {
                    superHeroName = table.Column<string>(nullable: false),
                    alterEgo = table.Column<string>(nullable: true),
                    primaryAbility = table.Column<string>(nullable: true),
                    secondaryAbility = table.Column<string>(nullable: true),
                    catchPhrase = table.Column<string>(nullable: true),
                    superHeroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superHero", x => x.superHeroName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superHero");
        }
    }
}
