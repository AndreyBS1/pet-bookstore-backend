using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PetBookstore.Migrations
{
  /// <inheritdoc />
  public partial class AddGenres : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Genres",
          columns: table => new
          {
            ID = table.Column<int>(type: "integer", nullable: false)
                  .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            Label = table.Column<string>(type: "text", nullable: false),
            BookID = table.Column<int>(type: "integer", nullable: true),
            CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Genres", x => x.ID);
            table.ForeignKey(
                      name: "FK_Genres_Books_BookID",
                      column: x => x.BookID,
                      principalTable: "Books",
                      principalColumn: "ID");
          });

      migrationBuilder.CreateIndex(
          name: "IX_Genres_BookID",
          table: "Genres",
          column: "BookID");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Genres");
    }
  }
}
