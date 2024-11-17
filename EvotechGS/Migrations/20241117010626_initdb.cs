using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvotechGS.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_dispositivo",
                columns: table => new
                {
                    id_dispositivo = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_dispositivo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    potencia = table.Column<float>(type: "BINARY_FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dispositivo", x => x.id_dispositivo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_dispositivo");
        }
    }
}
