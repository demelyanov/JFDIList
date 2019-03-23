﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JFDIList.DataAccess.Migrations
{
    public partial class tasktags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskTag_Tags_TagId",
                table: "TaskTag");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskTag_Tasks_TaskId",
                table: "TaskTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskTag",
                table: "TaskTag");

            migrationBuilder.RenameTable(
                name: "TaskTag",
                newName: "TaskTags");

            migrationBuilder.RenameIndex(
                name: "IX_TaskTag_TagId",
                table: "TaskTags",
                newName: "IX_TaskTags_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskTags",
                table: "TaskTags",
                columns: new[] { "TaskId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTags_Tags_TagId",
                table: "TaskTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTags_Tasks_TaskId",
                table: "TaskTags",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskTags_Tags_TagId",
                table: "TaskTags");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskTags_Tasks_TaskId",
                table: "TaskTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskTags",
                table: "TaskTags");

            migrationBuilder.RenameTable(
                name: "TaskTags",
                newName: "TaskTag");

            migrationBuilder.RenameIndex(
                name: "IX_TaskTags_TagId",
                table: "TaskTag",
                newName: "IX_TaskTag_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskTag",
                table: "TaskTag",
                columns: new[] { "TaskId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTag_Tags_TagId",
                table: "TaskTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTag_Tasks_TaskId",
                table: "TaskTag",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
