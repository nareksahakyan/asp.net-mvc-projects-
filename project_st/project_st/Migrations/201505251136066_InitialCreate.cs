namespace project_st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        lName = c.String(),
                        IDnumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cName = c.String(),
                        Student_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Students", t => t.Student_id)
                .Index(t => t.Student_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Student_id", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "Student_id" });
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
        }
    }
}
