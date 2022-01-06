using System;

namespace HardHillChess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("HardHill Chess ver. 1.0");
            while (true)
            {
                var command = Console.In.ReadLine();
                if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}