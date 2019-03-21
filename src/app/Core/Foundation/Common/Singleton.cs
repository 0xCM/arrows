//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    /// <summary>
    /// Characterizes a type for which exactly one value may exist and that value
    /// must be obtainable via a parameterless new construction
    /// </summary>
    /// <typeparam name="T">The type of both the type and value so characterized</typeparam>
    public interface Singleton<T>
        where T : Singleton<T>, new()
    {
        T inhabitant {get;}        
    }

    public interface Infinity<T>
    {
        /// <summary>
        /// Specifies whether the infinity is positive
        /// </summary>
        bool positive {get;}

        /// <summary>
        /// Specifies whether the infinity is negative
        /// </summary>
        bool negative {get;}
    }
}
