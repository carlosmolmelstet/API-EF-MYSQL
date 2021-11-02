using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.SystemUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>()
              .Property(e => e.Name).HasMaxLength(80).IsRequired();

            modelBuilder.Entity<Position>()
          .Property(e => e.ShortName).HasMaxLength(4).IsRequired();

            var positionId1 = Guid.NewGuid();
            var positionId2 = Guid.NewGuid();
            var positionId3 = Guid.NewGuid();

            modelBuilder.Entity<Position>()
                .HasData(
                    new Position { Id = positionId1, Name = "Wide Reciver", ShortName = "WR" },
                    new Position { Id = positionId2, Name = "Quarterback", ShortName = "QB" },
                    new Position { Id = positionId3, Name = "Running Back", ShortName = "RB" }
            );

            modelBuilder.Entity<SystemUser>()
                      .HasOne<Position>(s => s.Position)
                      .WithMany(g => g.SystemUsers)
                      .HasForeignKey(s => s.PositionId);

            modelBuilder.Entity<SystemUser>()
               .Property(e => e.Name).HasMaxLength(80).IsRequired();

            modelBuilder.Entity<SystemUser>()
              .Property(e => e.Email).HasMaxLength(80);

            modelBuilder.Entity<SystemUser>()
             .Property(e => e.Phone).HasMaxLength(20).IsRequired();


            modelBuilder.Entity<SystemUser>()
                .HasData(
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 1 ", Phone = "(47) 99630-5948", Email = "Player1@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 2 ", Phone = "(47) 99630-5948", Email = "Player2@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 3 ", Phone = "(47) 99630-5948", Email = "Player3@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 4 ", Phone = "(47) 99630-5948", Email = "Player4@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 5 ", Phone = "(47) 99630-5948", Email = "Player5@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 6 ", Phone = "(47) 99630-5948", Email = "Player6@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 7 ", Phone = "(47) 99630-5948", Email = "Player7@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 8 ", Phone = "(47) 99630-5948", Email = "Player8@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 9 ", Phone = "(47) 99630-5948", Email = "Player9@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 10 ", Phone = "(47) 99630-5948", Email = "Player10@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 11 ", Phone = "(47) 99630-5948", Email = "Player11@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 12 ", Phone = "(47) 99630-5948", Email = "Player12@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 13 ", Phone = "(47) 99630-5948", Email = "Player13@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 14 ", Phone = "(47) 99630-5948", Email = "Player14@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 15 ", Phone = "(47) 99630-5948", Email = "Player15@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 16 ", Phone = "(47) 99630-5948", Email = "Player16@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 17 ", Phone = "(47) 99630-5948", Email = "Player17@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 18 ", Phone = "(47) 99630-5948", Email = "Player18@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 19 ", Phone = "(47) 99630-5948", Email = "Player19@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 20 ", Phone = "(47) 99630-5948", Email = "Player20@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 21 ", Phone = "(47) 99630-5948", Email = "Player21@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 22 ", Phone = "(47) 99630-5948", Email = "Player22@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 23 ", Phone = "(47) 99630-5948", Email = "Player23@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 24 ", Phone = "(47) 99630-5948", Email = "Player24@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 25 ", Phone = "(47) 99630-5948", Email = "Player25@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 26 ", Phone = "(47) 99630-5948", Email = "Player26@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 27 ", Phone = "(47) 99630-5948", Email = "Player27@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 28 ", Phone = "(47) 99630-5948", Email = "Player28@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 29 ", Phone = "(47) 99630-5948", Email = "Player29@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 30 ", Phone = "(47) 99630-5948", Email = "Player30@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 31 ", Phone = "(47) 99630-5948", Email = "Player31@gmail.com", PositionId = positionId1 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 32 ", Phone = "(47) 99630-5948", Email = "Player32@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 33 ", Phone = "(47) 99630-5948", Email = "Player33@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 34 ", Phone = "(47) 99630-5948", Email = "Player34@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 35 ", Phone = "(47) 99630-5948", Email = "Player35@gmail.com", PositionId = positionId3 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 36 ", Phone = "(47) 99630-5948", Email = "Player36@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 37 ", Phone = "(47) 99630-5948", Email = "Player37@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 38 ", Phone = "(47) 99630-5948", Email = "Player38@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 39 ", Phone = "(47) 99630-5948", Email = "Player39@gmail.com", PositionId = positionId2 },
                    new SystemUser { Id = Guid.NewGuid(), Name = "Player 40 ", Phone = "(47) 99630-5948", Email = "Player40@gmail.com", PositionId = positionId2 }
                ); ;
        }
    }
}
