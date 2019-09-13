//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;


    public class ClrModuleRep : ClrItemRep
    {
        public ClrModuleRep(string Name, int Id, ClrRepTag? Tag = null)
            : base(Name, Id)
        {

        }
    }



}