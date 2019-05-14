//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
       [MethodImpl(NotInline)]
        static uint parse(ref uint dst, string bitstring)
        {
            var max = Math.Min(32, bitstring.Length);            
            for(var i = 0; i< max; i++)
                if(bitstring[i] != '0')
                    set(ref dst,i);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        static ulong parse(ref ulong dst, string bitstring)
        {
            var max = Math.Min(64, bitstring.Length);            
            for(var i = 0; i< max; i++)
                if(bitstring[i] != '0')
                    set(ref dst,i);            
            return dst;                                                

        }

        [MethodImpl(NotInline)]
        public static T parse<T>(string bitstring)
            where T : struct, IEquatable<T>
        {
            var prim = PrimalKinds.kind<T>();
            switch(prim)
            {
                case PrimalKind.uint64:
                {
                    var dst = 0ul;
                    parse(ref dst, bitstring);
                    return As.generic<T>(dst);
                }

                case PrimalKind.uint32:
                {
                    var dst = 0u;
                    parse(ref dst, bitstring);
                    return As.generic<T>(dst);
                }
                default:
                    throw new Exception($"Kind {prim} not supported");
            }
        }
    }
}