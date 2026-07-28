namespace EldenBuilds.Api.Models;

public class Weapon
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required Guid StatSpreadId { get; set; }
    public StatSpread StatSpread { get; set; } = null!;
    public required string Region { get; set; }
    public string? Status { get; set; }
    public required int Weight { get; set; }
    public required string WeaponType { get; set; }
    public string? Image { get; set; }
}

// Weapon Table
// ---------------
// id 
// name 
// statspread requirments  
// location region 
// status (frost bleed poison scarletRot)
// weight 
// weapon_type
// image?