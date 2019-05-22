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
    
    using static mfunc;
    using static zfunc;

    public static partial class As
    {

        [MethodImpl(Inline)]
        internal static ref Num128<sbyte> primal<T>(ref Num128<T> src, out Num128<sbyte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<sbyte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<byte> primal<T>(ref Num128<T> src, out Num128<byte> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<byte>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<short> primal<T>(ref Num128<T> src, out Num128<short> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<short>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<ushort> primal<T>(ref Num128<T> src, out Num128<ushort> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<ushort>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<int> primal<T>(ref Num128<T> src, out Num128<int> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<int>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<uint> primal<T>(ref Num128<T> src, out Num128<uint> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<uint>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<long> primal<T>(ref Num128<T> src, out Num128<long> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<long>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<ulong> primal<T>(ref Num128<T> src, out Num128<ulong> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<ulong>>(ref src);
             return ref dst;
        }


        [MethodImpl(Inline)]
        internal static ref Num128<float> primal<T>(ref Num128<T> src, out Num128<float> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<float>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref Num128<double> primal<T>(ref Num128<T> src, out Num128<double> dst)
            where T : struct        
        {            
             dst = Unsafe.As<Num128<T>, Num128<double>>(ref src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        internal static ref  Num128<sbyte> int8<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<byte> uint8<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<short> int16<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<ushort> uint16<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<int> int32<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<uint> uint32<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<long> int64<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<ulong> uint64<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<ulong>>(ref src);

                        
        [MethodImpl(Inline)]
        internal static ref Num128<float> float32<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<float>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<double> float64<T>(ref Num128<T> src)
            where T : struct        
                => ref Unsafe.As<Num128<T>,Num128<double>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<sbyte> src)
            where T : struct        
            => ref Unsafe.As<Num128<sbyte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<byte> src)
            where T : struct        
            => ref Unsafe.As<Num128<byte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<short> src)
            where T : struct        
            => ref Unsafe.As<Num128<short>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Num128<ushort>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<int> src)
            where T : struct        
            => ref Unsafe.As<Num128<int>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<uint> src)
            where T : struct        
            => ref Unsafe.As<Num128<uint>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<long> src)
            where T : struct        
            => ref Unsafe.As<Num128<long>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<ulong> src)
            where T : struct        
            => ref Unsafe.As<Num128<ulong>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<float> src)
            where T : struct        
            => ref Unsafe.As<Num128<float>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<double> src)
            where T : struct        
            => ref Unsafe.As<Num128<double>,Num128<T>>(ref src);
    }
}