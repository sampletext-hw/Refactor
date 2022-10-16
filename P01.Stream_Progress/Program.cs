using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            var file = new File("example.txt", 100, 0);

            var music = new Music("Bird Egop", "Self EP", 345, 99);

            var info1 = new StreamProgressInfo(file);
            var info2 = new StreamProgressInfo(music);

            Console.WriteLine(info1.CalculateCurrentPercent());
            Console.WriteLine(info2.CalculateCurrentPercent());
        }
    }
}
