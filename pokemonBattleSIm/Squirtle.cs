﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSIm
{
    internal class Squirtle : Pokemon
    {
        public Squirtle(string name, bool alive) : base(name, alive)
        {
            this.species = "Squirtle";
            this.type = "Water";
            this.weakness = "Grass";
        }
        public override void BattleCry()
        {
            Console.WriteLine(this.species);
        }
    }
}