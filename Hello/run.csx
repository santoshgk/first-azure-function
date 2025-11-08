#r "Microsoft.Azure.Functions.Extensions"
#r "Microsoft.Azure.WebJobs.Extensions.Http"

using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Extensions.Http;

public static string Run(HttpRequest req)
{
    var name = req.Query["name"];
    return name.Count > 0
        ? $"Hello {name}! Your C# Function is LIVE!"
        : "Pass ?name=YourName in the URL";
}
