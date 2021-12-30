﻿using System;

namespace Bloon.Bloons
{
    public class BloonRed : Bloon
    {
        public override string Name => "Red";
        public override int Health => 1;
        public override int Value => 1;
        public override float Speed => 1.0f;
        public override Bloon[] Children => Array.Empty<Bloon>();
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}