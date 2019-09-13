//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;


    public static class MemView
    {
        [MethodImpl(Inline)]
        static short ToInt16Safe(ReadOnlySpan<byte> src)
        {
            require(src.Length >= sizeof(short));
                
            return Unsafe.ReadUnaligned<short>(ref head(src));
        }

        [MethodImpl(Inline)]
        static short ToInt16Safe(byte[] value, int offset)
        {
            require(offset <= value.Length - sizeof(short));            

            return Unsafe.ReadUnaligned<short>(ref value[offset]);
        }



        [MethodImpl(Inline)]
        public static short int16(ReadOnlySpan<byte> src, int offset)
            => Unsafe.ReadUnaligned<short>(ref cellref(src, offset));

        [MethodImpl(Inline)]
        public static short int16(byte[] src, int offset)        
            => Unsafe.ReadUnaligned<short>(ref src[offset]);

        [MethodImpl(Inline)]
        public static ushort uint16(ReadOnlySpan<byte> src, int offset)
            => Unsafe.ReadUnaligned<ushort>(ref cellref(src, offset));

        [MethodImpl(Inline)]
        public static ushort uint16(byte[] src, int offset)        
            => Unsafe.ReadUnaligned<ushort>(ref src[offset]);



    }


}