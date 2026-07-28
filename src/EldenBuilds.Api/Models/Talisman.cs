namespace EldenBuilds.Api.Models;

public class Talisman
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public required string Description { get; set; }
    public required string Effect { get; set; }

}

// Talisman table 
// ------------
// id 
// name 
// location (region)
// desc
// effect
