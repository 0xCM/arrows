//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;

    using static zfunc;

    public class RngConfig
    {

        /// <summary>
        /// Identifies the generator being configured
        /// </summary>
        public RngKind RngId {get;}

        /// <summary>
        /// If specified, contains seed with which the rng will be intitalized.
        /// If unspecified, an entropic seed will be used
        /// </summary>
        /// <value></value>
        public byte[] Seed {get;}

    }

}