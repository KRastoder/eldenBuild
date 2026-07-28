namespace EldenBuilds.Api.Models;

public class Build
{
    public required Guid Id { get; set; }
    public required int Level { get; set; }

    // WEAPONS
    public required Guid WeaponOneId { get; set; }
    public required Weapon WeaponOne { get; set; }

    public required Guid WeaponTwoId { get; set; }
    public required Weapon WeaponTwo { get; set; }

    // TALISMANS
    public required Guid TalismanOneId { get; set; }
    public required Talisman TalismanOne { get; set; }

    public required Guid TalismanTwoId { get; set; }
    public required Talisman TalismanTwo { get; set; }

    public required Guid TalismanThreeId { get; set; }
    public required Talisman TalismanThree { get; set; }

    public required Guid TalismanFourId { get; set; }
    public required Talisman TalismanFour { get; set; }

    // ARMOUR
    public required Guid HelmetId { get; set; }
    public required Armour Helmet { get; set; }

    public required Guid ChestPlateId { get; set; }
    public required Armour ChestPlate { get; set; }

    public required Guid GlovesId { get; set; }
    public required Armour Gloves { get; set; }

    public required Guid LeggingsId { get; set; }
    public required Armour Leggings { get; set; }

    // STAT SPREAD
    public required Guid StatSpreadId { get; set; }
    public required StatSpread StatSpread { get; set; }

    // STATUS
    public string? StatusBuild { get; set; }
}