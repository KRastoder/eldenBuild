namespace EldenBuilds.Api.Models;

public class Armour
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public required int Weight { get; set; }
    public required int ArmourType { get; set; }
}

// Armour Table
// -------
// id 
// name 
// location(region)
// weight 
// absorpitons add later 
// ArmourType (Helmet,Leggings,Chestplate,Gloves)