
using static System.Console;

namespace Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Egg1 = 30;
            int Egg2 = 25;
            int Egg3 = 40;
            int Egg4 = 32;

            int totalEggs = Egg1 + Egg2 + Egg3 + Egg4;

            int dozens = totalEggs / 12;
            int leftover = totalEggs % 12;
            WriteLine("{0} eggs is {1} dozen and {2} eggs.", totalEggs, dozens, leftover);
        }
    }
}
