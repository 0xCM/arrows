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

    partial class As
    {

        [MethodImpl(Inline)]
        public static ref Vec128<sbyte> int8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<sbyte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<byte> uint8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<short> int16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<ushort> uint16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref  Vec128<int> int32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<uint> uint32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<long> int64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> uint64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<float> float32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<double> float64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<sbyte> int8<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<byte> uint8<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<short> int16<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ushort> uint16<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref  Vector128<int> int32<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<uint> uint32<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<long> int64<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ulong> uint64<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<float> float32<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<double> float64<T>(in Vector128<T> src)
            where T : struct        
                => ref Unsafe.As<Vector128<T>,Vector128<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<byte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<short> src)
            where T : struct        
                => ref Unsafe.As<Vec128<short>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ushort>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<int> src)
            where T : struct        
                => ref Unsafe.As<Vec128<int>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec128<uint>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<long> src)
            where T : struct        
                => ref Unsafe.As<Vec128<long>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ulong>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<float> src)
            where T : struct        
                => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<double> src)
            where T : struct        
                => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<byte> src)
            where T : struct        
                => ref Unsafe.As<Vector128<byte>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<short> src)
            where T : struct        
                => ref Unsafe.As<Vector128<short>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vector128<ushort>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<int> src)
            where T : struct        
                => ref Unsafe.As<Vector128<int>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<uint> src)
            where T : struct        
                => ref Unsafe.As<Vector128<uint>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<long> src)
            where T : struct        
                => ref Unsafe.As<Vector128<long>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vector128<ulong>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<float> src)
            where T : struct        
                => ref Unsafe.As<Vector128<float>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<double> src)
            where T : struct        
                => ref Unsafe.As<Vector128<double>,Vector128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<sbyte> int8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        public static ref Vec256<byte> uint8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<short> int16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<ushort> uint16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref  Vec256<int> int32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<uint> uint32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<long> int64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<ulong> uint64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<float> float32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<double> float64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<byte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<short> src)
            where T : struct        
                => ref Unsafe.As<Vec256<short>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ushort>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<int> src)
            where T : struct        
                => ref Unsafe.As<Vec256<int>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec256<uint>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<long> src)
            where T : struct        
                => ref Unsafe.As<Vec256<long>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ulong>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<float> src)
            where T : struct        
                => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<double> src)
            where T : struct        
                => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref asRef(in src));


        [MethodImpl(Inline)]
        public static ref Vector256<sbyte> int8<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        public static ref Vector256<byte> uint8<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<short> int16<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ushort> uint16<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref  Vector256<int> int32<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<uint> uint32<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<long> int64<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ulong> uint64<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<float> float32<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<double> float64<T>(in Vector256<T> src)
            where T : struct        
                => ref Unsafe.As<Vector256<T>,Vector256<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<byte> src)
            where T : struct        
                => ref Unsafe.As<Vector256<byte>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<short> src)
            where T : struct        
                => ref Unsafe.As<Vector256<short>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vector256<ushort>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<int> src)
            where T : struct        
                => ref Unsafe.As<Vector256<int>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<uint> src)
            where T : struct        
                => ref Unsafe.As<Vector256<uint>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<long> src)
            where T : struct        
                => ref Unsafe.As<Vector256<long>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vector256<ulong>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<float> src)
            where T : struct        
                => ref Unsafe.As<Vector256<float>,Vector256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<double> src)
            where T : struct        
                => ref Unsafe.As<Vector256<double>,Vector256<T>>(ref asRef(in src));


        [MethodImpl(Inline)]
        public static ref Scalar128<sbyte> primal<T>(ref Scalar128<T> src, out Scalar128<sbyte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<sbyte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<byte> primal<T>(ref Scalar128<T> src, out Scalar128<byte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<byte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<short> primal<T>(ref Scalar128<T> src, out Scalar128<short> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<short>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<ushort> primal<T>(ref Scalar128<T> src, out Scalar128<ushort> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<ushort>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<int> primal<T>(ref Scalar128<T> src, out Scalar128<int> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<int>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<uint> primal<T>(ref Scalar128<T> src, out Scalar128<uint> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<uint>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<long> primal<T>(ref Scalar128<T> src, out Scalar128<long> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<long>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<ulong> primal<T>(ref Scalar128<T> src, out Scalar128<ulong> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<ulong>>(ref src);
             return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref Scalar128<float> primal<T>(ref Scalar128<T> src, out Scalar128<float> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<float>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Scalar128<double> primal<T>(ref Scalar128<T> src, out Scalar128<double> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Scalar128<T>, Scalar128<double>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref  Scalar128<sbyte> int8<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<byte> uint8<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<byte>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<short> int16<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<short>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<ushort> uint16<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<ushort>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<int> int32<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<int>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<uint> uint32<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<uint>>(ref src);

        [MethodImpl(Inline)]
        public static ref  Scalar128<long> int64<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<long>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<ulong> uint64<T>(ref Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<ulong>>(ref src);
                        
        [MethodImpl(Inline)]
        public static ref Scalar128<float> float32<T>(in Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Scalar128<double> float64<T>(in Scalar128<T> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<T>,Scalar128<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<sbyte> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<sbyte>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<byte> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<byte>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<short> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<short>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Scalar128<ushort>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<int> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<int>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<uint> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<uint>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<long> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<long>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<ulong> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<ulong>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<float> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<float>,Scalar128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Scalar128<T> generic<T>(ref Scalar128<double> src)
            where T : struct        
            => ref Unsafe.As<Scalar128<double>,Scalar128<T>>(ref src);
    }

}