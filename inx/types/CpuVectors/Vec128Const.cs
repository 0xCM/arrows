//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;


    abstract class Vec128Const<T>
        where T : struct
    {
        public static readonly int Length = Vec128<T>.Length;
        
        public static ref readonly Vec128<T> Ones
        {
            [MethodImpl(Inline)]
            get => ref OnesStorage;
        }

        protected static Vec128<T> OnesStorage;

        static Vec128Const()
        {
            var data = repeat(MaxVal, Length);
            OnesStorage = Load(ref Head(data));

        }

        protected static readonly T MaxVal = PrimalInfo.maxval<T>();

        protected static readonly T MinVal = PrimalInfo.minval<T>();

        protected static readonly T One = PrimalInfo.one<T>();

        protected static readonly T Zero = PrimalInfo.one<T>();

        protected static ref T Head(T[] src)
            => ref src[0];

        protected static ref T Head(Span<T> src)
            => ref src[0];

        protected static Vec128<T> Load(ref T src)     
            => Vec128.Load<T>(ref src);
    }

    static class Vec128Const
    {

        public class VecU8 : Vec128Const<byte>
        {
            static VecU8()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecI8 : Vec128Const<sbyte>
        {
            static VecI8()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecI16 : Vec128Const<short>
        {
            static VecI16()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecU16 : Vec128Const<ushort>
        {
            static VecU16()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecI32 : Vec128Const<int>
        {
            static VecI32()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecU32 : Vec128Const<uint>
        {
            static VecU32()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecI64 : Vec128Const<long>
        {
            static VecI64()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }


        public class VecU64 : Vec128Const<ulong>
        {
            static VecU64()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecF32 : Vec128Const<float>
        {
            static VecF32()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

        public class VecF64 : Vec128Const<double>
        {
            static VecF64()
            {
                var data = repeat(MaxVal, Length);
                OnesStorage = Load(ref Head(data));
            }
        }

    }


}