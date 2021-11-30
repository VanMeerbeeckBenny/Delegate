using System;
using Cafe.Lib;

namespace Cafe.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPints = 10;
            PintDish pintDish = new PintDish(numberOfPints);
            pintDish.PinStarted += PintDish_PintStarted;

            for (int i = 0; i < numberOfPints; i++)
            {
                try
                {
                    pintDish.AddPint();
                    Console.WriteLine($"Pint {pintDish.PintCount} added to dish");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }

        private static void PintDish_PintStarted(object sender,EventArgs e)
        {
            Console.WriteLine($"brewing a new pint");
        }
    }
}
