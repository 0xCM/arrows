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
            lt<T>(array(g1), array(g1), alloc<bool>(1));
            gt<T>(array(g1), array(g1), alloc<bool>(1));
            lteq<T>(array(g1), array(g1), alloc<bool>(1));
            gteq<T>(array(g1), array(g1), alloc<bool>(1));

            num.numbers<T>(g1);

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
            gfloat.init<float>();
            gfloat.init<double>();
            math.init();
        }

       public static T zero<T>()
           where T : struct, IEquatable<T>
            => default(T);

       public static T one<T>()
           where T : struct, IEquatable<T>
       {
             var kind = PrimalKinds.kind<T>();

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
          
             if(kind == PrimalKind.float32)
                return As.generic<T>(1f);

            if(kind == PrimalKind.float64)
                return As.generic<T>(1d);

             throw new Exception("Kind not supported");
       }


        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.uint8)
            {
                var l = (int)As.uint8<T>(lhs);
                var r = (int)As.uint8<T>(rhs);
                return As.generic<T>((byte)(l + r));                
            }


            if(kind == PrimalKind.int32)
                return addI32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return addI64(lhs,rhs);

            if(kind == PrimalKind.int8)
            {
                var l = (int)As.int8<T>(lhs);
                var r = (int)As.int8<T>(rhs);
                return As.generic<T>((sbyte)(l + r));                
            }

            if(kind == PrimalKind.uint32)
                return addU32(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return addU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return addI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return addU16(lhs,rhs);

            if(kind == PrimalKind.float32)
                return addF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return addF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");
        }

        [MethodImpl(Inline)]
        public static void add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        public static long addT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.add(lhs,rhs,dst);
            return elapsed(sw);
        }


        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


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

            if(kind == PrimalKind.float32)
                return subF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return subF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }


        [MethodImpl(Inline)]
        public static void sub<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        public static long subT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.sub(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


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

            if(kind == PrimalKind.float32)
                return mulF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return mulF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        public static long mulT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.mul(lhs,rhs,dst);
            return elapsed(sw);
        }


        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


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

            if(kind == PrimalKind.float32)
                return divF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return divF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void div<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        public static long divT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.div(lhs,rhs,dst);
            return elapsed(sw);
        }

       [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


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

            if(kind == PrimalKind.float32)
                return modF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return modF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }           

        [MethodImpl(Inline)]
        public static void mod<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static long modT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.mod(lhs,rhs,dst);
            return elapsed(sw);
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
        public static void and<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
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
        public static void or<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
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
        public static void xor<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
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
        public static void flip<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = flip(src[i]);
        }

       [MethodImpl(Inline)]
       public static T abs<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

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

            if(kind == PrimalKind.float32)
                return absF32(src);

            if(kind == PrimalKind.float64)
                return absF64(src);


            throw new Exception($"Kind {kind} not supported");
        }           

        [MethodImpl(Inline)]
        public static void abs<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = abs(src[i]);
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


            if(kind == PrimalKind.int32)
                return eqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return eqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return eqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return eqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return eqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return eqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return eqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return eqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return eqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return eqF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void eq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i],rhs[i]);
        }

       public static long eqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.eq(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


            if(kind == PrimalKind.int32)
                return neqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return neqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return neqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return neqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return neqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return neqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return neqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return neqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return neqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return neqF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void neq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i],rhs[i]);
        }

       public static long neqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.neq(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ltI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return ltU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return ltI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return ltU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return ltI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return ltU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return ltI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return ltU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return ltF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return ltF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void lt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i],rhs[i]);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return lteqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return lteqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return lteqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return lteqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return lteqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return lteqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return lteqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return lteqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return lteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return lteqF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void lteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i],rhs[i]);
        }


        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return gtI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return gtU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return gtI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return gtU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return gtI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return gtU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return gtI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return gtU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return gtF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gtF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void gt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i],rhs[i]);
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return gteqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return gteqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return gteqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return gteqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return gteqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return gteqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return gteqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return gteqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return gteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gteqF64(lhs,rhs);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static void gteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i],rhs[i]);
        }

        [MethodImpl(Inline)]
        public static T pow<T>(T src, uint exp)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

           if(kind == PrimalKind.int32)
                return powI32(src,exp);

            if(kind == PrimalKind.uint32)
                return powU32(src,exp);

            if(kind == PrimalKind.int64)
                return powI64(src,exp);

            if(kind == PrimalKind.uint64)
                return powU64(src,exp);

            if(kind == PrimalKind.int16)
                return powI16(src,exp);

            if(kind == PrimalKind.uint16)
                return powU16(src,exp);

            if(kind == PrimalKind.int8)
                return powI8(src,exp);

            if(kind == PrimalKind.uint8)
                return powU8(src,exp);

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw new Exception("Kind not supported");
        }           

        [MethodImpl(Inline)]
        public static T pow<T>(T src, T exp)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw new Exception("Kind not supported");
        }

       [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return incI32(src);

            if(kind == PrimalKind.uint32)
                return incU32(src);

            if(kind == PrimalKind.int64)
                return incI64(src);

            if(kind == PrimalKind.uint64)
                return incU64(src);

            if(kind == PrimalKind.int16)
                return incI16(src);

            if(kind == PrimalKind.uint16)
                return incU16(src);

            if(kind == PrimalKind.int8)
                return incI8(src);

            if(kind == PrimalKind.uint8)
                return incU8(src);

            if(kind == PrimalKind.float32)
                return incF32(src);

            if(kind == PrimalKind.float64)
                return incF64(src);

            throw new Exception($"Kind {kind} not supported");
        }           


       [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return decI32(src);

            if(kind == PrimalKind.uint32)
                return decU32(src);

            if(kind == PrimalKind.int64)
                return decI64(src);

            if(kind == PrimalKind.uint64)
                return decU64(src);

            if(kind == PrimalKind.int16)
                return decI16(src);

            if(kind == PrimalKind.uint16)
                return decU16(src);

            if(kind == PrimalKind.int8)
                return decI8(src);

            if(kind == PrimalKind.uint8)
                return decU8(src);

            if(kind == PrimalKind.float32)
                return decF32(src);

            if(kind == PrimalKind.float64)
                return decF64(src);

            throw new Exception($"Kind {kind} not supported");
        }           

       [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return minI32(lhs, rhs);

            if(kind == PrimalKind.uint32)
                return minU32(lhs, rhs);

            if(kind == PrimalKind.int64)
                return minI64(lhs, rhs);

            if(kind == PrimalKind.uint64)
                return minU64(lhs, rhs);

            if(kind == PrimalKind.int16)
                return minI16(lhs, rhs);

            if(kind == PrimalKind.uint16)
                return minU16(lhs, rhs);

            if(kind == PrimalKind.int8)
                return minI8(lhs, rhs);

            if(kind == PrimalKind.uint8)
                return minU8(lhs, rhs);

            if(kind == PrimalKind.float32)
                return minF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return minF64(lhs, rhs);

            throw new Exception($"Kind {kind} not supported");
        }           

       [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return maxI32(lhs, rhs);

            if(kind == PrimalKind.uint32)
                return maxU32(lhs, rhs);

            if(kind == PrimalKind.int64)
                return maxI64(lhs, rhs);

            if(kind == PrimalKind.uint64)
                return maxU64(lhs, rhs);

            if(kind == PrimalKind.int16)
                return maxI16(lhs, rhs);

            if(kind == PrimalKind.uint16)
                return maxU16(lhs, rhs);

            if(kind == PrimalKind.int8)
                return maxI8(lhs, rhs);

            if(kind == PrimalKind.uint8)
                return maxU8(lhs, rhs);

            if(kind == PrimalKind.float32)
                return maxF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return maxF64(lhs, rhs);

            throw new Exception($"Kind {kind} not supported");
        }           


    }
}