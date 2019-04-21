//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;


    public static partial class InXD
    {
        public readonly struct AddD<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Add = InXD.AddOp.Operator<T>();
            
            public static readonly Vec128BinOut<T> AddOut = InXD.AddOut.Operator<T>();
            
            public static readonly Vec128BinPOut<T> AddPOut = InXD.AddPOut.Operator<T>();
            
            public static readonly Vec128BinAOut<T> AddAOut = InXD.AddAOut.Operator<T>();


            [MethodImpl(Inline)]
            public static Vec128<T> add(in Vec128<T> lhs, in Vec128<T> rhs)
                => Add(lhs,rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
                => AddOut(lhs,rhs, out dst);
            
            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
                => AddPOut(lhs,rhs, dst);

            [MethodImpl(Inline)]
            public static void add(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
                => AddAOut(lhs,rhs, dst, offset);
        }

        readonly struct AddOp
        {
            static readonly Index<object> Delegates = PrimKinds.index<object>
                (@sbyte: binop<sbyte>(add),
                @byte: binop<byte>(add),
                @short: binop<short>(add),
                @ushort: binop<ushort>(add),
                @int: binop<int>(add),
                @uint: binop<uint>(add),
                @long: binop<long>(add),
                @ulong: binop<ulong>(add),
                @float: binop<float>(add),
                @double: binop<double>(add)
                );

            public static Vec128BinOp<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => (Vec128BinOp<T>) Delegates[PrimKinds.index<T>()];

            [MethodImpl(Inline)]
            public static Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.Add(lhs, rhs);

        }

        readonly struct AddOut
        {
            static readonly Index<object> Delegates = PrimKinds.index<object>
                (@sbyte: binout<sbyte>(add),
                @byte: binout<byte>(add),
                @short: binout<short>(add),
                @ushort: binout<ushort>(add),
                @int: binout<int>(add),
                @uint: binout<uint>(add),
                @long: binout<long>(add),
                @ulong: binout<ulong>(add),
                @float: binout<float>(add),
                @double: binout<double>(add)
                );

            public static Vec128BinOut<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => (Vec128BinOut<T>) Delegates[PrimKinds.index<T>()];


            [MethodImpl(Inline)]
            public static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, out Vec128<byte> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, out Vec128<sbyte> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<short> lhs, in Vec128<short> rhs, out Vec128<short> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, out Vec128<ushort> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<int> lhs, in Vec128<int> rhs, out Vec128<int> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, out Vec128<uint> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<long> lhs, in Vec128<long> rhs, out Vec128<long> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec128<ulong> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<float> lhs, in Vec128<float> rhs, out Vec128<float> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public static void add(in Vec128<double> lhs, in Vec128<double> rhs, out Vec128<double> dst)
                => dst = Avx2.Add(lhs, rhs);

        }
        
        unsafe readonly struct AddPOut
        {

            static readonly Index<object> Delegates = PrimKinds.index<object>
                (@sbyte: binpout<sbyte>(add),
                @byte: binpout<byte>(add),
                @short: binpout<short>(add),
                @ushort: binpout<ushort>(add),
                @int: binpout<int>(add),
                @uint: binpout<uint>(add),
                @long: binpout<long>(add),
                @ulong: binpout<ulong>(add),
                @float: binpout<float>(add),
                @double: binpout<double>(add)
                );

            public static Vec128BinPOut<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => (Vec128BinPOut<T>) Delegates[PrimKinds.index<T>()];

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, void* dst)
                => Avx2.Store((byte*)dst, Avx2.Add(lhs,rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, void* dst)
                => Avx2.Store((sbyte*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, void* dst)
                => Avx2.Store((short*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, void* dst)
                => Avx2.Store((ushort*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, void* dst)
                => Avx2.Store((int*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, void* dst)
                => Avx2.Store((uint*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, void* dst)
                => Avx2.Store((long*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, void* dst)
                => Avx2.Store((ulong*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, void* dst)
                => Avx2.Store((float*)dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, void* dst)
                => Avx2.Store((double*)dst, Avx2.Add(lhs, rhs));
    

        }

        readonly struct AddAOut
        {
            static readonly Index<object> Delegates = PrimKinds.index<object>
                (@sbyte: binaout<sbyte>(add),
                @byte: binaout<byte>(add),
                @short: binaout<short>(add),
                @ushort: binaout<ushort>(add),
                @int: binaout<int>(add),
                @uint: binaout<uint>(add),
                @long: binaout<long>(add),
                @ulong: binaout<ulong>(add),
                @float: binaout<float>(add),
                @double: binaout<double>(add)
                );

            public static Vec128BinAOut<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => (Vec128BinAOut<T>) Delegates[PrimKinds.index<T>()];

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte[] dst, int offset = 0)
            {
                fixed(byte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte[] dst, int offset = 0)
            {
                fixed(sbyte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, short[] dst, int offset = 0)
            {
                fixed(short* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort[] dst, int offset = 0)
            {
                fixed(ushort* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, int[] dst, int offset = 0)
            {
                fixed(int* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint[] dst, int offset = 0)
            {
                fixed(uint* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }
                    
            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, long[] dst, int offset = 0)
            {
                fixed(long* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong[] dst, int offset = 0)
            {
                fixed(ulong* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, float[] dst, int offset = 0)
            {
                fixed(float* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public static unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, double[] dst, int offset = 0)
            {
                fixed(double* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }
        }
    }
}