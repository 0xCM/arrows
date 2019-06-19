//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Z0;
 
    using static zfunc;
    using static As;

    public static class BitStringConvert
    {
        public static BitString FromValue<T>(in T src, bool tlz = false)
            where T : struct
        {
            var count = SizeOf<T>.BitSize;
            var dst = new char[count];
            var last = count - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = gbits.test(in src,i) 
                              ? AsciDigits.A1 
                              : AsciDigits.A0;
            
            var bsRaw = new string(dst);
            if(!tlz)
                return BitString.Define(bsRaw);

            bsRaw = tlz ? bsRaw.TrimStart(AsciDigits.A0) : bsRaw;
            
            if(tlz &&  bsRaw == string.Empty)
                bsRaw += AsciDigits.A0;
            
            return BitString.Define(bsRaw);            
        }


        [MethodImpl(Inline)]
        public static T ToValue<T>(BitString src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.parse(src, 0, out sbyte _));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.parse(src, 0, out byte _));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.parse(src, 0, out short _));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.parse(src, 0, out ushort _));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.parse(src, 0, out int _));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.parse(src, 0, out uint _));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.parse(src, 0, out long _));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.parse(src, 0, out ulong _));
            else
                throw unsupported<T>();
        }

    }

}