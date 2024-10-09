namespace BurgerProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin1",
                c => new
                    {
                        Admin1ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Admin1ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin1");
        }
    }
}
