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


    public static class gfloat
    {

        internal static void init<T>()
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            var g1 = one<T>();

            add(g1,g1);
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

            throw new Exception($"Kind {kind} not supported");
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
        
            throw new Exception($"Kind {kind} not supported");
        }

        [MethodImpl(Inline)]
        public static void add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = addF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = addF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long addT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            add(lhs,rhs,dst);
            return elapsed(sw);
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
        
            throw new Exception($"Kind {kind} not supported");        
        }


        [MethodImpl(Inline)]
        public static void sub<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = subF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = subF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long subT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            sub(lhs,rhs,dst);
            return elapsed(sw);
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
        
            throw new Exception($"Kind {kind} not supported");        
        }


        [MethodImpl(Inline)]
        public static void mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = mulF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = mulF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }


        public static long mulT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            mul(lhs,rhs,dst);
            return elapsed(sw);
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
        
            throw new Exception($"Kind {kind} not supported");        
        }


       [MethodImpl(Inline)]
        public static void div<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = divF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = divF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long divT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            div(lhs,rhs,dst);
            return elapsed(sw);
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
        
            throw new Exception($"Kind {kind} not supported");        
        }

       [MethodImpl(Inline)]
        public static void mod<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = modF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = modF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long modT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            mod(lhs,rhs,dst);
            return elapsed(sw);
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

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void abs<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< src.Length; i++)
                    dst[i] = absF32(src[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< src.Length; i++)
                    dst[i] = absF64(src[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long absT<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            abs(src,dst);
            return elapsed(sw);
        }


        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return eqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return eqF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        

        }


        [MethodImpl(Inline)]
        public static void eq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = eqF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = eqF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long eqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            eq(lhs,rhs,dst);
            return elapsed(sw);
        }
 
        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return neqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return neqF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void neq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = neqF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = neqF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }


        public static long neqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            neq(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return ltF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return ltF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void lt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = ltF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = ltF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long ltT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            lt(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return lteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return lteqF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void lteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = lteqF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = lteqF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long lteqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            lteq(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return gtF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gtF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void gt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = gtF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = gtF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long gtT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gt(lhs,rhs,dst);
            return elapsed(sw);
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return gteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gteqF64(lhs,rhs);

            throw new Exception($"Kind {kind} not supported");        
        }

        [MethodImpl(Inline)]
        public static void gteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = gteqF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = gteqF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long gteqT<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gteq(lhs,rhs,dst);
            return elapsed(sw);
        }


        [MethodImpl(Inline)]
        public static T pow<T>(T src, uint exp)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw new Exception($"Kind {kind} not supported");        
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

            if(kind == PrimalKind.float32)
                return incF32(src);

            if(kind == PrimalKind.float64)
                return incF64(src);

            throw new Exception("Kind not supported");
        }

        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return decF32(src);

            if(kind == PrimalKind.float64)
                return decF64(src);

            throw new Exception("Kind not supported");
        }

       [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return minF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return minF64(lhs, rhs);

            throw new Exception("Kind not supported");
        }

       [MethodImpl(Inline)]
        public static void min<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = minF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = minF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long minT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            min(lhs,rhs,dst);
            return elapsed(sw);
        }


       [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return maxF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return maxF64(lhs, rhs);

            throw new Exception("Kind not supported");
        }

       [MethodImpl(Inline)]
        public static void max<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = maxF32(lhs[i], rhs[i]);

            else if(kind == PrimalKind.float64)
                for(var i = 0; i< lhs.Length; i++)
                    dst[i] = maxF64(lhs[i], rhs[i]);
            else
                throw new Exception($"Kind {kind} not supported");
        }

        public static long maxT<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            max(lhs,rhs,dst);
            return elapsed(sw);
        }

    }

}