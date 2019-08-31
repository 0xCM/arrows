//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    
    class FsmContext : Context<FsmContext>, IFsmContext
    {

        public FsmContext(IRandomSource random, ulong? receiptLimit = null)
            : base(random)
        {
            this.ReceiptLimit = receiptLimit ?? (ulong)Pow2.T14;
        }

        /// <summary>
        /// If specified, the maximum number of event submissions the machine
        /// will accept prior to forced termination
        /// </summary>
        public ulong? ReceiptLimit {get;}

    }

}