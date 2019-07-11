//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    
    public abstract class PathComponent<T>
        where T : PathComponent<T>
    {
        public string Name {get;}

        protected PathComponent(string Name)
            => this.Name = Name;
        
        public override string ToString()
            => Name;
        
        public bool Nonempty
            => nonempty(Name);

    }

}