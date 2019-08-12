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

    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public struct Vec1024<T>
        where T : struct
    {            
        public static readonly int Length = 4*Vec256<T>.Length;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public static readonly int BitCount = 1024;

        public const int ByteCount = 128;

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

    public static class Vec1024X
    {
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
                throw new OutOfMemoryException($"{index}");
        }

    }
}