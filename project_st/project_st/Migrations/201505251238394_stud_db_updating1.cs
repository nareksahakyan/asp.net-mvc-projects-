namespace project_st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stud_db_updating1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "lName", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "lName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "lName", c => c.String());
            AlterColumn("dbo.Teachers", "Name", c => c.String());
            AlterColumn("dbo.Students", "lName", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
