namespace ClientLib;

public record UserData
{
    public required Guid UserId { get; init; }
    public required string UserName { get; init; }
}