//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static partial class dinx
    {

    }

    public static partial class dinxx
    {

    }


    public static partial class ginx
    {
        public class InitContext<T>
            where T : struct, IEquatable<T>
        {
            public readonly T one;

            public readonly T zero;

            public readonly Num128<T> n128One;

            public readonly Vec128<T> vOne128;

            public readonly Vec256<T> vOne256;

            public readonly int v128Len = Vec128<T>.Length;

            public readonly int v256Len = Vec256<T>.Length;

            public readonly T[] v128Data;

            public readonly T[] v256Data;

            public T[] v128Dst;

            public T[] v256Dst;


            public InitContext()
            {
                one = gmath.one<T>();
                zero = gmath.zero<T>();                

                v128Data = new T[v128Len];            
                v128Dst = new T[v128Len];
                for(var i = 0; i< v128Len; i++)
                    v128Data[i] = one;


                v256Data = new T[v256Len];
                v256Dst = new T[v256Len];
                for(var i = 0; i< v256Len; i++)
                    v256Data[i] = one;

                n128One = Num128.define(one);            
                vOne128 = Vec128.single(v128Data);
                vOne256 = Vec256.single(v256Data);

            }
        }


    }

    public static partial class ginxx
    {
        
    }

}