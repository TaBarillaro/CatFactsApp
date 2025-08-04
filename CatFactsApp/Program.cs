using CatFactsApp.Models;
using CatFactsApp.Services;

class Program
{
    static async Task Main(string[] args)
    {
        CatFactService service = new CatFactService();
        CatFact catFact = await service.GetCatFactAsync();

        Console.WriteLine("Here are some cat facts:");
        if (catFact == null)
        {
            Console.WriteLine("No cat facts available at the moment.");
            return;
        }
        Console.WriteLine($"- {catFact.Fact}");
       
    }
}