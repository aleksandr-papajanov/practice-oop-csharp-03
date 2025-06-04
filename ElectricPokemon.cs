using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01
{
    internal class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks) : base(ElementType.Electric, attacks)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}
