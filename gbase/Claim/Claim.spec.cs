//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
        
    using static zfunc;
    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using static ErrorMessages;

    public interface IClaims<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        bool Eq(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null) 
            => lhs.Equals(rhs) ? true : throw Claim.failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));
    }

    public class Claims<T> : IClaims<T>
        where T : struct
    {


    }

}