//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static mfunc;
    using static zfunc;
    using static As;

    public static partial class ginx
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            var x = rhs;
            var y = lhs;
            
            if(kind == PrimalKind.float32)
                return dinx.eq(in float32(ref x), in float32(ref y));

            if(kind == PrimalKind.float64)
                return dinx.eq(in float64(ref x), in float64(ref y));            

            throw unsupported(kind);

        }


        [MethodImpl(Inline)]
        public static bool cmpf<T>(in Num128<T> lhs, in Num128<T> rhs, FloatComparisonMode mode)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            var x = rhs;
            var y = lhs;
            
            if(kind == PrimalKind.float32)
                return dinx.cmpf(in float32(ref x), in float32(ref y), mode);
            
            if(kind == PrimalKind.float64)
                return dinx.cmpf(in float64(ref x), in float64(ref y), mode);
                
            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static bool neq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.neq(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.neq(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);

        }

        [MethodImpl(Inline)]
        public static bool gt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            var x = rhs;
            var y = lhs;

            if(kind == PrimalKind.float32)
                return dinx.gt(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.gt(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);

        }

        [MethodImpl(Inline)]
        public static bool ngt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.ngt(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.ngt(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);

        }


        [MethodImpl(Inline)]
        public static bool gteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind == PrimalKind.float32)
                return dinx.gteq(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.gteq(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);

        }

        [MethodImpl(Inline)]
        public static bool lt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.lt(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.lt(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.nlt(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.nlt(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));
            
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.lteq(in float32(ref asRef(in lhs)), in float32(ref asRef(in rhs)));
            
            if(kind == PrimalKind.float64)
                return dinx.lteq(in float64(ref asRef(in lhs)), in float64(ref asRef(in rhs)));

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> add<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.add(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }                

            if(kind == PrimalKind.float64)
            {
                dinx.add(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> sub<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.sub(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }
                
            if(kind == PrimalKind.float64)
            {
                dinx.sub(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> mul<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.mul(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }
                
            if(kind == PrimalKind.float64)
            {
                dinx.mul(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> div<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.div(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }
                
            if(kind == PrimalKind.float64)
            {
                dinx.div(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> max<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.max(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }

            if(kind == PrimalKind.float64)
            {
                dinx.max(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> min<T>(ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.min(ref float32(ref lhs), in float32(ref asRef(in rhs)));
                return ref lhs;
            }

            if(kind == PrimalKind.float64)
            {
                dinx.min(ref float64(ref lhs), in float64(ref asRef(in rhs)));
                return ref lhs;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> muladd<T>(ref Num128<T> x, in Num128<T> y, in Num128<T> z)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.mulAdd(ref float32(ref x), in float32(ref asRef(in y)), in float32(ref asRef(in z)));
                return ref x;
            }
                
            if(kind == PrimalKind.float64)
            {
                dinx.mulAdd(ref float64(ref x), in float64(ref asRef(in y)), in float64(ref asRef(in z)));
                return ref x;
            }                

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> recip<T>(ref Num128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.recip(ref float32(ref src));
                return ref src;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> sqrt<T>(ref Num128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.sqrt(ref float32(ref src));
                return ref src;
            }
                

            if(kind == PrimalKind.float64)
            {
                dinx.sqrt(ref float64(ref src));
                return ref src;
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Num128<T> recipsqrt<T>(ref Num128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.recipsqrt(ref float32(ref src));
                return ref src;
            }

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static ref Num128<T> ceiling<T>(ref Num128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.ceiling(ref float32(ref src));
                return ref src;
            }
            else if(kind == PrimalKind.float64)
            {
                dinx.ceiling(ref float64(ref src));
                return ref src;
            }
            else
                throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static ref Num128<T> floor<T>(ref Num128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
            {
                dinx.floor(ref float32(ref src));
                return ref src;
            }
            else if(kind == PrimalKind.float64)
            {
                dinx.floor(ref float64(ref src));
                return ref src;
            }
            else        
                throw unsupported(kind);
        }
    }
}