//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    static class Mrg32K
    {
        public static readonly double Norm   = 2.328306549295727688e-10;

        public const uint Mod1 = 4294967087;

        public const uint Mod2 = 4294944443;

        public const uint A12 =  1403580;

        public const uint A13n = 810728;

        public const uint A21 = 527612;

        public const uint A23n = 1370589;

        public static ref readonly Vector<N6,uint> CheckSeed(in Vector<N6,uint> seed) 
        {        
            if (seed[0] == 0 && seed[1] == 0 && seed[2] == 0)
                throw new ArgumentException("The first 3 values must not be 0");
        
            if (seed[3] == 0 && seed[4] == 0 && seed[5] == 0)
                throw new ArgumentException("The last 3 values must not be 0");
        
            const long m1 = 4294967087L;        
            if (seed[0] >= m1 || seed[1] >= m1 || seed[2] >= m1)
                throw new ArgumentException("The first 3 values must be less than " + m1);
        
            const long m2 = 4294944443L;
            if (seed[3] >= m2 || seed[4] >= m2 || seed[5] >= m2)
                throw new ArgumentException("The last 3 values must be less than " + m2);
            
            return ref seed;
        }

    }
}