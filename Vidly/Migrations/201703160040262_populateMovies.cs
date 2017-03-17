namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, DateAdded, ReleaseDate, NumberInStock, Genre_Id) VALUES ('Hangover', GetDate(),'2009-11-06 00:00:000','5','5')");
        }
        
        public override void Down()
        {
        }
    }
}
