namespace BusinessLogic2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieIdToShows : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            RenameColumn(table: "dbo.Shows", name: "Movie_MovieId", newName: "MovieId");
            AlterColumn("dbo.Shows", "MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shows", "MovieId");
            AddForeignKey("dbo.Shows", "MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "MovieId" });
            AlterColumn("dbo.Shows", "MovieId", c => c.Int());
            RenameColumn(table: "dbo.Shows", name: "MovieId", newName: "Movie_MovieId");
            CreateIndex("dbo.Shows", "Movie_MovieId");
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId");
        }
    }
}
