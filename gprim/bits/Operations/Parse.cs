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
    using static As;
    partial class Bits
    {                

        [MethodImpl(Inline)]
        static bool HasBitSpecifier(in ReadOnlySpan<char> bs)
        {
            if(bs.Length < 2)
                return false;
            var last = bs.Length - 1;
            return bs[0] == '0' && bs[1] == 'b';        
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> IgnoreBitSpecifier(in ReadOnlySpan<char> bs)
            =>  HasBitSpecifier(bs) ? bs.Slice(2) : bs;


        [MethodImpl(Inline)]
        public static ref sbyte parse(in ReadOnlySpan<char> bs, in int offset, out sbyte dst)
        {
            parse(bs, offset, out byte x);
            dst = (sbyte)x;
            return ref dst;                                                
        }

        [MethodImpl(Optimize)]
        public static ref byte parse(in ReadOnlySpan<char> bs, in int offset, out byte dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U8BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    enable(ref dst, last - i);
                        
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short parse(in ReadOnlySpan<char> bs, in int offset, out short dst)
        {
            parse(bs, offset, out short x);
            dst = (short)x;
            return ref dst;                                                            
        }

        [MethodImpl(Optimize)]
        public static ref ushort parse(in ReadOnlySpan<char> bs, in int offset, out ushort dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U16BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    enable(ref dst, last - i);
                        
            return ref dst;
        }


        [MethodImpl(Optimize)]
        public static ref int parse(in ReadOnlySpan<char> bs, in int offset, out int dst)
        {
            parse(bs, offset, out int x);
            dst = (int)x;
            return ref dst;                                                
        }

        [MethodImpl(Optimize)]
        public static ref uint parse(in ReadOnlySpan<char> bs, in int offset, out uint dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U32BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    enable(ref dst, last - i);
                        
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long parse(in ReadOnlySpan<char> bs, in int offset, out long dst)
        {
            parse(bs, offset, out long x);
            dst = (long)x;
            return ref dst;                                                
        }

        [MethodImpl(Optimize)]
        public static ref ulong parse(in ReadOnlySpan<char> bs, in int offset, out ulong dst)
        {            
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U64BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    enable(ref dst, last - i);
                        
            return ref dst;
        }
    }
}