using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer()
        {
            this.NumberOfBadges = 0;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }

        public List<Pokemon> collectionPokemon = new List<Pokemon>();
    }
}
