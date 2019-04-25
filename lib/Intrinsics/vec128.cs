//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using NumVec = System.Numerics.Vector;

    using static zcore;

    public static class vec128
    {
        //! load
        //!--------------------------------------------------------------------
        
        #region load
        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> load(byte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> load(sbyte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> load(short* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> load(ushort* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> load(int* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> load(uint* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> load(long* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> load(ulong* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<float> load(float* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> load(double* src)
            => Avx2.LoadVector128(src);
 
        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<byte> src, byte* dst)
            => Avx2.Store(dst,src);
        #endregion load

        //! store
        //!--------------------------------------------------------------------

        #region store
        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<sbyte> src, sbyte* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<short> src, short* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<ushort> src, ushort* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<int> src, int* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<uint> src, uint* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<long> src, long* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<ulong> src, ulong* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<float> src, float* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(Vector128<double> src, double* dst)  
            => Avx2.Store(dst,src);
        #endregion store

        //! add
        //!--------------------------------------------------------------------

        #region add

        [MethodImpl(Inline)]
        public static Vector128<sbyte> add(Vector128<sbyte> lhs, Vector128<sbyte> rhs)  
            => Avx2.Add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vector128<byte> add(Vector128<byte> lhs, Vector128<byte> rhs)  
            => Avx2.Add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vector128<short> add(Vector128<short> lhs, Vector128<short> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> add(Vector128<ushort> lhs, Vector128<ushort> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> add(Vector128<int> lhs, Vector128<int> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> add(Vector128<uint> lhs, Vector128<uint> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> add(Vector128<long> lhs, Vector128<long> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> add(Vector128<ulong> lhs, Vector128<ulong> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> add(Vector128<float> lhs, Vector128<float> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> add(Vector128<double> lhs, Vector128<double> rhs)  
            => Avx2.Add(lhs,rhs);

        #endregion add

        //! sub
        //!--------------------------------------------------------------------

        #region sub
        [MethodImpl(Inline)]
        public static Vector128<sbyte> sub(Vector128<sbyte> lhs, Vector128<sbyte> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<byte> sub(Vector128<byte> lhs, Vector128<byte> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> sub(Vector128<short> lhs, Vector128<short> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> sub(Vector128<ushort> lhs, Vector128<ushort> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> sub(Vector128<int> lhs, Vector128<int> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> sub(Vector128<uint> lhs, Vector128<uint> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> sub(Vector128<long> lhs, Vector128<long> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> sub(Vector128<ulong> lhs, Vector128<ulong> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> sub(Vector128<float> lhs, Vector128<float> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> sub(Vector128<double> lhs, Vector128<double> rhs)  
            => Avx2.Subtract(lhs,rhs);
        #endregion sub
    
        //! div
        //!--------------------------------------------------------------------

        #region  div

        [MethodImpl(Inline)]
        public static Vector128<float> div(in Vector128<float> lhs, in Vector128<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> div(in Vector128<double> lhs, in Vector128<double> rhs)
            => Avx2.Divide(lhs, rhs);

        #endregion
    
    
        //! add:vector128 -> vector128 -> * -> void

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<sbyte> lhs, Vector128<sbyte> rhs, sbyte* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<byte> lhs, Vector128<byte> rhs, byte* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<short> lhs, Vector128<short> rhs, short* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<ushort> lhs, Vector128<ushort> rhs, ushort* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<int> lhs, Vector128<int> rhs, int* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<uint> lhs, Vector128<uint> rhs, uint* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<long> lhs, Vector128<long> rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<ulong> lhs, Vector128<ulong> rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<float> lhs, Vector128<float> rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(Vector128<double> lhs, Vector128<double> rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));




    }
}