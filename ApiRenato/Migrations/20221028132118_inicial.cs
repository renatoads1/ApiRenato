using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRenato.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "Senha", "Sobrenome", "Usuario" },
                values: new object[] { 1, "Renato", "r3n4t0321", "Azevedo", "renatoads1" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "Senha", "Sobrenome", "Usuario" },
                values: new object[] { 2, "Isabela", "r3n4t0321", "Lacerda", "isabela321" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome", "Senha", "Sobrenome", "Usuario" },
                values: new object[] { 3, "Julia", "r3n4t0321", "Lacerda", "julia321" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
