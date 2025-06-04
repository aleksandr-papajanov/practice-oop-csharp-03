using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPCSharp01
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks) : base(ElementType.Fire, attacks)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}
