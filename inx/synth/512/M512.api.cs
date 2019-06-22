//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    public static class m512
    {
        [MethodImpl(Inline)]
        public static unsafe M512 define<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var srcByteCount = src.Length * Unsafe.SizeOf<T>();
            var maxCopyCount = Math.Min(64, srcByteCount);        
            ref var refSrc = ref As.asRef(in src[0]);
            var pSrc = Unsafe.AsPointer(ref refSrc);
            var dst = default(M512);
            Buffer.MemoryCopy(pSrc, &dst, 64, maxCopyCount);
            return dst;            
        }

        /// <summary>
        /// Defines and initializes all parts of the structure to a specified value
        /// </summary>
        /// <param name="x">The value to broadcast</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static M512 define<T>(T x)
            where T : struct
        {
            var dst = default(M512);
            for(var i=0; i< M512.PartCount<T>(); i++)
                dst.part<T>(i) = x;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Bit pop(M512 src)
            => Bits.pop(src.x0) + Bits.pop(src.x1) + Bits.pop(src.x2) + Bits.pop(src.x3)
             + Bits.pop(src.x4) + Bits.pop(src.x5) + Bits.pop(src.x6) + Bits.pop(src.x7);        

        [MethodImpl(Inline)]
        public static Bit test<T>(M512 src, int partIx, int offset)
            where T : struct
                => gbits.test(in src.part<T>(partIx), offset);

        [MethodImpl(Inline)]
        public static void enable<T>(ref M512 src, int partIx, int offset)
            where T : struct
                => gbits.enable(ref src.part<T>(partIx), offset);

        [MethodImpl(Inline)]
        public static void disable<T>(ref M512 src, int partIx, int offset)
            where T : struct
                => gbits.disable(ref src.part<T>(partIx), offset);

        [MethodImpl(Inline)]
        public static void toggle<T>(ref M512 src, int partIx, int offset)
            where T : struct
                => gbits.toggle(ref src.part<T>(partIx), offset);

        [MethodImpl(Inline)]
        public static ref M512 define<T>(T x, out M512 dst)
            where T : struct
        {
            dst = default(M512);
            for(var i=0; i< M512.PartCount<T>(); i++)
                dst.part<T>(i) = x;
            return ref dst;
        }

        public static BitString bitstring(in M512 src)
        {   
            return BitString.Assemble(
                src.x0.ToBitString(), 
                src.x1.ToBitString(), 
                src.x2.ToBitString(), 
                src.x3.ToBitString(), 
                src.x4.ToBitString(), 
                src.x5.ToBitString(), 
                src.x6.ToBitString(), 
                src.x7.ToBitString() 
                );            
        }
        
        public static HexString hexstring(in M512 src)
        {   
            var sb = sbuild();
            sb.Append(src.x7.ToHexString());
            sb.Append(src.x6.ToHexString());
            sb.Append(src.x5.ToHexString());
            sb.Append(src.x4.ToHexString());
            sb.Append(src.x3.ToHexString());
            sb.Append(src.x2.ToHexString());
            sb.Append(src.x1.ToHexString());
            sb.Append(src.x0.ToHexString());
            return HexString.Define(sb.ToString());            
        }
    }

}