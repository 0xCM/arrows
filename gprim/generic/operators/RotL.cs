//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static T rotl<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.rotl(uint8(lhs), rhs));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.rotl(uint16(lhs), rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.rotl(uint32(lhs), rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.rotl(uint64(lhs), rhs));
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        public static ref Span<T> rotl<T>(ref Span<T> io, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var len = io.Length;
            for(var i=0; i<len; i++)
                io[i] = rotl(io[i],rhs[i]);
            return ref io;
        }

    }

}