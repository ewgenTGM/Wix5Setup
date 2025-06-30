using Newtonsoft.Json;

namespace ClientLib;

internal class Program
{
    static void Main(string[] args)
    {
        var user = new UserData()
        {
            UserId = Guid.NewGuid(),
            UserName = $"User{Guid.NewGuid()}"
        };
        
        var serializer = new JsonSerializer();
        
        Console.WriteLine(user);
    }
}