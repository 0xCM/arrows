//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// The category whose objects are finite sets and whose morphisms are
    /// maps between them; the category of finite sets
    /// </summary>
    public readonly struct CFinSet<T> 
    {
        public static readonly CFinSet<T> Inhabitant = default;
        
        public CFinSet<T> inhabitant 
            => Inhabitant;
    }


}