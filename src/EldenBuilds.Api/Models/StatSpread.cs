using System.ComponentModel.DataAnnotations;

namespace EldenBuilds.Api.Models;

public class StatSpread
{
    [Required]
    public required Guid Id { get; set; }

    [Range(1, 99, ErrorMessage = "Vigor must be i the range of 1-99")]
    [Required]
    public required int Vigor { get; set; }

    [Range(1, 99, ErrorMessage = "Mind must be i the range of 1-99")]
    [Required]
    public int Mind { get; set; }

    [Range(1, 99, ErrorMessage = "Endurance must be i the range of 1-99")]
    [Required]
    public int Endurance { get; set; }

    [Range(1, 99, ErrorMessage = "Strength must be i the range of 1-99")]
    [Required]
    public int Strength { get; set; }

    [Range(1, 99, ErrorMessage = "Dexterity must be i the range of 1-99")]
    [Required]
    public int Dexterity { get; set; }

    [Range(1, 99, ErrorMessage = "Intelligence must be i the range of 1-99")]
    [Required]
    public int Intelligence { get; set; }

    [Range(1, 99, ErrorMessage = "Arcane must be i the range of 1-99")]
    [Required]
    public int Arcane { get; set; }

    [Range(1, 99, ErrorMessage = "Faith must be i the range of 1-99")]
    [Required]
    public int Faith { get; set; }
}


// StatSpred table
// -----------------
// Guid id
// Vigor
// Mind
// Enduranc
// Strength
// Dexterity
// Intelligence
// Faith
// Arcane
