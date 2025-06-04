using PracticeOOPCSharp01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01.Pokemons
{
    internal class Charizard : WaterPokemon, IEvolvable
    {
        public Charizard(string name, List<Attack> attacks) : base(name, 65, attacks)
        {
        }

        public void Evolve()
        {
            var oldName = this.Name;

            this.Level += 10;
            this.Name = "Megacharizard";

            Console.WriteLine($"{oldName} is evolving... Now it's {this.Name}! Level {this.Level}");
        }
    }
}
