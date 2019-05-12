//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    
    using static mfunc;
    
    using static ClrConverters;


    /// <summary>
    /// Defines primary primitive conversion api
    /// </summary>
    public static class ClrConverter
    {
    
        /// <summary>
        /// Effects x:S => convert(x):T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>        
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T convert<S,T>(S src)
            where T : struct, IEquatable<T>
            where S : struct, IEquatable<S>
                => mfunc.convert<S,T>(src);


    }
}