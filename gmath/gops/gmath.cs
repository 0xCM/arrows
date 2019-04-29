//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using static zcore;
    using static mathops;



    public static partial class gmath
    {
        static void init<T>()
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            var g1 = one<T>();

            add<T>(array(g1), array(g1), alloc<T>(1));
            sub<T>(array(g1), array(g1), alloc<T>(1));
            mul<T>(array(g1), array(g1), alloc<T>(1));
            div<T>(array(g1), array(g1), alloc<T>(1));
            mod<T>(array(g1), array(g1), alloc<T>(1));
            abs<T>(array(g1), alloc<T>(1));
            
            if(kind.IsIntegral())
            {
                and<T>(array(g1), array(g1), alloc<T>(1));
                or<T>(array(g1), array(g1), alloc<T>(1));
                xor<T>(array(g1), array(g1), alloc<T>(1));
                flip<T>(array(g1), alloc<T>(1));
            }

        }
        public static void init()
        {
            init<sbyte>();
            init<byte>();
            init<short>();
            init<ushort>();
            init<int>();
            init<uint>();
            init<long>();
            init<ulong>();
            init<float>();
            init<double>();
            math.init();
        }

       public static T zero<T>()
           where T : struct, IEquatable<T>
            => default(T);

       public static T one<T>()
           where T : struct, IEquatable<T>
       {
             var kind = PrimalKinds.kind<T>();

             if(kind == PrimalKind.float32)
                return As.generic<T>(1f);

            if(kind == PrimalKind.float64)
                return As.generic<T>(1d);

            if(kind == PrimalKind.int32)
                return As.generic<T>(1);

            if(kind == PrimalKind.uint32)
                return As.generic<T>(1u);

            if(kind == PrimalKind.int64)
                return As.generic<T>(1L);

            if(kind == PrimalKind.uint64)
                return As.generic<T>(1UL);

            if(kind == PrimalKind.int16)
                return As.generic<T>((short)1);

            if(kind == PrimalKind.uint16)
                return As.generic<T>((ushort)1);

            if(kind == PrimalKind.int8)
                return As.generic<T>((sbyte)1);

            if(kind == PrimalKind.uint8)
                return As.generic<T>((byte)1);
          
             throw new Exception("Kind not supported");
       }

        /// <summary>
        /// Applies an identified unary operator to a supplied operand
        /// </summary>
        /// <param name="src">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns>The operator application result</returns>
        [MethodImpl(Inline)]
        public static T apply<T>(OpKind op, T src)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Abs)
                return abs(src);

            if(op == OpKind.Flip)
                return flip(src);

            throw new Exception($"Operator {op} not supported");
        }

        /// <summary>
        /// Applies an identified binary operator to supplied operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns>The operator application result</returns>
        [MethodImpl(Inline)]
        public static T apply<T>(OpKind op, T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Add)
                return add(lhs,rhs);

            if(op == OpKind.Sub)
                return sub(lhs,rhs);

            if(op == OpKind.Mul)
                return mul(lhs,rhs);

            if(op == OpKind.Div)
                return div(lhs,rhs);

            if(op == OpKind.Mod)
                return mod(lhs,rhs);

            if(op == OpKind.And)
                return mul(lhs,rhs);

            if(op == OpKind.Or)
                return div(lhs,rhs);

            if(op == OpKind.XOr)
                return mod(lhs,rhs);

            throw new Exception($"Operator {op} not supported");
         }

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return addF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return addF64(lhs,rhs);

            if(kind == PrimalKind.int32)
                return addI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return addU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return addI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return addU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return addI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return addU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return addI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return addU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return subF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return subF64(lhs,rhs);

            if(kind == PrimalKind.int32)
                return subI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return subU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return subI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return subU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return subI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return subU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return subI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return subU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return mulF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return mulF64(lhs,rhs);

            if(kind == PrimalKind.int32)
                return mulI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return mulU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return mulI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return mulU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return mulI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return mulU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return mulI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return mulU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return divF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return divF64(lhs,rhs);

            if(kind == PrimalKind.int32)
                return divI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return divU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return divI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return divU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return divI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return divU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return divI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return divU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }

       [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return modF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return modF64(lhs,rhs);

            if(kind == PrimalKind.int32)
                return modI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return modU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return modI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return modU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return modI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return modU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return modI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return modU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }           

       [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return andI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return andU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return andI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return andU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return andI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return andU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return andI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return andU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }           

       [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return orI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return orU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return orI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return orU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return orI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return orU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return orI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return orU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }           

        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return xorI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return xorU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return xorI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return xorU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return xorI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return xorU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return xorI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return xorU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }           

       [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return flipI32(src);

            if(kind == PrimalKind.uint32)
                return flipU32(src);

            if(kind == PrimalKind.int64)
                return flipI64(src);

            if(kind == PrimalKind.uint64)
                return flipU64(src);

            if(kind == PrimalKind.int16)
                return flipI16(src);

            if(kind == PrimalKind.uint16)
                return flipU16(src);

            if(kind == PrimalKind.int8)
                return flipI8(src);

            if(kind == PrimalKind.uint8)
                return flipU8(src);

            throw new Exception("Kind not supported");
        }           


       [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return absF32(src);

            if(kind == PrimalKind.float64)
                return absF64(src);

            if(kind == PrimalKind.int32)
                return absI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return absI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.int16)
                return absI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int8)
                return absI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            throw new Exception($"Kind {kind} not supported");
        }           

    }
}