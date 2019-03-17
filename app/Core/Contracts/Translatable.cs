//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    using System;

    /// <summary>
    /// Provides a backdoor to a static factory method
    /// </summary>
    /// <typeparam name="S"></typeparam>    
    public interface Redefinable<S>
    {
        S redefine(S src);
    }
    public interface Translatable<S>
    {
        T translate<T>(Func<S,T> f);
    }

    public static class Translatable
    {
        public static T Translate<S,T>(this S src, Func<S,T> f)
            where S : Translatable<S>
            where T : new()
                => src.translate(f);

    }

}