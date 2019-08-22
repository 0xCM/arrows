//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public static class Gf256
    {
         
         /// <summary>
         /// The irreducible polynomials in GF(2^8)
         /// </summary>
         public static readonly BitVector8[] Irreducible = 
         {
            0b10001110,
            0b10010101,
            0b10010110,
            0b10100110,
            0b10101111,
            0b10110001,
            0b10110010,
            0b10110100,
            0b10111000,
            0b11000011,
            0b11000110,
            0b11010100,
            0b11100001,
            0b11100111,
            0b11110011,
            0b11111010,
         };


    }



}