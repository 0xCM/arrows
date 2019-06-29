//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public class MethodDisassembly
    {
        public MethodInfo MethodInfo {get; set;}

        public ulong NativeAddress {get;set;}

        public MethodSig MethodSig {get; set;}

        public byte[] NativeBytes {get;set;}

        public byte[] IlBytes {get;set;}

        public MethodAsmBody Asm {get;set;}

        public Option<MethodCilBody> Cil {get;set;}

        public string DefiningAssembly 
            => MethodInfo.DeclaringType.Assembly.GetSimpleName();

        public string DeclaringType 
            => MethodInfo.DeclaringType.FullName;        
        
        public string MethodName 
            => MethodInfo.Name;

        public override string ToString()
            => this.Format();
    }
}