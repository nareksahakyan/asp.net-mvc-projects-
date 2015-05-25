namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imdb_l : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "imdb_l", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "imdb_l");
        }
    }
}
