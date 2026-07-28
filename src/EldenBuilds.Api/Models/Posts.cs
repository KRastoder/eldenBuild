using EldenBuilds.Api.Data;

namespace EldenBuilds.Api.Models;

public class Post
{
    public required Guid Id { get; set; }

    // CREATOR
    public required string CreatorId { get; set; }
    public required User Creator { get; set; }

    // POST CONTENT
    public required string Title { get; set; }
    public required string Description { get; set; }

    // BUILD
    public required Guid BuildId { get; set; }
    public required Build Build { get; set; }

}