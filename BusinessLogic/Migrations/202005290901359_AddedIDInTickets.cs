namespace BusinessLogic2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIDInTickets : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Tickets", "Show_ShowId", "dbo.Shows");
            DropIndex("dbo.Tickets", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Tickets", new[] { "Show_ShowId" });
            RenameColumn(table: "dbo.Tickets", name: "Customer_CustomerId", newName: "CustomerId");
            RenameColumn(table: "dbo.Tickets", name: "Show_ShowId", newName: "ShowId");
            AlterColumn("dbo.Tickets", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "ShowId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "ShowId");
            CreateIndex("dbo.Tickets", "CustomerId");
            AddForeignKey("dbo.Tickets", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "ShowId", "dbo.Shows", "ShowId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.Tickets", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Tickets", new[] { "CustomerId" });
            DropIndex("dbo.Tickets", new[] { "ShowId" });
            AlterColumn("dbo.Tickets", "ShowId", c => c.Int());
            AlterColumn("dbo.Tickets", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Tickets", name: "ShowId", newName: "Show_ShowId");
            RenameColumn(table: "dbo.Tickets", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Tickets", "Show_ShowId");
            CreateIndex("dbo.Tickets", "Customer_CustomerId");
            AddForeignKey("dbo.Tickets", "Show_ShowId", "dbo.Shows", "ShowId");
            AddForeignKey("dbo.Tickets", "Customer_CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
