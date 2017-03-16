using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.DotNet.InternalAbstractions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(ApplicationEnvironment.ApplicationBasePath, @"C:\Users\Cory\Source\Repos\Angular2-Asp.netCore-Xamarin\383Phase4Project\src\Backend\Migrations\SQL Script\Insert.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
