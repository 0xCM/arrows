//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static nfunc;
    using static zfunc;


    public static class Dim
    {
        /// <summary>
        /// Constructs a 1-component natural dimension
        /// </summary>
        /// <typeparam name="K">The natural type</typeparam>
        public static Dim<K> define<K>()
            where K : ITypeNat, new()
                => Dim<K>.Rep;

        /// <summary>
        /// Constructs a 2-component natural dimension
        /// </summary>
        /// <typeparam name="K1">The type of the first component</typeparam>
        /// <typeparam name="K2">The type of the second component</typeparam>
        public static Dim<K1,K2> define<K1,K2>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Dim<K1,K2>.Rep;

        /// <summary>
        /// Constructs a 3-component natural dimension
        /// </summary>
        /// <typeparam name="K1">The type of the first component</typeparam>
        /// <typeparam name="K2">The type of the second component</typeparam>
        /// <typeparam name="K3">The type of the third component</typeparam>
        public static Dim<K1,K2,K3> define<K1,K2,K3>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Dim<K1,K2,K3>.Rep;
    }



}