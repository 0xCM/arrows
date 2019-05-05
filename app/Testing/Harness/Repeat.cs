//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    
    using static zcore;



    public class RepeatAttribute  : Attribute
    {
        public static int Repetitions(MethodBase method) 
            => method.CustomAttribute<RepeatAttribute>().Map(a => a.Count, () => 1);

        public RepeatAttribute()
        {
            Count = 1;
        }

        public RepeatAttribute(int Repetitions)
            => this.Count = Repetitions;

        public int Count {get;}
    }

}