using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01.Pokemons
{
    internal class Squirtle : WaterPokemon
    {
        public Squirtle(string name, int level, List<Attack> attacks) : base(name, level, attacks)
        {
        }
    }
}
