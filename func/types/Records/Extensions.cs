//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Reflection.Emit;
    using System.Linq;

    using static zfunc;

    public static class RecordX
    {
        /// <summary>
        /// Manufactures the type that reifies the record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type CreateType(this RecordSpec spec)        
            => Record.CreateType(spec);

        public static IEnumerable<Type> CreateTypes(this IEnumerable<RecordSpec> specs)
            => Record.CreateTypes(specs.ToArray());
         
    }

}