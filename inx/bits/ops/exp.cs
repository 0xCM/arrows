//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;


    partial class gbits
    {
        /// <summary>
        /// Given 2^n, finds n
        /// </summary>
        /// <param name="pow2">A value obtained by raising 2 to some power</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T exp<T>(T pow2)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(uint8(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint16(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint32(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint64(pow2));
            else
                throw unsupported<T>();
        }

    }

}