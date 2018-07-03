using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Job.Migrations
{
    public partial class addUserJobToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskDescription = table.Column<string>(nullable: true),
                    TaskName = table.Column<string>(nullable: true),
                    TaskSchedule = table.Column<int>(nullable: false)//the items to be itemized
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.ID); //primary Key Task Items
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
