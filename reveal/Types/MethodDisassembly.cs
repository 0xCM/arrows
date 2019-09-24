//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;
    
    public class MethodDisassembly
    {
        public MethodBase MethodInfo {get; set;}

        public ulong NativeAddress {get;set;}

        public CodeBlock[] NativeBody {get;set;}

        public MethodSig MethodSig {get; set;}
    
        public byte[] CilData {get;set;}

    	public CilNativeMap[] CilMap {get;set;}

        public MethodAsmBody AsmBody {get;set;}

        public Option<CilFuncSpec> CilBody {get;set;}

        public string DefiningAssembly 
            => MethodInfo.DeclaringType.Assembly.GetSimpleName();

        public string DeclaringType 
            => MethodInfo.DeclaringType.FullName;        
        
        public string MethodName 
            => MethodInfo.Name;
    
    }
}