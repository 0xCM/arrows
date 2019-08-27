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
        public Vec256<T> v00;

        public Vec256<T> v01;

        public Vec256<T> v10;

        public Vec256<T> v11;

        public static readonly int Length = 4*Vec256<T>.Length;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public static readonly int BitCount = 1024;

        public const int ByteCount = 128;

        public static readonly Vec1024<T> Zero = default;        

        [MethodImpl(Inline)]
        public Vec1024(Vec256<T> v0, Vec256<T> v1, Vec256<T> v2, Vec256<T> v3)     
        {
            this.v00 = v0;
            this.v01 = v1;
            this.v10 = v2;
            this.v11 = v3;
        }


        [MethodImpl(Inline)]
        public Vec1024<U> As<U>() 
            where U : struct
                => Unsafe.As<Vec1024<T>, Vec1024<U>>(ref Unsafe.AsRef(in this));         

        public override string ToString()
        {
            //Hi -> Lo
            return v11.ToString() + " | " + v10.ToString() + " | " + v01.ToString() + " | " + v00.ToString();
        }
    }     

}