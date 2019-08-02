//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public static class Vec1024
    {
        [MethodImpl(Inline)]
        public static ref Vec1024<uint> Merge(in Vec256<ulong> x, in Vec256<ulong> y, out Vec1024<uint> dst)
        {
            var loMask = Vec256.fill(Bits.LoMask64);            
            var xl = Bits.and(x, loMask).As<uint>();
            var xh = Bits.shiftr(x, 32).As<uint>();
            var yl = Bits.and(y, loMask).As<uint>();
            var yh = Bits.shiftr(y, 32).As<uint>();
            dst = Vec1024.Define(xl, xh, yl, yh);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Vec1024<T> Define<T>(in Vec256<T> v0, in Vec256<T> v1, in Vec256<T> v2, in Vec256<T> v3)        
            where T : struct
                => new Vec1024<T>(v0, v1, v2, v3);
        
        [MethodImpl(Inline)]
        public static ref Vec256<T> At<T>(this ref Vec1024<T> src, int index)
            where T : struct
        {
            if(index == 0)
                return ref src.v0;
            else if(index == 1)
                return ref src.v1;
            else if(index == 2)
                return ref src.v2;
            else if(index == 3)
                return ref src.v3;
            else
                throw Errors.OutOfRange(index, 0, 3);
        }

        [MethodImpl(Inline)]
        public static unsafe Span<T> Segment<T>(this ref Vec1024<T> src, int offset, int len)
            where T : struct
        {
            var askByteOffset = offset * Vec1024<T>.CellSize;
            var askByteCount = len * Vec1024<T>.CellSize;
            var haveByteCount = Pow2.T07 - askByteOffset;
            if(askByteCount > haveByteCount)
                throw Errors.TooManyBytes(askByteCount, haveByteCount);
            ref var dst = ref Unsafe.Add(ref src, offset);
            var pDst = Unsafe.AsPointer(ref dst);
            return new Span<T>(pDst,len);
        }


    }

    [StructLayout(LayoutKind.Sequential, Size = Pow2.T07)]
    public struct Vec1024<T>
        where T : struct
    {        
    
        public static readonly int Length = 4*Vec256<T>.Length;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public static readonly int BitCount = 1024;

        public static readonly Vec1024<T> Zero = default;
        
        internal Vec256<T> v0;

        internal Vec256<T> v1;

        internal Vec256<T> v2;

        internal Vec256<T> v3;


        [MethodImpl(Inline)]
        public Vec1024(Vec256<T> v0, Vec256<T> v1, Vec256<T> v2, Vec256<T> v3)     
        {
            this.v0 = v0;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }


        [MethodImpl(Inline)]
        public Vec1024<U> As<U>() 
            where U : struct
                => Unsafe.As<Vec1024<T>, Vec1024<U>>(ref Unsafe.AsRef(in this));         

        public override string ToString()
        {
            //Hi -> Lo
            return v3.ToString() + " | " + v2.ToString() + " | " + v1.ToString() + " | " + v0.ToString();
        }
    }     
}