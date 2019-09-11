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
    
    using static zfunc;
    
    partial class BitsX
    {        
        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> AndNot(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> AndNot(this Vec256<byte> lhs, in Vec256<byte> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> AndNot(this Vec256<short> lhs, in Vec256<short> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> AndNot(this Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> AndNot(this Vec256<int> lhs, in Vec256<int> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> AndNot(this Vec256<uint> lhs, in Vec256<uint> rhs)
            => Bits.andn(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> AndNot(this Vec256<long> lhs, in Vec256<long> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> AndNot(this Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Bits.andn(in lhs, in rhs);
 
        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> AndNot(this Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> AndNot(this Vec128<byte> lhs, in Vec128<byte> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> AndNot(this Vec128<short> lhs, in Vec128<short> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> AndNot(this Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> AndNot(this Vec128<int> lhs, in Vec128<int> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> AndNot(this Vec128<uint> lhs, in Vec128<uint> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> AndNot(this Vec128<long> lhs, in Vec128<long> rhs)
            => Bits.andn(in lhs, in rhs);

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> AndNot(this Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Bits.andn(in lhs, in rhs);

 
    }
}