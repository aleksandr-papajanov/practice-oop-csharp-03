using PracticeOOPCSharp01.Infrastructure;
using PracticeOOPCSharp01.Pokemons;

namespace PracticeOOPCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Attack> attacks = new List<Attack>
            {
                new Attack("Tackle", ElementType.Water, 40),
                new Attack("Water Gun", ElementType.Water, 50),
                new Attack("Thunder Shock", ElementType.Electric, 40),
                new Attack("Ember", ElementType.Fire, 40),
                new Attack("Aqua Tail", ElementType.Water, 60),
                new Attack("Spark", ElementType.Electric, 50),
                new Attack("Flame Wheel", ElementType.Fire, 60),
                new Attack("Bubble", ElementType.Water, 30),
                new Attack("Fire Spin", ElementType.Fire, 35),
                new Attack("Thunderbolt", ElementType.Electric, 60)
            };

            List<Pokemon> pokemons = new List<Pokemon>
            {
                new Pikachu("Zapster", attacks),
                new Squirtle("Tide", attacks),
                new Charizard("Blazer", attacks),
                new Charmander("Smolder", attacks),
                new Flareon("Cinder", attacks),
                new Pikachu("Boltz", attacks),
                new Electabuzz("Wattson", attacks), 
                new Squirtle("Marina", attacks),
                new Charmander("Flareon", attacks)    
            };


            foreach (var pokemon in pokemons)
            {
                pokemon.SayHi();

                pokemon.RaiseLevel();
                pokemon.Attack();

                if (pokemon is IEvolvable evolvable)
                {
                    evolvable.Evolve();
                }

                Console.WriteLine();
            }

        }
    }
}
