using System.Transactions;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var libraryOfLinks = new List<string>() { 
                "Breath of the Wild", 
                "The Legend of Zelda", 
                "Link's Awakening", 
                "Super Smash Brothers", 
                "A Link To The Past",
                "Link's Awakening",
                "Ocarina of Time",
                "Majora's Mask",
                "The Wind Waker",
                "Twilight Princess",
                "Skyward Sword",
                "Mario Kart",
                "A Link Between Worlds",
                "Tears of a Kingdom"
            };
            libraryOfLinks = libraryOfLinks.OrderBy(x => x.Count()).ToList();
            foreach (var link in libraryOfLinks)
            {
                Console.WriteLine(link);              
            }
        }
    }
}
