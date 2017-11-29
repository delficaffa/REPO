namespace CreandoUnaBaseDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Supervisor", c => c.String());
            AddColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Salary");
            DropColumn("dbo.Employees", "Supervisor");
        }
    }
}
