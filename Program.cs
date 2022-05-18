using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", "Knight", 42, 100, 100);
            WhiteWizard jennica = new WhiteWizard("Jennica", "WhiteWizard", 42, 100, 100);
            BlackWizard topapa = new BlackWizard("Topapa", "BlackWizard", 42, 100, 100);
            Ninja wedge = new Ninja("Wedge", "Ninja", 42, 100, 100);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(arus.Attack(100));
            Console.WriteLine(jennica.Recover());
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(wedge.Attack());
        }
    }
}