namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;

    public static partial class InXS128
    {
        static readonly PrimalIndex AddLU = PrimalIndex.define(
            @uint : default(AddU32),
            @float : default(AddF32),
            @double : default(AddF64)
        );

        readonly ref struct AddU32
        {
            public readonly Vec128<uint> Result;

            [MethodImpl(Inline)]
            public static implicit operator Vec128<uint>(AddU32 src)
                => src.Result;

            [MethodImpl(Inline)]
            public AddU32(Vec128<uint> lhs, Vec128<uint> rhs)
                => Result = Avx2.Add(lhs,rhs);        
            
            [MethodImpl(Inline)]
            public AddU32 Recompute(Vec128<uint> lhs, Vec128<uint> rhs)
                => new AddU32(lhs,rhs);
        }

        readonly ref struct AddF32
        {
            public readonly Vec128<float> Result;

            [MethodImpl(Inline)]
            public static implicit operator Vec128<float>(AddF32 src)
                => src.Result;

            [MethodImpl(Inline)]
            public AddF32(Vec128<float> lhs, Vec128<float> rhs)
                => Result = Avx2.Add(lhs,rhs);        
            
            [MethodImpl(Inline)]
            public AddF32 Recompute(Vec128<float> lhs, Vec128<float> rhs)
                => new AddF32(lhs,rhs);
        }

        readonly ref struct AddF64
        {
            public readonly Vec128<double> Result;

            [MethodImpl(Inline)]
            public static implicit operator Vec128<double>(AddF64 src)
                => src.Result;

            [MethodImpl(Inline)]
            public AddF64(Vec128<double> lhs, Vec128<double> rhs)
                => Result = Avx2.Add(lhs,rhs);        
            
            [MethodImpl(Inline)]
            public AddF64 Recompute(Vec128<double> lhs, Vec128<double> rhs)
                => new AddF64(lhs,rhs);
        }

        static Vec128<uint> Add(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx2.Add(lhs,rhs);        

        static Vec128<float> Add(Vec128<float> lhs, Vec128<float> rhs)
                => Avx2.Add(lhs,rhs);        

        static Vec128<double> Add(Vec128<double> lhs, Vec128<double> rhs)
                => Avx2.Add(lhs,rhs);        



        [MethodImpl(Inline)]
        static unsafe Vec128<uint> Load(uint[] src, int offset)
        {
            fixed(uint* pSrc = &src[offset])
                return Avx2.LoadVector128(pSrc);
        }
         
        [MethodImpl(Inline)]
        static unsafe Vec128<float> Load(float[] src, int offset)
        {
            fixed(float* pSrc = &src[offset])
                return Avx2.LoadVector128(pSrc);
        }

        [MethodImpl(Inline)]
        static unsafe Vec128<double> Load(double[] src, int offset)
        {
            fixed(double* pSrc = &src[offset])
                return Avx2.LoadVector128(pSrc);
        }


        [MethodImpl(Inline)]
        static unsafe void Store(Vec128<uint> src, uint[] dst, int offset )
        {
            fixed(uint* pDst = &dst[offset])
                Avx2.Store(pDst,src);
        }

        [MethodImpl(Inline)]
        static unsafe void Store(Vec128<float> src, float[] dst, int offset )
        {
            fixed(float* pDst = &dst[offset])
                Avx2.Store(pDst,src);
        }

        [MethodImpl(Inline)]
        static unsafe void Store(Vec128<double> src, double[] dst, int offset )
        {
            fixed(double* pDst = &dst[offset])
                Avx2.Store(pDst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store<T>(Vec128<T> src, T[] dst, int offset )
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.uint32)
                Store(src.As<uint>(), Unsafe.As<uint[]>(src), offset);
            else if(kind == PrimalKind.float32)
                Store(src.As<float>(), Unsafe.As<float[]>(src), offset);
            else if(kind == PrimalKind.float64)
                Store(src.As<double>(), Unsafe.As<double[]>(src), offset);
            else
                throw new NotSupportedException();

        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<T> load<T>(T[] src, int offset)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind == PrimalKind.uint32)
                return Load(Unsafe.As<uint[]>(src), offset).As<T>();

            if(kind == PrimalKind.float32)
                return Load(Unsafe.As<float[]>(src), offset).As<T>();

            if(kind == PrimalKind.float64)
                return Load(Unsafe.As<double[]>(src), offset).As<T>();

            throw new NotSupportedException();
        }

    }
    partial class InX
    {

        //! scalar addition
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<float> lhs, in Num128<float> rhs, out Num128<float> dst)
            => dst = Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<double> lhs, in Num128<double> rhs, out Num128<double> dst)
            => dst = Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs, void* dst)
            => Avx2.StoreScalar((float*)dst,Avx2.AddScalar(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<double> lhs, in Num128<double> rhs, void* dst)
            => Avx2.StoreScalar((double*)dst,Avx2.AddScalar(lhs, rhs));

        //! add: vec -> vec -> vec
        //! -------------------------------------------------------------------

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

        [MethodImpl(Inline)]
        public static Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Add(lhs, rhs);


        //! add: vec -> vec -> dst*
        //! -------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, void* dst)
            => Avx2.Store((sbyte*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, void* dst)
            => Avx2.Store((byte*)dst, Avx2.Add(lhs,rhs));

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


        //! add: ptr[T] -> ptr[T] -> ptr[T]
        //! --------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void add(sbyte* lhs, sbyte* rhs, sbyte* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(byte* lhs, byte* rhs, byte* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(short* lhs, short* rhs, short* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(ushort* lhs, ushort* rhs, ushort* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(int* lhs, int* rhs, int* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(uint* lhs, uint* rhs, uint* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(long* lhs, long* rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(ulong* lhs, ulong* rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

 
         //! add: index -> index -> index
        //! --------------------------------------------------------------------

        public static unsafe Index<sbyte> add(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var vLen = Vector128<sbyte>.Count;
            var dst = new sbyte[matchedCount(lhs,rhs)];

            fixed(sbyte* pLhs = &(lhs.ToArray()[0]))
            fixed(sbyte* pRhs = &(rhs.ToArray()[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    add(pLeft, pRight, pTarget);

            }
            return dst;
        }

        public static unsafe Index<byte> add(Index<byte> lhs, Index<byte> rhs)
        {
            var len = Vector128<byte>.Count;
            var dst = new byte[matchedCount(lhs,rhs)];

            fixed(byte* pLhs = &(lhs.ToArray()[0]))
            fixed(byte* pRhs = &(rhs.ToArray()[0]))
            fixed(byte* pDst = &dst[0])
            {
                byte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<short> add(Index<short> lhs, Index<short> rhs)
        {
            var len = Vector128<short>.Count;
            var dst = new short[matchedCount(lhs,rhs)];

            fixed(short* pLhs = &(lhs.ToArray()[0]))
            fixed(short* pRhs = &(rhs.ToArray()[0]))
            fixed(short* pDst = &dst[0])
            {
                short* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ushort> add(Index<ushort> lhs, Index<ushort> rhs)
        {
            var len = Vector128<ushort>.Count;
            var dst = new ushort[matchedCount(lhs,rhs)];

            fixed(ushort* pLhs = &(lhs.ToArray()[0]))
            fixed(ushort* pRhs = &(rhs.ToArray()[0]))
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<int> add(Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new int[matchedCount(lhs,rhs)];

            fixed(int* pLhs = &(lhs.ToArray()[0]))
            fixed(int* pRhs = &(rhs.ToArray()[0]))
            fixed(int* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<uint> add(Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<uint>.Count;
            var dst = new uint[matchedCount(lhs,rhs)];

            fixed(uint* pLhs = &(lhs.ToArray()[0]))
            fixed(uint* pRhs = &(rhs.ToArray()[0]))
            fixed(uint* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<long> add(Index<long> lhs, Index<long> rhs)
        {
            var len = Vector128<long>.Count;
            var dst = new long[matchedCount(lhs,rhs)];

            fixed(long* pLhs = &(lhs.ToArray()[0]))
            fixed(long* pRhs = &(rhs.ToArray()[0]))
            fixed(long* pDst = &dst[0])
            {
                long* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ulong> add(Index<ulong> lhs, Index<ulong> rhs)
        {
            var len = Vector128<ulong>.Count;
            var dst = new ulong[matchedCount(lhs,rhs)];

            fixed(ulong* pLhs = &(lhs.ToArray()[0]))
            fixed(ulong* pRhs = &(rhs.ToArray()[0]))
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<float> add(Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var dst = new float[matchedCount(lhs,rhs)];

            fixed(float* pLhs = &(lhs.ToArray()[0]))
            fixed(float* pRhs = &(rhs.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<double> add(Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var dst = new double[matchedCount(lhs,rhs)];

            fixed(double* pLhs = &(lhs.ToArray()[0]))
            fixed(double* pRhs = &(rhs.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        static readonly PrimalIndex AddLU
            = PrimalKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.add),
                @byte: new PrimalFusedBinOp<byte>(InX.add),
                @short: new PrimalFusedBinOp<short>(InX.add),
                @ushort: new PrimalFusedBinOp<ushort>(InX.add),
                @int: new PrimalFusedBinOp<int>(InX.add),
                @uint: new PrimalFusedBinOp<uint>(InX.add),
                @long: new PrimalFusedBinOp<long>(InX.add),
                @ulong: new PrimalFusedBinOp<ulong>(InX.add),
                @float: new PrimalFusedBinOp<float>(InX.add),
                @double:new PrimalFusedBinOp<double>(InX.add)
                );

        internal readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = AddLU.lookup<T,PrimalFusedBinOp<T>>();
        }


       [MethodImpl(Inline)]
        public static Vec128<T> addg<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int16)
                return Avx2.Add(lhs.As<short>(), rhs.As<short>()).As<short,T>();

            if(kind == PrimalKind.uint16)
                return Avx2.Add(lhs.As<ushort>(), rhs.As<ushort>()).As<ushort,T>();

            if(kind == PrimalKind.int32)
                return Avx2.Add(lhs.As<int>(), rhs.As<int>()).As<int,T>();

            if(kind == PrimalKind.uint32)
                return Avx2.Add(lhs.As<uint>(), rhs.As<uint>()).As<uint,T>();

            if(kind == PrimalKind.int64)
                return Avx2.Add(lhs.As<long>(), rhs.As<long>()).As<long,T>();

            if(kind == PrimalKind.uint64)
                return Avx2.Add(lhs.As<ulong>(), rhs.As<ulong>()).As<ulong,T>();

            if(kind == PrimalKind.float32)
                return Avx2.Add(lhs.As<float>(), rhs.As<float>()).As<float,T>();

            if(kind == PrimalKind.float64)
                return Avx2.Add(lhs.As<double>(), rhs.As<double>()).As<double,T>();

            throw new NotSupportedException();
        }

        public static Vec128BinOp<T> addg<T>()
            where T : struct, IEquatable<T>
                => addg<T>;
        
        public static Index<T> addg<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.float64)
            {
                var result = add(
                    Unsafe.As<Index<T>, Index<double>>(ref lhs),
                    Unsafe.As<Index<T>, Index<double>>(ref rhs)
                    );
                return Unsafe.As<Index<double>, Index<T>>(ref result);
            }
            throw new NotSupportedException();

        }
    }
}