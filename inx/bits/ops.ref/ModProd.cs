//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int ModProd(BitVector4 lhs, BitVector4 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int ModProd(BitVector8 lhs, BitVector8 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int ModProd(BitVector16 lhs, BitVector16 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <returns></returns>
        public static int ModProd(BitVector32 lhs, BitVector32 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <returns></returns>
        public static int ModProd(BitVector64 lhs, BitVector64 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <returns></returns>
        public static int ModProd<T>(BitVector<T> lhs, BitVector<T> rhs)
            where T : struct
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <returns></returns>
        public static int ModProd<N,T>(BitVector<N,T> lhs, BitVector<N,T> rhs)
            where T : struct
            where N : ITypeNat, new()
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }


    }

}