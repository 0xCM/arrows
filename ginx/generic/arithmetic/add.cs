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

    using static As;
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static ref Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, out dst);
            else if (kind.IsSmallInt())
                return ref addSmall(kind, in lhs, in rhs, out dst);
            else    
                return ref addLarge(kind, in lhs, in rhs, out dst);
        }

        [MethodImpl(Inline)]
        public static ref Vec256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs, out Vec256<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, out dst);
            else if (kind.IsSmallInt())
                return ref addSmall(kind, in lhs, in rhs, out dst);
            else    
                return ref addLarge(kind, in lhs, in rhs, out dst);
        }
        
        [MethodImpl(Inline)]
        public static ref T add<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, ref dst);
            else if(kind.IsSmallInt())
                return ref addSmall(kind, in lhs, in rhs, ref dst);
            else
                return ref addLarge(kind, in lhs, in rhs, ref dst);
        }

        [MethodImpl(Inline)]
        public static ref T add<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, ref dst);
            else if(kind.IsSmallInt())
                return ref addSmall(kind, in lhs, in rhs, ref dst);
            else
                return ref addLarge(kind, in lhs, in rhs, ref dst);
        }


        [MethodImpl(Inline)]
        public static ref Span128<T> add<T>(in ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, ref Span128<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();  
            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, ref dst);            
            else if(kind.IsSmallInt())      
                return ref addSmall(kind, in lhs, in rhs, ref dst);
            else 
                return ref addLarge(kind, in lhs, rhs, ref dst);
        }

        [MethodImpl(Inline)]
        public static ref Span256<T> add<T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, ref Span256<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();        
            
            if(kind.IsFloat())
                return ref addFloat(kind, in lhs, in rhs, ref dst);            
            else if(kind.IsSmallInt())      
                return ref addSmall(kind, in lhs, in rhs, ref dst);
            else 
                return ref addLarge(kind, in lhs, rhs, ref dst);                        
        }

        [MethodImpl(Inline)]
        static ref T addSmall<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (kind == PrimalKind.int8)
                dinx.add(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (kind == PrimalKind.uint8)
                dinx.add(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (kind == PrimalKind.int16)
                dinx.add(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (kind == PrimalKind.uint16)
                dinx.add(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else 
                throw unsupported(kind);
            return ref dst;

        }

        [MethodImpl(Inline)]
        static ref T addLarge<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dinx.add(int32(lhs), int32(rhs), ref int32(ref dst));
            else if (kind == PrimalKind.uint32)
                dinx.add(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if (kind == PrimalKind.int64)
                dinx.add(int64(lhs), int64(rhs), ref int64(ref dst));
            else if (kind == PrimalKind.uint64)
                dinx.add(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else 
                throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref T addFloat<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dinx.add(float32(lhs), float32(rhs), ref float32(ref dst));
            else if (kind == PrimalKind.float64)
                dinx.add(float64(lhs), float64(rhs), ref float64(ref dst));                
            else
                throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref T addSmall<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (kind == PrimalKind.int8)
                dinx.add(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (kind == PrimalKind.uint8)
                dinx.add(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (kind == PrimalKind.int16)
                dinx.add(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (kind == PrimalKind.uint16)
                dinx.add(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else 
                throw unsupported(kind);
            return ref dst;

        }

        [MethodImpl(Inline)]
        static ref Span128<T> addSmall<T>(PrimalKind kind, in ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, ref Span128<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int8)
            {
                var xDst = int8(dst);
                dinx.add(int8(lhs), int8(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint8)
            {
                var xDst = uint8(dst);
                dinx.add(uint8(lhs), uint8(rhs), ref xDst);
            }
            else if(kind == PrimalKind.int16)
            {
                var xDst = int16(dst);
                dinx.add(int16(lhs), int16(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint16)
            {
                var xDst = uint16(dst);
                dinx.add(uint16(lhs), uint16(rhs), ref xDst);
            }
            else
                throw unsupported(kind);

            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Span256<T> addSmall<T>(PrimalKind kind, in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, ref Span256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int8)
            {
                var xDst = int8(dst);
                dinx.add(int8(lhs), int8(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint8)
            {
                var xDst = uint8(dst);
                dinx.add(uint8(lhs), uint8(rhs), ref xDst);
            }
            else if(kind == PrimalKind.int16)
            {
                var xDst = int16(dst);
                dinx.add(int16(lhs), int16(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint16)
            {
                var xDst = uint16(dst);
                dinx.add(uint16(lhs), uint16(rhs), ref xDst);
            }
            else
                throw unsupported(kind);

            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Span128<T> addLarge<T>(PrimalKind kind, in ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, ref Span128<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
            {
                var xDst = int32(dst);
                dinx.add(int32(lhs), int32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint32)
            {
                var xDst = uint32(dst);
                dinx.add(uint32(lhs), uint32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.int64)
            {
                var xDst = int64(dst);
                dinx.add(int64(lhs), int64(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint64)
            {
                var xDst = uint64(dst);
                dinx.add(uint64(lhs), uint64(rhs), ref xDst);
            }
            return ref dst;            
        }

        [MethodImpl(Inline)]
        static ref Span256<T> addLarge<T>(PrimalKind kind, in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, ref Span256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
            {
                var xDst = int32(dst);
                dinx.add(int32(lhs), int32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint32)
            {
                var xDst = uint32(dst);
                dinx.add(uint32(lhs), uint32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.int64)
            {
                var xDst = int64(dst);
                dinx.add(int64(lhs), int64(rhs), ref xDst);
            }
            else if(kind == PrimalKind.uint64)
            {
                var xDst = uint64(dst);
                dinx.add(uint64(lhs), uint64(rhs), ref xDst);
            }
            return ref dst;            
        }

        [MethodImpl(Inline)]
        static ref Span128<T> addFloat<T>(PrimalKind kind, in ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, ref Span128<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
            {
                var xDst = float32(dst);
                dinx.add(float32(lhs), float32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.float64)
            {
                var xDst = float64(dst);
                dinx.add(float64(lhs), float64(rhs), ref  xDst);
            }                
            else throw unsupported(kind);
            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        static ref T addLarge<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dinx.add(int32(lhs), int32(rhs), ref int32(ref dst));
            else if (kind == PrimalKind.uint32)
                dinx.add(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if (kind == PrimalKind.int64)
                dinx.add(int64(lhs), int64(rhs), ref int64(ref dst));
            else if (kind == PrimalKind.uint64)
                dinx.add(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else throw unsupported(kind);
            
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref T addFloat<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dinx.add(float32(lhs), float32(rhs), ref float32(ref dst));
            else if (kind == PrimalKind.float64)
                dinx.add(float64(lhs), float64(rhs), ref float64(ref dst));                
            else throw unsupported(kind);
            return ref dst;
        }
 

        [MethodImpl(Inline)]
        static ref Vec128<T> addFloat<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dst = generic<T>(dinx.add(in float32(in lhs), in float32(rhs)));
            else if(kind == PrimalKind.float64)
                dst = generic<T>(dinx.add(in float64(in lhs), in float64(rhs)));
            else    
                throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Vec128<T> addLarge<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dst = generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(kind == PrimalKind.uint32)
                dst = generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(kind == PrimalKind.int64)
                dst = generic<T>(dinx.add(in int64(in lhs), in int64(rhs)));
            else if(kind ==PrimalKind.uint64)
                dst = generic<T>(dinx.add(in uint64(in lhs), in uint64(rhs)));
            else    
                throw unsupported(kind);

            return ref dst;
            
        }

        [MethodImpl(Inline)]
        static ref Vec128<T> addSmall<T>(PrimalKind kind, in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct
        {

            if(kind == PrimalKind.int8)
                dst = generic<T>(dinx.add(in int8(lhs), in int8(in rhs)));
            else if(kind == PrimalKind.uint8)
                dst = generic<T>(dinx.add(in uint8(lhs), in uint8(in rhs)));
            else if(kind == PrimalKind.int16)
                dst = generic<T>(dinx.add(in int16(lhs), in int16(in rhs)));
            else if(kind ==PrimalKind.uint16)
                dst = generic<T>(dinx.add(in uint16(lhs), in uint16(in rhs)));
            else    
                throw unsupported(kind);

            return ref dst;
        }


        [MethodImpl(Inline)]
        static ref Vec256<T> addFloat<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dst = generic<T>(dinx.add(in float32(in lhs), in float32(rhs)));
            else if(kind == PrimalKind.float64)
                dst = generic<T>(dinx.add(in float64(in lhs), in float64(rhs)));
            else    
                throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Vec256<T> addLarge<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dst = generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(kind == PrimalKind.uint32)
                dst = generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(kind == PrimalKind.int64)
                dst = generic<T>(dinx.add(in int64(in lhs), in int64(rhs)));
            else if(kind ==PrimalKind.uint64)
                dst = generic<T>(dinx.add(in uint64(in lhs), in uint64(rhs)));
            else    
                throw unsupported(kind);

            return ref dst;
            
        }

        [MethodImpl(Inline)]
        static ref Vec256<T> addSmall<T>(PrimalKind kind, in Vec256<T> lhs, in Vec256<T> rhs, out Vec256<T> dst)
            where T : struct
        {

            if(kind == PrimalKind.int8)
                dst = generic<T>(dinx.add(in int8(lhs), in int8(in rhs)));
            else if(kind == PrimalKind.uint8)
                dst = generic<T>(dinx.add(in uint8(lhs), in uint8(in rhs)));
            else if(kind == PrimalKind.int16)
                dst = generic<T>(dinx.add(in int16(lhs), in int16(in rhs)));
            else if(kind ==PrimalKind.uint16)
                dst = generic<T>(dinx.add(in uint16(lhs), in uint16(in rhs)));
            else    
                throw unsupported(kind);

            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Span256<T> addFloat<T>(PrimalKind kind, in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, ref Span256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
            {
                var xDst = float32(dst);
                dinx.add(float32(lhs), float32(rhs), ref xDst);
            }
            else if(kind == PrimalKind.float64)
            {
                var xDst = float64(dst);
                dinx.add(float64(lhs), float64(rhs), ref xDst);
            }                
            else
                throw unsupported(kind);
            
            return ref dst;
        }            

    }
}
