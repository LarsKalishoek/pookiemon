﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSIm
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, int hp) : base(name, hp) 
        {
            this.species = "Bulbasaur";
            this.type = "Grass";
            this.weakness = "Water";
        }
        public override void BattleCry()
        {
            Console.WriteLine(this.species);
        }
    }

}
