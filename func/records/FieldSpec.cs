//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Reflection.Emit;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Characterizes a record field
    /// </summary>
    public class FieldSpec
    {
        public FieldSpec(string FieldName, int Position, ByteSize Offset, string FieldType)
        {
            this.FieldName = FieldName;
            this.Position = Position;
            this.Offset = Offset;
            this.FieldType = FieldType;
        }
        public string FieldName {get;}

        public int Position {get;}
        
        public ByteSize Offset {get;}

        public string FieldType {get;}

        
    }

}