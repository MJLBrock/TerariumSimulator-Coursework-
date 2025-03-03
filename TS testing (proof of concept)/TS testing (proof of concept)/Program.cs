using System;

namespace TS_testing__proof_of_concept_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ID   Tile");
            //Console.WriteLine("0    Air");
            //Console.WriteLine("1    Substrate");
            //Console.WriteLine("2    Ant");
            //Console.WriteLine("3    Insect Food");
            //Console.WriteLine();
            //string theGrid[,] = new string[20,20];
            //do while (true)
            //    {
            //        GetInput();

            //    }

            string[,] example = new string[10, 10];
            Console.WriteLine(example.Length);
            Console.ReadLine();
        }

        private static void GetInput()
        {
            Console.WriteLine("Enter tile selection:");
            int TileHeld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate");
            int placeX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate");
            int placeY = Convert.ToInt32(Console.ReadLine());

        }
    }
}
