using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01
{
    internal abstract class Pokemon
    {
        private readonly Random _random = new Random();
        private string _name;
        private int _level = 1;

        public string Name
        {
            get => _name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                {
                    throw new Exception("Allowed name length is 2-15 characters.");
                }

                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            protected set
            {
                if (value < 1)
                {
                    throw new Exception("Level must be at least 1.");
                }

                _level = value;
            }
        }

        public ElementType Type { get; }
        public List<Attack> Attacks { get; }

        public Pokemon(ElementType type, List<Attack> attacks)
        {
            Type = type;
            Attacks = attacks.Where(a => a.Type == type).ToList();
        }

        public virtual void RandomAttack()
        {
            if (Attacks.Count == 0)
            {
                Console.WriteLine($"{Name} is unable to attack");
                return;
            }

            var index = _random.Next(0, Attacks.Count);
            var attack = Attacks[index];

            attack.Use(Level);

        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} is attacking!");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Available attacks:");

            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} (Power: {Attacks[i].BasePower})");
            }

            Console.Write($"Choose an attack (1-{Attacks.Count}): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Attacks.Count)
            {
                Console.Write($"Invalid choice. Please choose a number between 1 and {Attacks.Count}: ");
            }
            Console.ResetColor();

            Attacks[choice - 1].Use(Level);
        }

        public virtual void RaiseLevel()
        {
            Console.WriteLine($"{Name} is leveling up to {++Level}!");
        }


        public void SayHi()
        {
            Console.ForegroundColor = Type switch
            {
                ElementType.Fire => ConsoleColor.Magenta,
                ElementType.Water => ConsoleColor.Blue,
                ElementType.Electric => ConsoleColor.Yellow,
                _ => ConsoleColor.White
            };


            Console.WriteLine($"Pokemon: {Name}, Level: {Level}, Type: {Type}");

            Console.ResetColor();
        }
    }
}
