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

    public class AssemblyRep : ClrItemRep
    {
        public AssemblyRep(string Name, int AssemblyId, IEnumerable<ClrModuleRep> modules, ClrRepTag? Tag = null)
            : base(Name, AssemblyId)
        {
            this.Modules = modules.ToArray();
        }
        
        public ClrModuleRep[] Modules {get;}
    }



}