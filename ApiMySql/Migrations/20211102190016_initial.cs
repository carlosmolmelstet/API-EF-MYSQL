using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMySql.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: false),
                    ShortName = table.Column<string>(type: "varchar(4) CHARACTER SET utf8mb4", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    PositionId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUsers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1"), "Wide Reciver", "WR" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("f91972de-c148-430b-b547-9742ed3027e9"), "Quarterback", "QB" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4"), "Running Back", "RB" });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[,]
                {
                    { new Guid("4f75ca5e-229d-4bfe-bd85-8e41ff475ace"), "Player1@gmail.com", null, "Player 1 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("ce52e399-34d4-4577-9f9d-2cf434bf0c33"), "Player36@gmail.com", null, "Player 36 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("20c0b714-55cc-4a16-8a9d-4b47226adc2f"), "Player37@gmail.com", null, "Player 37 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("4d2c606f-0fe9-41f9-8180-5a525af82599"), "Player38@gmail.com", null, "Player 38 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("5c26c38b-6d5e-41b6-b467-3c56a838e130"), "Player39@gmail.com", null, "Player 39 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("7e525119-2961-49c6-a9b7-0f938f16ece4"), "Player40@gmail.com", null, "Player 40 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("44b028ef-43df-49d5-9226-3d0fc58c26ab"), "Player3@gmail.com", null, "Player 3 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("93039e40-7cab-4214-ac27-ab88cb9b401e"), "Player4@gmail.com", null, "Player 4 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("97645faa-f617-4059-8e7e-3ebd2241463d"), "Player32@gmail.com", null, "Player 32 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("71dce495-8ef4-4655-94fa-7974706b7e3b"), "Player5@gmail.com", null, "Player 5 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("d5ea9ed1-c653-4e66-a7bb-1046c9f31c38"), "Player14@gmail.com", null, "Player 14 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("30ff4460-3924-43ba-addf-30eba92c067f"), "Player21@gmail.com", null, "Player 21 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("2fcf09ec-9829-4fcd-a220-dcaf494168a3"), "Player24@gmail.com", null, "Player 24 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("e6909b54-5526-4468-b945-4fed8b38c3ec"), "Player26@gmail.com", null, "Player 26 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("dfc87923-6488-476c-8191-b48b83c36767"), "Player29@gmail.com", null, "Player 29 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("bc03ae24-dcf5-46fe-867b-42aa7632a396"), "Player30@gmail.com", null, "Player 30 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("18f07f46-6848-4e0a-9a23-a354029afd10"), "Player33@gmail.com", null, "Player 33 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("58305131-b809-4141-aeb6-35f8a3a03aa8"), "Player11@gmail.com", null, "Player 11 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("9b18c83e-fe07-447b-920a-3361f53325a8"), "Player27@gmail.com", null, "Player 27 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("3d3bbf40-53a7-41c3-ba56-73aa2cf43582"), "Player22@gmail.com", null, "Player 22 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("bf1cc46b-82f9-4635-8bc8-9a58588b0545"), "Player17@gmail.com", null, "Player 17 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("d49d02de-cfba-4f42-8a72-c27794251b3a"), "Player10@gmail.com", null, "Player 10 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("dd659879-f3f9-453d-8afc-c46619bfb6ff"), "Player12@gmail.com", null, "Player 12 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("fb4ee799-d558-4a4c-88a4-6f9db5476275"), "Player15@gmail.com", null, "Player 15 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("fb938e9b-b2f6-4030-8595-580b482da9aa"), "Player18@gmail.com", null, "Player 18 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("2cd1a095-6555-4423-9d53-3523d1ce078f"), "Player19@gmail.com", null, "Player 19 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("14e44792-411d-4aa8-8e4d-2c2acdf3e42d"), "Player20@gmail.com", null, "Player 20 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("e982ae67-1951-4d4c-a284-2a6925c5b51a"), "Player23@gmail.com", null, "Player 23 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("14db8de4-789e-41bc-9ccc-65a37f9c0660"), "Player25@gmail.com", null, "Player 25 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("4523fb59-1e47-4fd6-80df-e7e8fb0b6f1c"), "Player28@gmail.com", null, "Player 28 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("fe979051-4f19-4976-afb7-423599367932"), "Player31@gmail.com", null, "Player 31 ", "(47) 99630-5948", new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1") },
                    { new Guid("74d9fc5c-9254-4ab6-8c57-ba812c45bf08"), "Player2@gmail.com", null, "Player 2 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("ad4030e8-b561-424e-8a59-c5ac04c37c0d"), "Player6@gmail.com", null, "Player 6 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("c10840d8-347e-4ff4-8e61-7a207aab8368"), "Player7@gmail.com", null, "Player 7 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("25a07fe0-1817-4fd4-a258-8d4f666ae54a"), "Player8@gmail.com", null, "Player 8 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("2aaa3600-3644-48e7-a700-c9e475f790dc"), "Player9@gmail.com", null, "Player 9 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("0c7a1a1a-c9d4-48c7-ac6c-2fec18062179"), "Player13@gmail.com", null, "Player 13 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("3a9d5871-53bd-4d6c-a7cd-6acf904a800d"), "Player16@gmail.com", null, "Player 16 ", "(47) 99630-5948", new Guid("f91972de-c148-430b-b547-9742ed3027e9") },
                    { new Guid("f564a12d-cceb-4dfb-85f5-ac7ac9e5e014"), "Player34@gmail.com", null, "Player 34 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") },
                    { new Guid("fe9e299d-d11c-474f-a313-fbb6762f194c"), "Player35@gmail.com", null, "Player 35 ", "(47) 99630-5948", new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_PositionId",
                table: "SystemUsers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
