//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class Dim
    {
        /// <summary>
        /// Constructs an natural dimension of order 1
        /// </summary>
        /// <typeparam name="N">The axis type</typeparam>
        public static Dim<N> Define<N>()
            where N : ITypeNat, new()
                => Dim<N>.Rep;

        /// <summary>
        /// Constructs an natural dimension of order 2
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        public static Dim<M,N> Define<M,N>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Dim<M,N>.Rep;

        /// <summary>
        /// Constructs an natural dimension of order 3
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        /// <typeparam name="P">The type of the third axis</typeparam>
        public static Dim<M,N,P> Define<M,N,P>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
                => Dim<M,N,P>.Rep;
    
        /// <summary>
        /// Defines a dimension of order 1
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        public static Dim1 Define(ulong i)
            => new Dim1(i);

        /// <summary>
        /// Defines a dimension of order 2 
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        public static Dim2 Define(ulong i, ulong j)
            => new Dim2(i, j);

        /// <summary>
        /// Defines a dimension of order 3 
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        public static Dim3 Define(ulong i, ulong j, ulong k)
            => new Dim3(i, j, k);


        /// <summary>
        /// Constructs a dimension of arbitrary order
        /// </summary>
        /// <param name="axes">The axes that comprise the dimension</param>
        public static DimK Define(params ulong[] axes)
            => new DimK(axes);

    }


}