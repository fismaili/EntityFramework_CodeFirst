using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_CodeFirst.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("insert into Grades(GradeName,Section) values ('A','Midterm')");
            migrationBuilder.Sql("insert into Grades(GradeName,Section) values ('B','Midterm')");

            migrationBuilder.Sql("insert into Students(StudentName,GradeId) values ('Test',1)");


        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
