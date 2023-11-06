using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NoChange : Migration
    {
        /// <inheritdoc />
        //Empty migration will be created if no changes are done and migration is tried to be created.
        //Scenarios when migration needs to be created.
        /*
         1.Add a new class /table in the database.
         2. Add a new property/column to table.
         3. Modify existing property/column in table.
         4. Delete existing property/column in table.
         
         
         */
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
