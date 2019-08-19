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
    using System.Text;

    using static zfunc;    

    /// <summary>
    /// Defines literals that identity each 4-element permutation
    /// </summary>
    public enum Perm4 : byte
    {        
        /// <summary>
        /// [00 01 11 10]: ABCD -> ABDC
        /// </summary>
        ABDC = 0x1E, 

        /// <summary>
        /// [00 10 01 11]: ABCD -> ACBD
        /// </summary>
        ACBD = 0x27, 

        /// <summary>
        /// [00 10 11 01]: ABCD -> ACDB
        /// </summary>
        ACDB = 0x2D,  

        /// <summary>
        /// ABCD -> ADBC
        /// </summary>
        ADBC = 0x36, 

        /// <summary>
        /// ABCD -> ADCA
        /// </summary>
        ADCA = 0x38, 

        /// <summary>
        /// ABCD -> ADCB
        /// </summary>
        ADCB = 0x39, 

        /// <summary>
        /// ABCD -> BADC
        /// </summary>
        BADC = 0x4E,                 

        /// <summary>
        /// ABCD -> BCAD
        /// </summary>
        BCAD = 0x63, 

        /// <summary>
        /// ABCD -> BCDA
        /// </summary>
        BCDA = 0x6C, 

        /// <summary>
        /// ABCD -> BDAC
        /// </summary>
        BDAC = 0x72, 

        /// <summary>
        /// ABCD -> BDCA
        /// </summary>
        BDCA = 0x78, 

        /// <summary>
        /// ABCD -> CABD
        /// </summary>
        CABD = 0x87, 

        /// <summary>
        /// ABCD -> CADB
        /// </summary>
        CADB = 0x8D, 

        /// <summary>
        /// ABCD -> CBAD
        /// </summary>
        CBAD = 0x93, 

        /// <summary>
        /// ABCD -> CBDA
        /// </summary>
        CBDA = 0x9C, 

        /// <summary>
        /// ABCD -> CDAB
        /// </summary>
        CDAB = 0xB1, 

        /// <summary>
        /// ABCD -> CDBA
        /// </summary>
        CDBA = 0xB4,         

        /// <summary>
        /// ABCD -> DABC
        /// </summary>
        DABC = 0xC6,

        /// <summary>
        /// ABCD -> DACB
        /// </summary>
        DACB = 0xC9,  

        /// <summary>
        /// [11 01 00 10]: ABCD -> DBAC
        /// </summary>
        DBAC = 0xD2, 

        /// <summary>
        /// [11 01 10 00]: ABCD -> DBCA
        /// </summary>
        DBCA = 0xD8, 

        /// <summary>
        /// ABCD -> DCAB
        /// </summary>
        DCAB = 0xE1, 

        /// <summary>
        /// ABCD -> DCBA
        /// </summary>
        DCBA = 0xE4,     
    }



}