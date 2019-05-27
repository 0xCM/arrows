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
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;

    using static As;

    partial class gmath
    {
        public static void init()
        {
            one<byte>();
            one<sbyte>();        
            one<short>();
            one<ushort>();
            one<int>();
            one<uint>();
            one<long>();
            one<ulong>();
            one<float>();
            one<double>();
        }

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
                => convert(0, out T x);

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : struct
                => convert(1, out T x);

        [MethodImpl(Inline)]
        public static T value<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return src;

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return src;

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.int16)
                return src;

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int8)
                return src;

            if(kind == PrimalKind.uint8)
                return src;
            
            if(kind == PrimalKind.float32)
                return src;

            if(kind == PrimalKind.float64)
                return src;

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MinValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MinValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MinValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MinValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MinValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MinValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MinValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MinValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MinValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MinValue);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MaxValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MaxValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MaxValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MaxValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MaxValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MaxValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MaxValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MaxValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MaxValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MaxValue);

            throw unsupported(kind);
        }


        abstract class Add<T>
            where T : struct
        {
            public static readonly Add<T> TheOnly = Instantiate();

            static Add<T> Instantiate()
            {
                var kind = PrimalKinds.kind<T>(); 
                if(kind == PrimalKind.float32)
                {
                    var instance = new AddF32();
                    return Unsafe.As<AddF32, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.float64)
                {
                    var instance = new AddF64();
                    return Unsafe.As<AddF64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.uint64)
                {
                    var instance = new AddU64();
                    return Unsafe.As<AddU64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.int64)
                {
                    var instance = new AddI64();
                    return Unsafe.As<AddI64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.uint32)
                {
                    var instance = new AddU32();
                    return Unsafe.As<AddU32, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.int32)
                {
                    var instance = new AddI32();
                    return Unsafe.As<AddI32, Add<T>>(ref instance);
                }
                else 
                    throw unsupported(kind);
            }

            sealed class AddI32 : Add<int>
            {
                public override int apply(int lhs, int rhs)
                    => lhs + rhs;
            }

            sealed class AddU32 : Add<uint>
            {
                public override uint apply(uint lhs, uint rhs)
                    => lhs + rhs;
            }

            sealed class AddI64 : Add<long>
            {
                public override long apply(long lhs, long rhs)
                    => lhs + rhs;
            }

            sealed class AddU64 : Add<ulong>
            {
                public override ulong apply(ulong lhs, ulong rhs)
                    => lhs + rhs;
            }

            sealed class AddF32 : Add<float>
            {
                public override float apply(float lhs, float rhs)
                    => lhs + rhs;
            }

            sealed class AddF64 : Add<double>
            {
                public override double apply(double lhs, double rhs)
                    => lhs + rhs;
            }

            public abstract T apply(T lhs, T rhs);

        }


        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return addF32(lhs, rhs);
                else if(kind == PrimalKind.float64)
                    return addF64(lhs, rhs);
            }
            else if(kind.IsSmallInt())
            {
                if(kind == PrimalKind.int8)
                    return addI8(lhs, rhs);
                else if(kind == PrimalKind.uint8)
                    return addU8(lhs, rhs);            
                else if(kind == PrimalKind.int16)
                    return addI16(lhs, rhs);
                else if(kind == PrimalKind.uint16)
                    return addU16(lhs, rhs);
            }
            else
            {
                if(kind == PrimalKind.int32)
                    return addI32(lhs, rhs);
                else if(kind == PrimalKind.uint32)
                    return addU32(lhs, rhs);
                else if(kind == PrimalKind.int64)
                    return addI64(lhs, rhs);
                else if(kind == PrimalKind.uint64)
                    return addU64(lhs, rhs);
            }
            
            throw unsupported(kind);
        }

                        

        [MethodImpl(Inline)]
        public static ref T add<T>(in T lhs, in T rhs, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>(); 

            if (kind == PrimalKind.int8)
                dst = addI8(lhs, rhs, out dst);            
            else if(kind == PrimalKind.uint8)
                dst = addU8(lhs, rhs, out dst);
            else if(kind == PrimalKind.int16)
                dst = addI16(lhs, rhs, out dst);
            else if(kind == PrimalKind.uint16)
                dst = addU16(lhs, rhs, out dst);
            else if(kind == PrimalKind.int32)
                dst = addI32(lhs, rhs, out dst);            
            else if(kind == PrimalKind.uint32)
                dst = addU32(lhs, rhs, out dst);            
            else if(kind == PrimalKind.int64)
                dst = addI64(lhs, rhs, out dst);            
            else if(kind == PrimalKind.uint64)
                dst = addU64(lhs, rhs, out dst);            
            else if(kind == PrimalKind.float32)
                dst = addF32(lhs, rhs, out dst);            
            else if(kind == PrimalKind.float64)
                dst = addF64(lhs, rhs, out dst);
            else            
                throw unsupported(kind);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return ref addF32(ref lhs, rhs);
                
                if(kind == PrimalKind.float64)
                    return ref addF64(ref lhs, rhs);
            }
            else 
            {            
                if (kind == PrimalKind.int8)
                    return ref addI8(ref lhs, rhs);
                
                if(kind == PrimalKind.uint8)
                    return ref addU8(ref lhs, rhs);

                if(kind == PrimalKind.int16)
                    return ref addI16(ref lhs, rhs);

                if(kind == PrimalKind.uint16)
                    return ref addU16(ref lhs, rhs);

                if(kind == PrimalKind.int32)
                    return ref addI32(ref lhs, rhs);
                
                if(kind == PrimalKind.uint32)
                    return ref addU32(ref lhs, rhs);
                
                if(kind == PrimalKind.int64)
                    return ref addI64(ref lhs, rhs);
                
                if(kind == PrimalKind.uint64)
                    return ref addU64(ref lhs, rhs);            
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.add(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.add(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.add(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.add(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.add(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.add(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.add(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref T sub<T>(in T lhs, in T rhs, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                dst = subI8(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.uint8)
                dst = subU8(in lhs, in rhs, out dst);
            else if(kind == PrimalKind.int16)
                dst = subI16(in lhs, in rhs, out dst);
            else if(kind == PrimalKind.uint16)
                dst = subU16(in lhs, in rhs, out dst);
            else if(kind == PrimalKind.int32)
                dst = subI32(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.uint32)
                dst = subU32(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.int64)
                dst = subI64(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.uint64)
                dst = subU64(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.float32)
                dst = subF32(in lhs, in rhs, out dst);            
            else if(kind == PrimalKind.float64)
                dst = subF64(in lhs, in rhs, out dst);
            else            
                throw unsupported(kind);
            return ref dst;
        }



        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return ref subF32(ref lhs, rhs);
                
                if(kind == PrimalKind.float64)
                    return ref subF64(ref lhs, rhs);
            }
            else
            {
                if (kind == PrimalKind.int8)
                    return ref subI8(ref lhs, rhs);
                
                if(kind == PrimalKind.uint8)
                    return ref subU8(ref lhs, rhs);

                if(kind == PrimalKind.int16)
                    return ref subI16(ref lhs, rhs);

                if(kind == PrimalKind.uint16)
                    return ref subU16(ref lhs, rhs);

                if(kind == PrimalKind.int32)
                    return ref subI32(ref lhs, rhs);
                
                if(kind == PrimalKind.uint32)
                    return ref subU32(ref lhs, rhs);
                
                if(kind == PrimalKind.int64)
                    return ref subI64(ref lhs, rhs);
                
                if(kind == PrimalKind.uint64)
                    return ref subU64(ref lhs, rhs);

            }            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T sub<T>(in T lhs, in T rhs)
            where T : struct
                => sub(in lhs, in rhs, out T result);


        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return subF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return subF64(lhs,rhs);
            }
            else
            {
                if(kind.IsSmallInt())
                {
                    if(kind == PrimalKind.int8)
                        return subI8(lhs,rhs);

                    if(kind == PrimalKind.uint8)
                        return subU8(lhs,rhs);

                    if(kind == PrimalKind.int16)
                        return subI16(lhs,rhs);

                    if(kind == PrimalKind.uint16)
                        return subU16(lhs,rhs);
                }
                else
                {
                    if(kind == PrimalKind.int32)
                        return subI32(lhs,rhs);

                    if(kind == PrimalKind.uint32)
                        return subU32(lhs,rhs);

                    if(kind == PrimalKind.int64)
                        return subI64(lhs,rhs);

                    if(kind == PrimalKind.uint64)
                        return subU64(lhs,rhs);
                }                    
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.sub(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.sub(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.sub(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.sub(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.sub(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.sub(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.sub(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.sub(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.sub(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.sub(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, in T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return ref mulF32(ref lhs, rhs);
                
                if(kind == PrimalKind.float64)
                    return ref mulF64(ref lhs, rhs);
            }
            else
            {
                if(kind.IsSmallInt())
                {
                    if (kind == PrimalKind.int8)
                        return ref mulI8(ref lhs, rhs);
                    
                    if(kind == PrimalKind.uint8)
                        return ref mulU8(ref lhs, rhs);

                    if(kind == PrimalKind.int16)
                        return ref mulI16(ref lhs, rhs);

                    if(kind == PrimalKind.uint16)
                        return ref mulU16(ref lhs, rhs);
                }
                else
                {
                    if(kind == PrimalKind.int32)
                        return ref mulI32(ref lhs, rhs);
                    
                    if(kind == PrimalKind.uint32)
                        return ref mulU32(ref lhs, rhs);
                    
                    if(kind == PrimalKind.int64)
                        return ref mulI64(ref lhs, rhs);
                    
                    if(kind == PrimalKind.uint64)
                        return ref mulU64(ref lhs, rhs);
                }            
            }
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return mulF32(lhs,rhs);
                else if(kind == PrimalKind.float64)
                    return mulF64(lhs,rhs);
            }
            else if(kind.IsSmallInt())
            {
                if(kind == PrimalKind.int8)
                    return mulI8(lhs,rhs);
                else if(kind == PrimalKind.uint8)
                    return mulU8(lhs,rhs);
                else if(kind == PrimalKind.int16)
                    return mulI16(lhs,rhs);
                else if(kind == PrimalKind.uint16)
                    return mulU16(lhs,rhs);
            }
            else
            {                
                if(kind == PrimalKind.int32)
                    return mulI32(lhs,rhs);
                else if(kind == PrimalKind.uint32)
                    return mulU32(lhs,rhs);
                else if(kind == PrimalKind.int64)
                    return mulI64(lhs,rhs);
                else if(kind == PrimalKind.uint64)
                    return mulU64(lhs,rhs);
             }

             throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.mul(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.mul(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.mul(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.mul(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.mul(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.mul(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.mul(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.mul(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.mul(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.mul(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref divI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref divU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref divI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref divU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref divI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref divU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref divI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref divU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref divF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref divF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.div(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.div(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.div(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.div(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.div(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.div(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.div(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.div(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.div(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.div(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool divides<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return dividesI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return dividesU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return dividesI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return dividesU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return dividesI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return dividesU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return dividesI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return dividesU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return dividesF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return dividesF64(lhs,rhs);

            throw unsupported(kind);
        }
        
        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref modI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref modU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref modI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref modU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref modI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref modU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref modI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref modU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref modF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref modF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(NotInline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.mod(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.mod(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.mod(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.mod(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.mod(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.mod(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.mod(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.mod(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.mod(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.mod(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref andI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref andU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref andI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref andU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref andI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref andU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref andI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref andU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.and(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.and(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.and(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.and(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.and(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref orI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref orU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref orI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref orU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref orI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref orU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref orI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref orU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           



        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.or(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.or(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.or(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.or(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.or(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.or(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref xorI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref xorU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref xorI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref xorU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref xorI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref xorU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref xorI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref xorU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.xor(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.xor(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.xor(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.xor(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref T lshift<T>(ref T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref lshiftI32(ref lhs, rhs);

            if(kind == PrimalKind.uint32)
                return ref lshiftU32(ref lhs, rhs);

            if(kind == PrimalKind.int64)
                return ref lshiftI64(ref lhs, rhs);

            if(kind == PrimalKind.uint64)
                return ref lshiftU64(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref lshiftI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref lshiftU16(ref lhs, rhs);

            if(kind == PrimalKind.int8)
                return ref lshiftI8(ref lhs, rhs);

            if(kind == PrimalKind.uint8)
                return ref lshiftU8(ref lhs, rhs);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T lshift<T>(in T lhs, in int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return lshiftI32(in lhs, in rhs);

            if(kind == PrimalKind.uint32)
                return lshiftU32(in lhs, in rhs);

            if(kind == PrimalKind.int64)
                return lshiftI64(in lhs, in rhs);

            if(kind == PrimalKind.uint64)
                return lshiftU64(in lhs, in rhs);

            if(kind == PrimalKind.int16)
                return lshiftI16(in lhs, in rhs);

            if(kind == PrimalKind.uint16)
                return lshiftU16(in lhs, in rhs);

            if(kind == PrimalKind.int8)
                return lshiftI8(in lhs, in rhs);

            if(kind == PrimalKind.uint8)
                return lshiftU8(in lhs,in rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T lshift<T>(in T lhs, in uint rhs)
            where T : struct
                => lshift(in lhs, (int)rhs);
        
        [MethodImpl(Inline)]
        public static T lshift<T>(in T lhs, in ulong rhs)
            where T : struct
                => lshift(in lhs, (int)rhs);


        [MethodImpl(Inline)]
        public static ref T rshift<T>(ref T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref rshiftI32(ref lhs, rhs);

            if(kind == PrimalKind.uint32)
                return ref rshiftU32(ref lhs, rhs);

            if(kind == PrimalKind.int64)
                return ref rshiftI64(ref lhs, rhs);

            if(kind == PrimalKind.uint64)
                return ref rshiftU64(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref rshiftI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref rshiftU16(ref lhs, rhs);

            if(kind == PrimalKind.int8)
                return ref rshiftI8(ref lhs, rhs);

            if(kind == PrimalKind.uint8)
                return ref rshiftU8(ref lhs, rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T rshift<T>(T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return rshiftI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return rshiftU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return rshiftI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return rshiftU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return rshiftI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return rshiftU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return rshiftI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return rshiftU8(lhs,rhs);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref flipI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref flipU32(ref src);

            if(kind == PrimalKind.int64)
                return ref flipI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref flipU64(ref src);

            if(kind == PrimalKind.int16)
                return ref flipI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref flipU16(ref src);

            if(kind == PrimalKind.int8)
                return ref flipI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref flipU8(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.flip(int8(src), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.flip(uint8(src), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.flip(int16(src), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.flip(uint16(src), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.flip(int32(src), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.flip(uint32(src), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.flip(int64(src), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.flip(uint64(src), uint64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref absI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref absI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref absI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref absI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref absF32(ref src);

            if(kind == PrimalKind.float64)
                return ref absF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.abs(int8(src), int8(dst));
            else if(kind == PrimalKind.int16)
                math.abs(int16(src), int16(dst));
            else if(kind == PrimalKind.int32)
                math.abs(int32(src), int32(dst));
            else if(kind == PrimalKind.int64)
                math.abs(int64(src), int64(dst));
            else if(kind == PrimalKind.float32)
                math.abs(float32(src), float32(dst));
            else if(kind == PrimalKind.float64)
                math.abs(float64(src), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return eqF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return eqF64(lhs,rhs);
            }
            else
            {
                if(kind == PrimalKind.int8)
                    return eqI8(lhs,rhs);

                if(kind == PrimalKind.uint8)
                    return eqU8(lhs,rhs);

                if(kind == PrimalKind.int16)
                    return eqI16(lhs,rhs);

                if(kind == PrimalKind.uint16)
                    return eqU16(lhs,rhs);

                if(kind == PrimalKind.int32)
                    return eqI32(lhs,rhs);

                if(kind == PrimalKind.uint32)
                    return eqU32(lhs,rhs);

                if(kind == PrimalKind.int64)
                    return eqI64(lhs,rhs);

                if(kind == PrimalKind.uint64)
                    return eqU64(lhs,rhs);
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.eq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.eq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.eq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.eq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.eq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.eq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.eq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.eq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.eq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.eq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gmath.eq(lhs,rhs,dst);
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.neq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.neq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.neq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.neq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.neq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.neq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.neq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.neq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.neq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.neq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static bool nonzero<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return nonzeroI8(src);

            if(kind == PrimalKind.uint8)
                return nonzeroU8(src);

            if(kind == PrimalKind.int16)
                return nonzeroI16(src);

            if(kind == PrimalKind.uint16)
                return nonzeroU16(src);

            if(kind == PrimalKind.int32)
                return nonzeroI32(src);

            if(kind == PrimalKind.uint32)
                return nonzeroU32(src);

            if(kind == PrimalKind.int64)
                return nonzeroI64(src);

            if(kind == PrimalKind.uint64)
                return nonzeroU64(src);

            if(kind == PrimalKind.float32)
                return nonzeroF32(src);

            if(kind == PrimalKind.float64)
                return nonzeroF64(src);

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return ltF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return ltF64(lhs,rhs);
            }
            else
            {
                if(kind == PrimalKind.int8)
                    return ltI8(lhs,rhs);

                if(kind == PrimalKind.uint8)
                    return ltU8(lhs,rhs);

                if(kind == PrimalKind.int16)
                    return ltI16(lhs,rhs);

                if(kind == PrimalKind.uint16)
                    return ltU16(lhs,rhs);

                if(kind == PrimalKind.int32)
                    return ltI32(lhs,rhs);

                if(kind == PrimalKind.uint32)
                    return ltU32(lhs,rhs);

                if(kind == PrimalKind.int64)
                    return ltI64(lhs,rhs);

                if(kind == PrimalKind.uint64)
                    return ltU64(lhs,rhs);
            }

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.lt(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.lt(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.lt(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.lt(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.lt(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.lt(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.lt(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.lt(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.lt(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.lt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return lt(lhs,rhs,dst);
        }
 

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return lteqF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return lteqF64(lhs,rhs);
            }
            else
            {
                if(kind == PrimalKind.int8)
                    return lteqI8(lhs,rhs);

                if(kind == PrimalKind.uint8)
                    return lteqU8(lhs,rhs);

                if(kind == PrimalKind.int16)
                    return lteqI16(lhs,rhs);

                if(kind == PrimalKind.uint16)
                    return lteqU16(lhs,rhs);

                if(kind == PrimalKind.int32)
                    return lteqI32(lhs,rhs);

                if(kind == PrimalKind.uint32)
                    return lteqU32(lhs,rhs);

                if(kind == PrimalKind.int64)
                    return lteqI64(lhs,rhs);

                if(kind == PrimalKind.uint64)
                    return lteqU64(lhs,rhs);
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.lteq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.lteq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.lteq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.lteq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.lteq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.lteq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.lteq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.lteq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.lteq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.lteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gmath.lteq(lhs,rhs,dst);
        }



        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return gtF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return gtF64(lhs,rhs);
            }
            else
            {
                if(kind == PrimalKind.int8)
                    return gtI8(lhs,rhs);

                if(kind == PrimalKind.uint8)
                    return gtU8(lhs,rhs);

                if(kind == PrimalKind.int16)
                    return gtI16(lhs,rhs);

                if(kind == PrimalKind.uint16)
                    return gtU16(lhs,rhs);

                if(kind == PrimalKind.int32)
                    return gtI32(lhs,rhs);

                if(kind == PrimalKind.uint32)
                    return gtU32(lhs,rhs);

                if(kind == PrimalKind.int64)
                    return gtI64(lhs,rhs);

                if(kind == PrimalKind.uint64)
                    return gtU64(lhs,rhs);
            }


            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.gt(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.gt(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.gt(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.gt(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.gt(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.gt(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.gt(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.gt(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.gt(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.gt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gt(lhs,rhs,dst);
        }


        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return gteqF32(lhs,rhs);

                if(kind == PrimalKind.float64)
                    return gteqF64(lhs,rhs);
            }
            else
            {
                if(kind == PrimalKind.int8)
                    return gteqI8(lhs,rhs);

                if(kind == PrimalKind.uint8)
                    return gteqU8(lhs,rhs);

                if(kind == PrimalKind.int16)
                    return gteqI16(lhs,rhs);

                if(kind == PrimalKind.uint16)
                    return gteqU16(lhs,rhs);

                if(kind == PrimalKind.int32)
                    return gteqI32(lhs,rhs);

                if(kind == PrimalKind.uint32)
                    return gteqU32(lhs,rhs);

                if(kind == PrimalKind.int64)
                    return gteqI64(lhs,rhs);

                if(kind == PrimalKind.uint64)
                    return gteqU64(lhs,rhs);
            }

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.gteq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.gteq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.gteq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.gteq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.gteq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.gteq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.gteq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.gteq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.gteq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.gteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gteq(lhs,rhs,dst);
        }


        [MethodImpl(Inline)]
        public static T pow<T>(T src, uint exp)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T pow<T>(T src, T exp)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return ref negateI8(ref src);

            if(kind == PrimalKind.int16)
                return ref negateI16(ref src);

            if(kind == PrimalKind.int32)
                return ref negateI32(ref src);

            if(kind == PrimalKind.int64)
                return ref negateI64(ref src);

            if(kind == PrimalKind.float32)
                return ref negateF32(ref src);

            if(kind == PrimalKind.float64)
                return ref negateF64(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T negate<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return negateI8(ref src);

            if(kind == PrimalKind.int16)
                return negateI16(ref src);

            if(kind == PrimalKind.int32)
                return negateI32(ref src);

            if(kind == PrimalKind.int64)
                return negateI64(ref src);

            if(kind == PrimalKind.float32)
                return negateF32(ref src);

            if(kind == PrimalKind.float64)
                return negateF64(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(NotInline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.negate(int8(src), int8(dst));
            else if(kind == PrimalKind.int16)
                math.negate(int16(src), int16(dst));
            else if(kind == PrimalKind.int32)
                math.negate(int32(src), int32(dst));
            else if(kind == PrimalKind.int64)
                math.negate(int64(src), int64(dst));
            else if(kind == PrimalKind.float32)
                math.negate(float32(src), float32(dst));
            else if(kind == PrimalKind.float64)
                math.negate(float64(src), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind == PrimalKind.int8)            
                return ref incI8(ref src);
            
            if(kind == PrimalKind.uint8)            
                return ref incU8(ref src);
            
            if(kind == PrimalKind.int16)            
                return ref incI16(ref src);
            
            if(kind == PrimalKind.uint16)
                return ref incU16(ref src);
            
            if(kind == PrimalKind.int32)
                return ref incI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref incU32(ref src);
            
            if(kind == PrimalKind.int64)
                return ref incI64(ref src);
            
            if(kind == PrimalKind.uint64)
                return ref incU64(ref src);
            
            if(kind == PrimalKind.float32)
                return ref incF32(ref src);
            
            if(kind == PrimalKind.float64)
                return ref incF64(ref src);
            
            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(NotInline)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.inc(int8(src), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.inc(uint8(src), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.inc(int16(src), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.inc(uint16(src), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.inc(int32(src), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.inc(uint32(src), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.inc(int64(src), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.inc(uint64(src), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.inc(float32(src), float32(dst));
            else if(kind == PrimalKind.float64)
                math.inc(float64(src), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> inc<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.inc(int8(io));
            else if(kind == PrimalKind.uint8)
                math.inc(uint8(io));
            else if(kind == PrimalKind.int16)
                math.inc(int16(io));
            else if(kind == PrimalKind.uint16)
                math.inc(uint16(io));
            else if(kind == PrimalKind.int32)
                math.inc(int32(io));
            else if(kind == PrimalKind.uint32)
                math.inc(uint32(io));
            else if(kind == PrimalKind.int64)
                math.inc(int64(io));
            else if(kind == PrimalKind.uint64)
                math.inc(uint64(io));
            else if(kind == PrimalKind.float32)
                math.inc(float32(io));
            else if(kind == PrimalKind.float64)
                math.inc(float64(io));
            else
                throw unsupported(kind);                
           
            return ref io;
        }



        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return ref decI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref decU8(ref src);

            if(kind == PrimalKind.int16)
                return ref decI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref decU16(ref src);

            if(kind == PrimalKind.int32)
                return ref decI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref decU32(ref src);

            if(kind == PrimalKind.int64)
                return ref decI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref decU64(ref src);

            if(kind == PrimalKind.float32)
                return ref decF32(ref src);

            if(kind == PrimalKind.float64)
                return ref decF64(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.dec(int8(src), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.dec(uint8(src), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.dec(int16(src), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.dec(uint16(src), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.dec(int32(src), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.dec(uint32(src), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.dec(int64(src), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.dec(uint64(src), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.dec(float32(src), float32(dst));
            else if(kind == PrimalKind.float64)
                math.dec(float64(src), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.dec(int8(io));
            else if(kind == PrimalKind.uint8)
                math.dec(uint8(io));
            else if(kind == PrimalKind.int16)
                math.dec(int16(io));
            else if(kind == PrimalKind.uint16)
                math.dec(uint16(io));
            else if(kind == PrimalKind.int32)
                math.dec(int32(io));
            else if(kind == PrimalKind.uint32)
                math.dec(uint32(io));
            else if(kind == PrimalKind.int64)
                math.dec(int64(io));
            else if(kind == PrimalKind.uint64)
                math.dec(uint64(io));
            else if(kind == PrimalKind.float32)
                math.dec(float32(io));
            else if(kind == PrimalKind.float64)
                math.dec(float64(io));
            else
                throw unsupported(kind);                
           
            return ref io;
        }

        [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           
 
        [MethodImpl(Inline)]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(math.min(int8(src)));
                case PrimalKind.uint8:
                    return generic<T>(math.min(uint8(src)));
                case PrimalKind.int16:
                    return generic<T>(math.min(int16(src)));
                case PrimalKind.uint16:
                    return generic<T>(math.min(uint16(src)));
                case PrimalKind.int32:
                    return generic<T>(math.min(int32(src)));
                case PrimalKind.uint32:
                    return generic<T>(math.min(uint32(src)));
                case PrimalKind.int64:
                    return generic<T>(math.min(int64(src)));
                case PrimalKind.uint64:
                    return generic<T>(math.min(uint64(src)));
                case PrimalKind.float32:
                    return generic<T>(math.min(float32(src)));
                case PrimalKind.float64:
                    return generic<T>(math.min(float64(src)));
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(math.max(int8(src)));
                case PrimalKind.uint8:
                    return generic<T>(math.max(uint8(src)));
                case PrimalKind.int16:
                    return generic<T>(math.max(int16(src)));
                case PrimalKind.uint16:
                    return generic<T>(math.max(uint16(src)));
                case PrimalKind.int32:
                    return generic<T>(math.max(int32(src)));
                case PrimalKind.uint32:
                    return generic<T>(math.max(uint32(src)));
                case PrimalKind.int64:
                    return generic<T>(math.max(int64(src)));
                case PrimalKind.uint64:
                    return generic<T>(math.max(uint64(src)));
                case PrimalKind.float32:
                    return generic<T>(math.max(float32(src)));
                case PrimalKind.float64:
                    return generic<T>(math.max(float64(src)));
                default:
                    throw unsupported(kind);                
            }
        }


        [MethodImpl(Inline)]
        public static T parse<T>(string src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return parseI8<T>(src);

            if(kind == PrimalKind.uint8)
                return parseU8<T>(src);

            if(kind == PrimalKind.int16)
                return parseI16<T>(src);

            if(kind == PrimalKind.uint16)
                return parseU16<T>(src);
            
            if(kind == PrimalKind.int32)
                return parseI32<T>(src);

            if(kind == PrimalKind.uint32)
                return parseU32<T>(src);

            if(kind == PrimalKind.int64)
                return parseI64<T>(src);

            if(kind == PrimalKind.uint64)
                return parseU64<T>(src);

            if(kind == PrimalKind.float32)
                return parseF32<T>(src);

            if(kind == PrimalKind.float64)
                return parseF64<T>(src);

            throw unsupported(kind);
        }
        
        [MethodImpl(Inline)]
        public static ref T sqrt<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref sqrtI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref sqrtI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref sqrtI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref sqrtI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref sqrtF32(ref src);

            if(kind == PrimalKind.float64)
                return ref sqrtF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return sqrtI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            if(kind == PrimalKind.int16)
                return sqrtI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int32)
                return sqrtI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return sqrtI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.float32)
                return sqrtF32(src);

            if(kind == PrimalKind.float64)
                return sqrtF64(src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref squareI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref squareI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref squareI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref squareI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref squareF32(ref src);

            if(kind == PrimalKind.float64)
                return ref squareF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T square<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return squareI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            if(kind == PrimalKind.int16)
                return squareI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int32)
                return squareI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return squareI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.float32)
                return squareF32(src);

            if(kind == PrimalKind.float64)
                return squareF64(src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T gcd<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return gcdI8(lhs, rhs);

            if(kind == PrimalKind.uint8)
                return gcdU8(lhs, rhs);

            if(kind == PrimalKind.int16)
                return gcdI16(lhs, rhs);

            if(kind == PrimalKind.uint16)
                return gcdU16(lhs, rhs);

            if(kind == PrimalKind.int32)
                return gcdI32(lhs, rhs);

            if(kind == PrimalKind.uint32)
                return gcdU32(lhs, rhs);

            if(kind == PrimalKind.int64)
                return gcdI64(lhs, rhs);

            if(kind == PrimalKind.uint64)
                return gcdU64(lhs, rhs);

            if(kind == PrimalKind.float32)
                return gcdF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return gcdF64(lhs, rhs);

            throw unsupported(kind);
        }           

        public static Span<T> scale<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    math.scale(int8(lhs), int8(factor), int8(dst));
                break;
                case PrimalKind.uint8:
                    math.scale(uint8(lhs), uint8(factor), uint8(dst));
                break;
                case PrimalKind.int16:
                    math.scale(int16(lhs), int16(factor), int16(dst));
                break;
                case PrimalKind.uint16:
                    math.scale(uint16(lhs), uint16(factor), uint16(dst));
                break;
                case PrimalKind.int32:
                    math.scale(int32(lhs), int32(factor), int32(dst));
                break;
                case PrimalKind.uint32:
                    math.scale(uint32(lhs), uint32(factor), uint32(dst));
                break;
                case PrimalKind.int64:
                    math.scale(int64(lhs), int64(factor), int64(dst));
                break;
                case PrimalKind.uint64:
                    math.scale(uint64(lhs), uint64(factor), uint64(dst));
                break;
                case PrimalKind.float32:
                      math.scale(float32(lhs), float32(factor), float32(dst));
                break;
                case PrimalKind.float64:
                    math.scale(float64(lhs), float64(factor), float64(dst));
                break;
                default:
                    throw unsupported(kind);                
            }
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ref Span<T> flip<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref flipI8(ref io);
                case PrimalKind.uint8:
                    return ref flipU8(ref io);
                case PrimalKind.int16:
                    return ref flipI16(ref io);
                case PrimalKind.uint16:
                    return ref flipU16(ref io);
                case PrimalKind.int32:
                    return ref flipI32(ref io);
                case PrimalKind.uint32:
                    return ref flipU32(ref io);
                case PrimalKind.int64:
                    return ref flipI64(ref io);
                case PrimalKind.uint64:
                    return ref flipU64(ref io);
                default:
                    throw unsupported(kind);                
            }
        }


 
        [MethodImpl(Inline)]
        static ref Span<T> flipI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU8<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint8(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.flip(ref x);
            return ref io;
        }
        

        [MethodImpl(Inline)]
        static ref Span<T> flipU16<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint16(io);
            math.flip(ref x);
            return ref io;
        }        

        [MethodImpl(Inline)]
        static ref Span<T> flipI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU32<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint32(io);
            math.flip(ref x);
            return ref io;
        }
        
        [MethodImpl(Inline)]
        static ref Span<T> flipI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU64<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint64(io);
            math.flip(ref x);
            return ref io;
        }
 
    }
}