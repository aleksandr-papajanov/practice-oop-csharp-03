using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01.Infrastructure
{
    internal class Attack
    {
        public string Name { get; }
        public ElementType Type { get; }
        public int BasePower { get; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} hits with total power {BasePower + level}");
            Console.ResetColor();
        }
    }
}
