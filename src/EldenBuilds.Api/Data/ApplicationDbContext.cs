using EldenBuilds.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EldenBuilds.Api.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<StatSpread> StatSpread { get; set; }
    public DbSet<Armour> Armour { get; set; }
    public DbSet<Talisman> Talisman { get; set; }
    public DbSet<Like> Likes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // WEAPONS
        modelBuilder.Entity<Build>()
            .HasOne(b => b.WeaponOne)
            .WithMany()
            .HasForeignKey(b => b.WeaponOneId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.WeaponTwo)
            .WithMany()
            .HasForeignKey(b => b.WeaponTwoId)
            .OnDelete(DeleteBehavior.Restrict);


        // TALISMANS
        modelBuilder.Entity<Build>()
            .HasOne(b => b.TalismanOne)
            .WithMany()
            .HasForeignKey(b => b.TalismanOneId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.TalismanTwo)
            .WithMany()
            .HasForeignKey(b => b.TalismanTwoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.TalismanThree)
            .WithMany()
            .HasForeignKey(b => b.TalismanThreeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.TalismanFour)
            .WithMany()
            .HasForeignKey(b => b.TalismanFourId)
            .OnDelete(DeleteBehavior.Restrict);


        // ARMOUR
        modelBuilder.Entity<Build>()
            .HasOne(b => b.Helmet)
            .WithMany()
            .HasForeignKey(b => b.HelmetId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.ChestPlate)
            .WithMany()
            .HasForeignKey(b => b.ChestPlateId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.Gloves)
            .WithMany()
            .HasForeignKey(b => b.GlovesId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Build>()
            .HasOne(b => b.Leggings)
            .WithMany()
            .HasForeignKey(b => b.LeggingsId)
            .OnDelete(DeleteBehavior.Restrict);


        // STAT SPREAD
        modelBuilder.Entity<Build>()
            .HasOne(b => b.StatSpread)
            .WithMany()
            .HasForeignKey(b => b.StatSpreadId)
            .OnDelete(DeleteBehavior.Restrict);

        //POST
        modelBuilder.Entity<Post>()
            .HasOne(p => p.Creator)
            .WithMany()
            .HasForeignKey(p => p.CreatorId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Post>()
            .HasOne(p => p.Build)
            .WithMany()
            .HasForeignKey(p => p.BuildId)
            .OnDelete(DeleteBehavior.Restrict);

        // LIKES
        modelBuilder.Entity<Like>()
            .HasKey(l => new { l.UserId, l.PostId });

        modelBuilder.Entity<Like>()
            .HasOne(l => l.User)
            .WithMany()
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Like>()
            .HasOne(l => l.Post)
            .WithMany()
            .HasForeignKey(l => l.PostId)
            .OnDelete(DeleteBehavior.Cascade);
    }

}


public sealed class User : IdentityUser
{
}
