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

    public static class Vector128X
    {

        public static bool IsNaN(this float src)
            => float.IsNaN(src);

        public static bool IsNaN(this double src)
            => double.IsNaN(src);

        //! NaN
        //! -------------------------------------------------------------------

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool TestNaNScalar(this Vector128<float> src)
                => src.GetElement(0).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool TestNaNScalar(this Vector128<double> src)
                => src.GetElement(0).IsNaN();

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector128<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector128<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN()
                );


        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector256<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN(),
                src.GetElement(4).IsNaN(), 
                src.GetElement(5).IsNaN(),
                src.GetElement(6).IsNaN(), 
                src.GetElement(7).IsNaN()
                );


        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector256<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        
 
        //! Store
        //!--------------------------------------------------------------------

        #region Store

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<byte> src, byte* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<sbyte> src, sbyte* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<short> src, short* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<ushort> src, ushort* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<int> src, int* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<uint> src, uint* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<long> src, long* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<ulong> src, ulong* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<float> src, float* dst)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void Store(this Vector128<double> src, double* dst)  
            => Avx2.Store(dst,src);
        #endregion Store

        //! Add
        //!--------------------------------------------------------------------

        #region Add

        [MethodImpl(Inline)]
        public static Vector128<sbyte> Add(this Vector128<sbyte> lhs, Vector128<sbyte> rhs)  
            => Avx2.Add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vector128<byte> Add(this Vector128<byte> lhs, Vector128<byte> rhs)  
            => Avx2.Add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vector128<short> Add(this Vector128<short> lhs, Vector128<short> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> Add(this Vector128<ushort> lhs, Vector128<ushort> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> Add(this Vector128<int> lhs, Vector128<int> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> Add(this Vector128<uint> lhs, Vector128<uint> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> Add(this Vector128<long> lhs, Vector128<long> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> Add(this Vector128<ulong> lhs, Vector128<ulong> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> Add(this Vector128<float> lhs, Vector128<float> rhs)  
            => Avx2.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> Add(this Vector128<double> lhs, Vector128<double> rhs)  
            => Avx2.Add(lhs,rhs);

        #endregion Add

        //! Sub
        //!--------------------------------------------------------------------

        #region Sub
        [MethodImpl(Inline)]
        public static Vector128<sbyte> Sub(this Vector128<sbyte> lhs, Vector128<sbyte> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<byte> Sub(this Vector128<byte> lhs, Vector128<byte> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> Sub(this Vector128<short> lhs, Vector128<short> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> Sub(this Vector128<ushort> lhs, Vector128<ushort> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> Sub(this Vector128<int> lhs, Vector128<int> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> Sub(this Vector128<uint> lhs, Vector128<uint> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> Sub(this Vector128<long> lhs, Vector128<long> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> Sub(this Vector128<ulong> lhs, Vector128<ulong> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> Sub(this Vector128<float> lhs, Vector128<float> rhs)  
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> Sub(this Vector128<double> lhs, Vector128<double> rhs)  
            => Avx2.Subtract(lhs,rhs);
        #endregion Sub
    
        //! Div
        //!--------------------------------------------------------------------

        #region  Div

        [MethodImpl(Inline)]
        public static Vector128<float> Div(this Vector128<float> lhs, in Vector128<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> Div(this Vector128<double> lhs, in Vector128<double> rhs)
            => Avx2.Divide(lhs, rhs);

        #endregion
    
    
        //! Add:vector128 -> vector128 -> * -> void

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<sbyte> lhs, Vector128<sbyte> rhs, sbyte* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<byte> lhs, Vector128<byte> rhs, byte* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<short> lhs, Vector128<short> rhs, short* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<ushort> lhs, Vector128<ushort> rhs, ushort* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<int> lhs, Vector128<int> rhs, int* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<uint> lhs, Vector128<uint> rhs, uint* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<long> lhs, Vector128<long> rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<ulong> lhs, Vector128<ulong> rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<float> lhs, Vector128<float> rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void Add(this Vector128<double> lhs, Vector128<double> rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Add(lhs,rhs));




    }
}