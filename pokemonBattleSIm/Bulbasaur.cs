﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSIm
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, bool alive) : base(name, alive)
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