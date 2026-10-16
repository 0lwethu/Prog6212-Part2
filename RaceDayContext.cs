using System;
using Microsoft.EntityFrameworkCore;
using RaceDayApi.Models;
using RouteModel = RaceDayApi.Models.Route;

namespace RaceDayApi.Data;

public class RaceDayContext : DbContext
{
    public RaceDayContext(
        DbContextOptions<RaceDayContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Participant> Participants => Set<Participant>();
    public DbSet<Organiser> Organisers => Set<Organiser>();
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<RouteModel> Routes => Set<RouteModel>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    public DbSet<Result> Results => Set<Result>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .HasMaxLength(20)
            .IsRequired();

        modelBuilder.Entity<Participant>()
            .HasIndex(p => p.UserID)
            .IsUnique();

        modelBuilder.Entity<Participant>()
            .HasIndex(p => p.IDNumber)
            .IsUnique();

        modelBuilder.Entity<Participant>()
            .HasOne(p => p.User)
            .WithOne(u => u.Participant)
            .HasForeignKey<Participant>(p => p.UserID);

        modelBuilder.Entity<Organiser>()
            .HasIndex(o => o.UserID)
            .IsUnique();

        modelBuilder.Entity<Organiser>()
            .HasOne(o => o.User)
            .WithOne(u => u.Organiser)
            .HasForeignKey<Organiser>(o => o.UserID);

        modelBuilder.Entity<Event>()
            .HasOne(e => e.Organiser)
            .WithMany(o => o.Events)
            .HasForeignKey(e => e.OrganiserID);

        modelBuilder.Entity<RouteModel>()
            .HasIndex(r => r.EventID)
            .IsUnique();

        modelBuilder.Entity<RouteModel>()
            .HasOne(r => r.Event)
            .WithOne(e => e.Route)
            .HasForeignKey<RouteModel>(r => r.EventID);

        modelBuilder.Entity<Enrollment>()
            .HasIndex(e => new
            {
                e.ParticipantID,
                e.CategoryID
            })
            .IsUnique();

        modelBuilder.Entity<Enrollment>()
            .HasIndex(e => e.RaceNumber)
            .IsUnique();

        modelBuilder.Entity<Result>()
            .HasIndex(r => r.EnrollmentID)
            .IsUnique();

        modelBuilder.Entity<Result>()
            .HasOne(r => r.Enrollment)
            .WithOne(e => e.Result)
            .HasForeignKey<Result>(r => r.EnrollmentID);

        modelBuilder.Entity<Category>()
            .Property(c => c.EntryFee)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Category>()
            .Property(c => c.DistanceKm)
            .HasPrecision(8, 2);

        modelBuilder.Entity<RouteModel>()
            .Property(r => r.DistanceKm)
            .HasPrecision(8, 2);
    }
}