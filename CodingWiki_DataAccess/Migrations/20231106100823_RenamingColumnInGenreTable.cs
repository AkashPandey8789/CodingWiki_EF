using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamingColumnInGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Display",
                table: "Genres",
                newName: "DisplayOrder");
            //if we apply current migration to db all the records for Display column will be deleted(in older EF5)
            //Now EF is renaming and thus the data will not be deleted.
            //migrationBuilder.Sql("UPDATE dbo.genres set Display=DisplayOrder"); like this we can run sql in migration.
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Genres",
                newName: "Display");
        }
    }
}
