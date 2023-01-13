namespace NTGS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Department_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
        }
    }
}
