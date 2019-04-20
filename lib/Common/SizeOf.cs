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
    
    using static zcore;

    /// <summary>
    /// Computes the size of a primal numeric type
    /// </summary>
    public readonly struct SizeOf<T>
    {
        /// <summary>
        /// The size of the type in bytes
        /// </summary>
        public static readonly int Size = GetSize();

        /// <summary>
        /// The size of the type in bits
        /// </summary>
        public static readonly int BitSize = Size*8;
        
        static int GetSize()
        {
            if(typematch<T,byte>() || typematch<T,sbyte>())
                return 1;
            else if (typematch<T,short>() || typematch<T,ushort>())
                return 2;
            else if (typematch<T,int>() || typematch<T,uint>() || typematch<T,float>())
                return 4;
            else if (typematch<T,long>() || typematch<T,ulong>() || typematch<T,double>())
                return 8;
            else if (typematch<T,decimal>())
                return 16;
            return -1;
        }
    }


}