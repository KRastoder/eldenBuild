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
}


public sealed class User : IdentityUser
{
}
