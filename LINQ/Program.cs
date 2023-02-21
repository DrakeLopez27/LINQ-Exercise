using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var VideoGames = new List<string>() { "Phasmophobia", "Call of Duty", "Howgwart's Legacy" };



            var containsSpace = VideoGames.Where(x => x.Contains(" ")).ToList();
            foreach (var videoGame in containsSpace)
            {
                Console.WriteLine(videoGame);
            }


            var count = VideoGames.Count();
            Console.WriteLine(count);

            
           var LengthOrder = VideoGames.OrderByDescending(x => x.Length).ToList();
            for (int i = 0; i < LengthOrder.Count; i++)
            {
                Console.WriteLine(LengthOrder[i]);
            }
        }
    }
}
