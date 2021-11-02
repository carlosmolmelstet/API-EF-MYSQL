﻿// <auto-generated />
using System;
using ApiMySql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiMySql.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211102190016_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ApiMySql.Data.Entities.Positions.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1"),
                            Name = "Wide Reciver",
                            ShortName = "WR"
                        },
                        new
                        {
                            Id = new Guid("f91972de-c148-430b-b547-9742ed3027e9"),
                            Name = "Quarterback",
                            ShortName = "QB"
                        },
                        new
                        {
                            Id = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4"),
                            Name = "Running Back",
                            ShortName = "RB"
                        });
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.SystemUsers.SystemUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("SystemUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f75ca5e-229d-4bfe-bd85-8e41ff475ace"),
                            Email = "Player1@gmail.com",
                            Name = "Player 1 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("74d9fc5c-9254-4ab6-8c57-ba812c45bf08"),
                            Email = "Player2@gmail.com",
                            Name = "Player 2 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("44b028ef-43df-49d5-9226-3d0fc58c26ab"),
                            Email = "Player3@gmail.com",
                            Name = "Player 3 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("93039e40-7cab-4214-ac27-ab88cb9b401e"),
                            Email = "Player4@gmail.com",
                            Name = "Player 4 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("71dce495-8ef4-4655-94fa-7974706b7e3b"),
                            Email = "Player5@gmail.com",
                            Name = "Player 5 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("ad4030e8-b561-424e-8a59-c5ac04c37c0d"),
                            Email = "Player6@gmail.com",
                            Name = "Player 6 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("c10840d8-347e-4ff4-8e61-7a207aab8368"),
                            Email = "Player7@gmail.com",
                            Name = "Player 7 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("25a07fe0-1817-4fd4-a258-8d4f666ae54a"),
                            Email = "Player8@gmail.com",
                            Name = "Player 8 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("2aaa3600-3644-48e7-a700-c9e475f790dc"),
                            Email = "Player9@gmail.com",
                            Name = "Player 9 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("d49d02de-cfba-4f42-8a72-c27794251b3a"),
                            Email = "Player10@gmail.com",
                            Name = "Player 10 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("58305131-b809-4141-aeb6-35f8a3a03aa8"),
                            Email = "Player11@gmail.com",
                            Name = "Player 11 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("dd659879-f3f9-453d-8afc-c46619bfb6ff"),
                            Email = "Player12@gmail.com",
                            Name = "Player 12 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("0c7a1a1a-c9d4-48c7-ac6c-2fec18062179"),
                            Email = "Player13@gmail.com",
                            Name = "Player 13 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("d5ea9ed1-c653-4e66-a7bb-1046c9f31c38"),
                            Email = "Player14@gmail.com",
                            Name = "Player 14 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("fb4ee799-d558-4a4c-88a4-6f9db5476275"),
                            Email = "Player15@gmail.com",
                            Name = "Player 15 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("3a9d5871-53bd-4d6c-a7cd-6acf904a800d"),
                            Email = "Player16@gmail.com",
                            Name = "Player 16 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("bf1cc46b-82f9-4635-8bc8-9a58588b0545"),
                            Email = "Player17@gmail.com",
                            Name = "Player 17 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("fb938e9b-b2f6-4030-8595-580b482da9aa"),
                            Email = "Player18@gmail.com",
                            Name = "Player 18 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("2cd1a095-6555-4423-9d53-3523d1ce078f"),
                            Email = "Player19@gmail.com",
                            Name = "Player 19 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("14e44792-411d-4aa8-8e4d-2c2acdf3e42d"),
                            Email = "Player20@gmail.com",
                            Name = "Player 20 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("30ff4460-3924-43ba-addf-30eba92c067f"),
                            Email = "Player21@gmail.com",
                            Name = "Player 21 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("3d3bbf40-53a7-41c3-ba56-73aa2cf43582"),
                            Email = "Player22@gmail.com",
                            Name = "Player 22 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("e982ae67-1951-4d4c-a284-2a6925c5b51a"),
                            Email = "Player23@gmail.com",
                            Name = "Player 23 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("2fcf09ec-9829-4fcd-a220-dcaf494168a3"),
                            Email = "Player24@gmail.com",
                            Name = "Player 24 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("14db8de4-789e-41bc-9ccc-65a37f9c0660"),
                            Email = "Player25@gmail.com",
                            Name = "Player 25 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("e6909b54-5526-4468-b945-4fed8b38c3ec"),
                            Email = "Player26@gmail.com",
                            Name = "Player 26 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("9b18c83e-fe07-447b-920a-3361f53325a8"),
                            Email = "Player27@gmail.com",
                            Name = "Player 27 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("4523fb59-1e47-4fd6-80df-e7e8fb0b6f1c"),
                            Email = "Player28@gmail.com",
                            Name = "Player 28 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("dfc87923-6488-476c-8191-b48b83c36767"),
                            Email = "Player29@gmail.com",
                            Name = "Player 29 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("bc03ae24-dcf5-46fe-867b-42aa7632a396"),
                            Email = "Player30@gmail.com",
                            Name = "Player 30 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("fe979051-4f19-4976-afb7-423599367932"),
                            Email = "Player31@gmail.com",
                            Name = "Player 31 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("4ea95033-6f25-4689-8c4c-a8f235c1bbc1")
                        },
                        new
                        {
                            Id = new Guid("97645faa-f617-4059-8e7e-3ebd2241463d"),
                            Email = "Player32@gmail.com",
                            Name = "Player 32 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("18f07f46-6848-4e0a-9a23-a354029afd10"),
                            Email = "Player33@gmail.com",
                            Name = "Player 33 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("f564a12d-cceb-4dfb-85f5-ac7ac9e5e014"),
                            Email = "Player34@gmail.com",
                            Name = "Player 34 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("fe9e299d-d11c-474f-a313-fbb6762f194c"),
                            Email = "Player35@gmail.com",
                            Name = "Player 35 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("362f449d-c922-41e5-a034-6acf4e51b9c4")
                        },
                        new
                        {
                            Id = new Guid("ce52e399-34d4-4577-9f9d-2cf434bf0c33"),
                            Email = "Player36@gmail.com",
                            Name = "Player 36 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("20c0b714-55cc-4a16-8a9d-4b47226adc2f"),
                            Email = "Player37@gmail.com",
                            Name = "Player 37 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("4d2c606f-0fe9-41f9-8180-5a525af82599"),
                            Email = "Player38@gmail.com",
                            Name = "Player 38 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("5c26c38b-6d5e-41b6-b467-3c56a838e130"),
                            Email = "Player39@gmail.com",
                            Name = "Player 39 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        },
                        new
                        {
                            Id = new Guid("7e525119-2961-49c6-a9b7-0f938f16ece4"),
                            Email = "Player40@gmail.com",
                            Name = "Player 40 ",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f91972de-c148-430b-b547-9742ed3027e9")
                        });
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.SystemUsers.SystemUser", b =>
                {
                    b.HasOne("ApiMySql.Data.Entities.Positions.Position", "Position")
                        .WithMany("SystemUsers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.Positions.Position", b =>
                {
                    b.Navigation("SystemUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
