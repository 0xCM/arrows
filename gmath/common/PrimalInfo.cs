//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    

    public interface IPrimalInfo : IKinded<PrimalKind>
    {
        
        bool Signed {get;}

        int Size {get;}
        
    }
    
    public interface IPrimalInfo<T> : IPrimalInfo
        where T : struct, IEquatable<T>
    {
        T MinVal {get;}

        T MaxVal {get;}
    }   

    public abstract class PrimalInfo<S> : IPrimalInfo
        where S : PrimalInfo<S>, new()
    {
        /// <summary>
        /// Singleton descriptor representative 
        /// </summary>
        public static readonly S Rep = new S();
        
        public PrimalKind Kind {get;}

        public bool Signed {get;}

        public int Size {get;}

        protected PrimalInfo(PrimalKind Kind, bool Signed)
        {
            this.Kind = Kind;
            this.Signed = Signed;
            switch(Kind)
            {
                case PrimalKind.uint8:
                case PrimalKind.int8:
                    Size = 1;
                 break;

                case PrimalKind.uint16:
                case PrimalKind.int16:
                    Size = 2;
                 break;

                case PrimalKind.uint32:
                case PrimalKind.int32:
                case PrimalKind.float32:
                    Size = 4;
                 break;

                case PrimalKind.uint64:
                case PrimalKind.int64:
                case PrimalKind.float64:
                    Size = 8;
                 break;
                default:
                    Size = -1;
                    break;

            }

        }

        public override bool Equals(object obj)
            => (obj as PrimalInfo<S>) != null 
              ? (obj as PrimalInfo<S>).Kind == this.Kind 
              : false;

        public override int GetHashCode()
            => Kind.GetHashCode();

    }

    public abstract class PrimalInfo<S,T> : PrimalInfo<S>, IPrimalInfo<T>
        where S : PrimalInfo<S,T>, new()
        where T : struct, IEquatable<T>
    {
        public T MinVal {get;}

        public T MaxVal {get;}

        protected PrimalInfo(bool Signed, T MinVal, T MaxVal)
            : base(PrimalKinds.kind<T>(), Signed)
        {
            this.MinVal = MinVal;
            this.MaxVal = MaxVal;
        }
        
        public override string ToString()
            => $"{Kind}".ToLower();
    }

    public static class PrimalInfo    
    {

        public static IPrimalInfo<T> Get<T>()
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
            {
                var rep = new I8();
                return Unsafe.As<I8, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.uint8)
            {
                var rep = new U8();
                return Unsafe.As<U8, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.int16)
            {
                var rep = new I16();
                return Unsafe.As<I16, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.uint16)
            {
                var rep = new U16();
                return Unsafe.As<U16, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.int32)
            {
                var rep = new I32();
                return Unsafe.As<I32, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.uint32)
            {
                var rep = new U32();
                return Unsafe.As<U32, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.int64)
            {
                var rep = new I64();
                return Unsafe.As<I64, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.uint64)
            {
                var rep = new U64();
                return Unsafe.As<U64, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.float32)
            {
                var rep = new F32();
                return Unsafe.As<F32, IPrimalInfo<T>>(ref rep);
            }

            if(kind == PrimalKind.float64)
            {
                var rep = new F64();
                return Unsafe.As<F64, IPrimalInfo<T>>(ref rep);
            }

            throw new Exception($"Kind {kind} not supported");

        }

        public static S Rep<S>()
            where S : PrimalInfo<S>, new()
                => PrimalInfo<S>.Rep;
        
        /// <summary>
        /// The I8 primtive singleton descriptor
        /// </summary>
        public static readonly I8 I8Rep = Rep<I8>();
        
        /// <summary>
        /// The U8 primtive singleton descriptor
        /// </summary>
        public static readonly U8 U8Rep = Rep<U8>();

        /// <summary>
        /// The I16 primtive singleton descriptor
        /// </summary>
        public static readonly I16 I16Rep = Rep<I16>();

        /// <summary>
        /// The U16 primtive singleton descriptor
        /// </summary>
        public static readonly U16 U16Rep = Rep<U16>();

        /// <summary>
        /// The I32 primtive singleton descriptor
        /// </summary>
        public static readonly I32 I32Rep = Rep<I32>();

        /// <summary>
        /// The U32 primtive singleton descriptor
        /// </summary>
        public static readonly U32 U32Rep = Rep<U32>();

        /// <summary>
        /// The I64 primtive singleton descriptor
        /// </summary>
        public static readonly I64 I64Rep = Rep<I64>();

        /// <summary>
        /// The U64 primtive singleton descriptor
        /// </summary>
        public static readonly U64 U64Rep = Rep<U64>();

        /// <summary>
        /// The F32 primtive singleton descriptor
        /// </summary>
        public static readonly F32 F32Rep = Rep<F32>();

        /// <summary>
        /// The F64 primtive singleton descriptor
        /// </summary>
        public static readonly F64 F64Rep = Rep<F64>();


        public sealed class I8 : PrimalInfo<I8,sbyte>
        {
            public I8()
                : base(true,sbyte.MinValue, sbyte.MinValue)
            {

            }
        }

        public sealed class U8 : PrimalInfo<U8,byte>
        {
            public U8()
            : base(false, byte.MinValue, byte.MaxValue)
            {


            }
        }

        public sealed class I16 : PrimalInfo<I16,short>
        {
            public I16()
                : base(true, short.MinValue, short.MaxValue)
            {

            }
        }

        public sealed class U16 : PrimalInfo<U16,ushort>
        {
            public  U16()
             : base(false, ushort.MinValue, ushort.MaxValue)
            {

            }
        }

        public sealed class I32 : PrimalInfo<I32,int>
        {
            public I32()
             : base(true, int.MinValue, int.MaxValue)
            {

            }
        }

        public sealed class U32 : PrimalInfo<U32,uint>
        {
            public U32()
             : base(false, uint.MinValue, uint.MaxValue)
            {

            }
        }

        public sealed class I64 : PrimalInfo<I64,long>
        {
            public I64()
             : base(true, long.MinValue, long.MaxValue)
            {

            }
        }

        public sealed class U64 : PrimalInfo<U64,ulong>
        {
            public U64()
             : base(false, ulong.MinValue, ulong.MaxValue)
            {

            }
        }

        public sealed class F32 : PrimalInfo<F32,float>
        {
            public F32()
             : base(true, float.MinValue, float.MaxValue)
            {

            }
        }

        public sealed class F64 : PrimalInfo<F64,double>
        {
            public F64()
             : base(true, double.MinValue, double.MaxValue)
            {

            }
        }
    }
}