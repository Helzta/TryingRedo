using System;
using Raylib_cs;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Stort
{
    public class SimulateButton: LiebeRay
    {
        public int nextDay {get; set;}
        public void CheckDate()
        {
            this.nextDay++;
        }
    }
}