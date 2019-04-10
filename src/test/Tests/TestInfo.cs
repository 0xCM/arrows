//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public abstract class component
    {
        public abstract string name {get;}

        public abstract string path {get;} 

    }

    public static class Paths
    {
        public const string numeric = "numeric/";

        public const string structures = "structures/";

        public const string digits = numeric + "digits/";

        public const string bits = numeric + "bits/";

        public const string numstructs = numeric + structures;

        public const string generic = numstructs + "G/";

        public const string primops = numeric + "primops/";

        public const string primconv = primops + "convert/";

        public const string intG = generic + "int/";

        public const string realG = generic + "real/";

        public const string floatG = generic + "float/";

        public const string analogs = numstructs + "analogs/";

        public const string binary = "binary/";

        public const string @decimal = "binary/";

        public const string hex = "hex/";
        public const string int8 = "int8/";

        public const string uint8 = "uint8/";

        public const string int16 = "int16/";

        public const string uint16 = "uint16/";

        public const string int32 = "int32/";

        public const string uint32 = "uint32/";

        public const string int64 = "int64/";

        public const string uint64 = "uint64/";

        public const string float32 = "float32/";

        public const string float64 = "float64/";

        public const string add = "add/";

        public const string mul = "mul/";

        public const string div = "div/";

        public const string mod = "mod/";

        public const string gcd = "gcd/";

        public const string pow = "pow/";

        public const string and = "and/";
        
        public const string or = "or/";

        public const string xor = "xor/";

        public const string flip = "flip/";

    }

    public class TestInfo
    {

    }
}
