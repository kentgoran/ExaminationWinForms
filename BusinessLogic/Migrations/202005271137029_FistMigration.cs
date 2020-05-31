namespace BusinessLogic2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FistMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Ssn = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Seat = c.Int(nullable: false),
                        Wheelchair = c.Boolean(nullable: false),
                        Customer_CustomerId = c.Int(),
                        Show_ShowId = c.Int(),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Shows", t => t.Show_ShowId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Show_ShowId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        GotWheelchairRamp = c.Boolean(nullable: false),
                        Movie_MovieId = c.Int(),
                    })
                .PrimaryKey(t => t.ShowId)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId)
                .Index(t => t.Movie_MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Info = c.String(),
                        PicturePath = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Show_ShowId", "dbo.Shows");
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            DropIndex("dbo.Tickets", new[] { "Show_ShowId" });
            DropIndex("dbo.Tickets", new[] { "Customer_CustomerId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Shows");
            DropTable("dbo.Tickets");
            DropTable("dbo.Customers");
        }
    }
}
