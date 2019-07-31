//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;


    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public class AsmMemInfo
    {
        
        public Char8? BaseRegister {get;set;}
        
        public uint? Displacement {get; set;}
        
        public int? IndexScale {get; set;}
        
        public int? DisplacementSize {get;set;}
        
        public Char8? SegmentRegister {get; set;}
        
        public Char8? SegmentPrefix {get; set;}
        
        public ulong Address {get; set;}

        public string Size {get; set;}
        
    }

}