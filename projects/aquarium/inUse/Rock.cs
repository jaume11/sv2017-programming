﻿// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor
//     Removed unnecessary extra methods

class Rock : StaticSprite
{
    public Rock(int x, int y)
        : base(x, y, "M^M")
    {
    }
}