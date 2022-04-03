using Divers_Hotel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Divers_Hotel.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<MealSeasonal> MealSeasonals { get; set; }
        public DbSet<RoomSeasonal> RoomSeasonals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=DiversHotel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MealSeasonal>()
                .HasKey(e => new { e.MealId, e.SeasonId });

            modelBuilder.Entity<RoomSeasonal>()
               .HasKey(e => new { e.RoomId, e.SeasonId });
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

        //    modelBuilder.Entity<MealSeasonal>(entity =>
        //    {
        //        entity.HasKey(e => new { e.MealId, e.SeasonId })
        //            .HasName("PK_Meal_Season");

        //        entity.ToTable("MealSeasonal");

        //        entity.Property(e => e.MealId).HasColumnName("MealID");

        //        entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

        //        entity.HasOne(d => d.Meal)
        //            .WithMany(p => p.MealSeasonals)
        //            .HasForeignKey(d => d.MealId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK__MealSeaso__MealI__2A4B4B5E");

        //        entity.HasOne(d => d.Season)
        //            .WithMany(p => p.MealSeasonals)
        //            .HasForeignKey(d => d.SeasonId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK__MealSeaso__Seaso__2B3F6F97");
        //    });


        //    modelBuilder.Entity<RoomSeasonal>(entity =>
        //    {
        //        entity.HasKey(e => new { e.RoomId, e.SeasonId })
        //            .HasName("PK_Room_Season");

        //        entity.ToTable("RoomSeasonal");

        //        entity.Property(e => e.RoomId).HasColumnName("RoomID");

        //        entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

        //        entity.HasOne(d => d.Room)
        //            .WithMany(p => p.RoomSeasonals)
        //            .HasForeignKey(d => d.RoomId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK__RoomSeaso__RoomI__2E1BDC42");

        //        entity.HasOne(d => d.Season)
        //            .WithMany(p => p.RoomSeasonals)
        //            .HasForeignKey(d => d.SeasonId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK__RoomSeaso__Seaso__2F10007B");
        //    });


        //    //OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
