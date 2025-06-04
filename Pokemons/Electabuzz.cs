using PracticeOOPCSharp01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01.Pokemons
{
    internal class Electabuzz : ElectricPokemon
    {
        public Electabuzz(string name, List<Attack> attacks) : base(name, 34, attacks)
        {
        }
    }
}
