//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;
    using static As;

    public static class AsInX
    {

        [MethodImpl(Inline)]
        public static ref Num128<sbyte> primal<T>(ref Num128<T> src, out Num128<sbyte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<sbyte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<byte> primal<T>(ref Num128<T> src, out Num128<byte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<byte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<short> primal<T>(ref Num128<T> src, out Num128<short> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<short>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<ushort> primal<T>(ref Num128<T> src, out Num128<ushort> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<ushort>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<int> primal<T>(ref Num128<T> src, out Num128<int> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<int>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<uint> primal<T>(ref Num128<T> src, out Num128<uint> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<uint>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<long> primal<T>(ref Num128<T> src, out Num128<long> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<long>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<ulong> primal<T>(ref Num128<T> src, out Num128<ulong> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<ulong>>(ref src);
             return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref Num128<float> primal<T>(ref Num128<T> src, out Num128<float> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<float>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Num128<double> primal<T>(ref Num128<T> src, out Num128<double> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<double>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref  Num128<sbyte> int8<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<byte> uint8<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<byte>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<short> int16<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<short>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<ushort> uint16<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<ushort>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<int> int32<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<int>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<uint> uint32<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<uint>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Num128<long> int64<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<long>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<ulong> uint64<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<ulong>>(ref src);
                        
        [MethodImpl(Inline)]
        internal static ref Num128<float> float32<T>(in Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Num128<double> float64<T>(in Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<sbyte> src)
            where T : struct        
            => ref Unsafe.As<Num128<sbyte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<byte> src)
            where T : struct        
            => ref Unsafe.As<Num128<byte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<short> src)
            where T : struct        
            => ref Unsafe.As<Num128<short>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Num128<ushort>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<int> src)
            where T : struct        
            => ref Unsafe.As<Num128<int>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<uint> src)
            where T : struct        
            => ref Unsafe.As<Num128<uint>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<long> src)
            where T : struct        
            => ref Unsafe.As<Num128<long>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<ulong> src)
            where T : struct        
            => ref Unsafe.As<Num128<ulong>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<float> src)
            where T : struct        
            => ref Unsafe.As<Num128<float>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Num128<T> generic<T>(ref Num128<double> src)
            where T : struct        
            => ref Unsafe.As<Num128<double>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<sbyte> int8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        internal static ref Vec128<byte> uint8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<short> int16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<ushort> uint16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref  Vec128<int> int32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<uint> uint32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<long> int64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<ulong> uint64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<float> float32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<double> float64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<double>>(ref asRef(in src));



        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<byte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<short> src)
            where T : struct        
                => ref Unsafe.As<Vec128<short>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ushort>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<int> src)
            where T : struct        
                => ref Unsafe.As<Vec128<int>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec128<uint>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<long> src)
            where T : struct        
                => ref Unsafe.As<Vec128<long>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ulong>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<float> src)
            where T : struct        
                => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<double> src)
            where T : struct        
                => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref asRef(in src));
 
         [MethodImpl(Inline)]
        internal static ref Vec256<sbyte> int8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        internal static ref Vec256<byte> uint8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<short> int16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<ushort> uint16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref  Vec256<int> int32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<uint> uint32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<long> int64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<ulong> uint64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<float> float32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<double> float64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<byte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<short> src)
            where T : struct        
                => ref Unsafe.As<Vec256<short>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ushort>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<int> src)
            where T : struct        
                => ref Unsafe.As<Vec256<int>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec256<uint>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<long> src)
            where T : struct        
                => ref Unsafe.As<Vec256<long>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ulong>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<float> src)
            where T : struct        
                => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<double> src)
            where T : struct        
                => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref asRef(in src));
 

 
    }

}