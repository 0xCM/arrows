//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {

        [MethodImpl(Inline)]
        public static BlockVector<N,T> xor<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            gbitspan.xor(x.Data,y.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sll<N,T>(BlockVector<N,T> src, byte offset, BlockVector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gbitspan.sll(src.Data, offset, dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sll<N,T>(BlockVector<N,T> src, byte offset)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            sll(src, offset, dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> srl<N,T>(BlockVector<N,T> src, byte offset, ref BlockVector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gbitspan.srl(src.Data,offset,dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> srl<N,T>(BlockVector<N,T> src, byte offset)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            return srl(src,offset,ref dst);
        }




        [MethodImpl(Inline)]
        public static ref Covector<N,T> ipow<N,T>(ref Covector<N,T> lhs, in Covector<N,uint> exp)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            mathspan.pow(lhs.Span, exp.Span);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> ipow<N,T>(ref Covector<N,T> lhs, in uint rhs)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            mathspan.pow(lhs.Span, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> flip<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            mathspan.flip(src.Span);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> negate<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            mathspan.negate(src.Span);
            return ref src;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> mul<T>(ref BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : struct
        {
            mathspan.mul(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> mul<N,T>(ref BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            mathspan.mul(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }




        /// <summary>
        /// Computes lhs[i] := lhs[i] ^ rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> xor<N,T>(ref BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged

        {
            mathspan.xor(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] ^ rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> xor<N,T>(ref BlockVector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : unmanaged

        {
            mathspan.xor(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := pow(lhs[i],rhs)  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> pow<N,T>(ref BlockVector<N,T> lhs, uint rhs)
            where N : ITypeNat, new()
            where T : unmanaged

        {
            mathspan.pow(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Peforms a bitwise complement on each component in-place: io[i] := ~io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The source/target operand will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> flip<N,T>(ref BlockVector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            mathspan.flip(src.Unsized);
            return ref src;
        }

        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> inc<T>(ref BlockVector<T> src)
            where T : struct
        {
            mathspan.inc(src.Unblocked);
            return ref src;
        }
        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> inc<N,T>(ref BlockVector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            mathspan.inc(src.Unsized);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref BlockVector<T> dec<T>(ref BlockVector<T> src)
            where T : struct
        {
            mathspan.dec(src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Decrements each source vector component in-place: io[i] := --io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> dec<N,T>(ref BlockVector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            mathspan.dec(src.Unsized);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static BlockVector<N,T> redim<M,N,T>(in BlockVector<M,T> src, N newdim = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BlockVector<N, T>.LoadAligned(src.Unsized);


        [MethodImpl(Inline)]
        public static BlockVector<P,T> concat<M,N,P,T>(in BlockVector<M,T> head, BlockVector<N,T> tail, P sum = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : INatSum<M,N>, new()
            where T : struct
        {
            var dst = span<T>(new NatSum<M,N>());
            head.Unsized.CopyTo(dst);
            tail.Unsized.CopyTo(dst.Slice((int)new M().value));
            return BlockVector<P,T>.LoadAligned(dst);
        }
    }
}