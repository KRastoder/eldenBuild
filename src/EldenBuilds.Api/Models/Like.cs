using EldenBuilds.Api.Data;

namespace EldenBuilds.Api.Models;

public class Like
{
    public required string UserId { get; set; }
    public required User User { get; set; }

    public required Guid PostId { get; set; }
    public required Post Post { get; set; }
}