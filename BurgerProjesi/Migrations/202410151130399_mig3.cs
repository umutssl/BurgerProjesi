namespace BurgerProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin1", "Name", c => c.String());
            AddColumn("dbo.Admin1", "Surname", c => c.String());
            AddColumn("dbo.Admin1", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admin1", "Email");
            DropColumn("dbo.Admin1", "Surname");
            DropColumn("dbo.Admin1", "Name");
        }
    }
}
