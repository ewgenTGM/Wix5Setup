using Newtonsoft.Json;
using ServerAccess;

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

        var server = new ServerAccessLib(123);
        
        Console.WriteLine(user);
    }
}