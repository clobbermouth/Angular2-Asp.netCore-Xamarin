using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.DotNet.InternalAbstractions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SQLScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(ApplicationEnvironment.ApplicationBasePath, @"Insert.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
