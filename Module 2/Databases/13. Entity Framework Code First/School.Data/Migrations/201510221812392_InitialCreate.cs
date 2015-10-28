namespace School.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        TimeSent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HomeworkCourses",
                c => new
                    {
                        Homework_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Homework_Id, t.Course_Id })
                .ForeignKey("dbo.Homework", t => t.Homework_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Homework_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.StudentHomeworks",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Homework_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Homework_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Homework", t => t.Homework_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Homework_Id);           
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.StudentHomeworks", "Homework_Id", "dbo.Homework");
            this.DropForeignKey("dbo.StudentHomeworks", "Student_Id", "dbo.Students");
            this.DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            this.DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            this.DropForeignKey("dbo.HomeworkCourses", "Course_Id", "dbo.Courses");
            this.DropForeignKey("dbo.HomeworkCourses", "Homework_Id", "dbo.Homework");
            this.DropIndex("dbo.StudentHomeworks", new[] { "Homework_Id" });
            this.DropIndex("dbo.StudentHomeworks", new[] { "Student_Id" });
            this.DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            this.DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            this.DropIndex("dbo.HomeworkCourses", new[] { "Course_Id" });
            this.DropIndex("dbo.HomeworkCourses", new[] { "Homework_Id" });
            this.DropTable("dbo.StudentHomeworks");
            this.DropTable("dbo.StudentCourses");
            this.DropTable("dbo.HomeworkCourses");
            this.DropTable("dbo.Students");
            this.DropTable("dbo.Homework");
            this.DropTable("dbo.Courses");
        }
    }
}
