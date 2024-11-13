using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut ur gymmnasiet?");
            Console.WriteLine("Svara j för Ja och n för Nej");
            string x = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int år = int.Parse(Console.ReadLine());

            if(x == "j" && år <= 22)
            {
                Console.WriteLine("Vi vill anställa dig");
            }
            else
            {
                Console.WriteLine("Vi vill inte anställa dig"); Environment.Exit(0);
            }

            Console.ReadLine();

        }
    }
}
