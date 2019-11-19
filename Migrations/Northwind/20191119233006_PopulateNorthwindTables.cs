using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Migrations.Northwind
{
    public partial class PopulateNorthwindTables : BaseMigration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            RunSql(migrationBuilder, $"Northwind_Populate-Categories.sql");
            RunSql(migrationBuilder, $"Northwind_Populate-Products.sql");
            RunSql(migrationBuilder, $"Northwind_Fix-Products.sql");
            RunSql(migrationBuilder, $"Northwind_Populate-Discounts.sql");
            RunSql(migrationBuilder, $"Northwind_Populate-Customers.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
