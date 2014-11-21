namespace MilkShakes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Milkshakes",
                c => new
                    {
                        MilkShakeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MilkShakeID);
            
            CreateTable(
                "dbo.Milk",
                c => new
                    {
                        MilkID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MilkID);
            
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        FruitID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FruitID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fruits");
            DropTable("dbo.Milk");
            DropTable("dbo.Milkshakes");
        }
    }
}
