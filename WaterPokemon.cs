using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks) : base(ElementType.Water, attacks)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}
