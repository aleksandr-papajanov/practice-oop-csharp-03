﻿using PracticeOOPCSharp01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01.Pokemons
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(string name, List<Attack> attacks) : base(name, 23, attacks)
        {
        }

        public void Evolve()
        {
            var oldName = this.Name;

            this.Level += 10;
            this.Name = "Raichu";

            Console.WriteLine($"{oldName} is evolving... Now it's {this.Name}! Level {this.Level}");
        }
    }
}
