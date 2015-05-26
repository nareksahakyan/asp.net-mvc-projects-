namespace project_st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stud_db_updating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        lName = c.String(),
                        IDnumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Courses", "Teacher_id", c => c.Int());
            CreateIndex("dbo.Courses", "Teacher_id");
            AddForeignKey("dbo.Courses", "Teacher_id", "dbo.Teachers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Teacher_id", "dbo.Teachers");
            DropIndex("dbo.Courses", new[] { "Teacher_id" });
            DropColumn("dbo.Courses", "Teacher_id");
            DropTable("dbo.Teachers");
        }
    }
}
