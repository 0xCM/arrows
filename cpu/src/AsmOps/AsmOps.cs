//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public static class AsmOps
    {
        readonly struct DivRemOp<T>
            where T : struct
        {
            static readonly AsmQuadOp<T> Op = AsmQuadOp.Create<T>(AsmCodeBank.DivRemI32);
            
            public static readonly DivRemOp<T> TheOnly = default;

            [MethodImpl(Inline)]
            public void Invoke(T lhs, T rhs, out T q, out T r)
                => Op(lhs, rhs, out q, out r);
        }

        /// <summary>
        /// Invokes the asm code for int32 addition
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static int Add(int x, int y)
            => AsmCodeBank.Add32I.CreateBinOpPI<int>()(x,y);
 
        /// <summary>
        /// Invokes the asm code for int8 bitwise and
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static sbyte And(sbyte x, sbyte y)
            => AsmCodeBank.And8I.CreateBinOpPI<sbyte>()(x,y);

        /// <summary>
        /// Invokes the asm code for uint8 bitwise and
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static byte And(byte x, byte y)
            => AsmCodeBank.And8U.CreateBinOpPI<byte>()(x,y);

        [MethodImpl(Inline)]
        public static void DivRem(int x, int y, out int q, out int r)
            => DivRemOp<int>.TheOnly.Invoke(x, y, out q, out r);
         
    }


}