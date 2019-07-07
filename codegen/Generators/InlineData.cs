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

    using static zfunc;

    public class InlineData : CodeGenerator
    {
        public static InlineData Generator(byte[] data, string propName)
            => new InlineData(data,propName);

        public static string GenAccessor(byte[] data, string propName)
            => new InlineData(data,propName).GenAccessor();

        public InlineData(byte[] data, string propName)
        {
            this.Data = data;
            this.PropName = propName;
        }

        public string PropName {get;}

        public byte[] Data {get;}

        public string GenLookups(Type valueType, string rootName)
        {
            //public static ulong Seed00 => Lookup(0)
            var sb = sbuild();
            for(var i=0; i<Data.Length; i++)
                sb.AppendLine($"public static {valueType.Name} {rootName}{i} => Lookup({i})");
            return sb.ToString();
        }

        public string GenAccessor()
        {
            var src = Data;
            var dst = sbuild();
            var linepad = AsciSym.Space.Replicate(4);
            dst.AppendLine($"static ReadOnlySpan<byte> {PropName} => new byte[]");
            dst.AppendLine("{");            
            dst.Append(linepad);
            for(var i=0; i<src.Length; i++)
            {
                var h = $"{src[i].ToHexString()}{AsciSym.Comma}";
                dst.Append($" {h}");
                if((i + 1) % 8 == 0)
                {
                    dst.AppendLine();
                    dst.Append(linepad);
                }
            }
            dst.AppendLine();
            dst.AppendLine("};");
            return dst.ToString();
        }
    }
}