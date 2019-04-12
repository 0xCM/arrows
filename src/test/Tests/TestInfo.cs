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

    /// <summary>
    /// Defines testing-related uri segments
    /// </summary>
    public static class Paths
    {
        /// <summary>
        /// Identifies the topic of algebra
        /// </summary>
        public const string algebra = "algebra/";

        
        /// <summary>
        /// Identifies the topic of numerics
        /// </summary>
        public const string numeric = "numeric/";

        /// <summary>
        /// Identifies the topic of symbolic computation
        /// </summary>
        public const string symbolic = "symbolic/";
        
        /// <summary>
        /// Identifies the topic of linear algebra
        /// </summary>
        public const string linalg = "linear-algebra/";

        /// <summary>
        /// Identifies the topic of symbolic algebra
        /// </summary>
        public const string symalg = algebra + symbolic;

        /// <summary>
        /// Identifies the topic of numeric linear algebra
        /// </summary>
        public const string nla = numeric + linalg;

        /// <summary>
        /// Identifies vector data structures
        /// </summary>
        public const string vectors = "vectors/";

        /// <summary>
        /// Identifies matrix data structures
        /// </summary>
        public const string matrices = "matrices/";

        /// <summary>
        /// Identifies data structures
        /// </summary>
        public const string structures = "structures/";

        public const string digits = numeric + "digits/";

        public const string bits = numeric + "bits/";

        /// <summary>
        /// Identifies primitive data structures and/or operations
        /// </summary>
        public const string primitive = "primitive/";

        /// <summary>
        /// Identifies numeric structures
        /// </summary>
        public const string numstructs = numeric + structures;

        /// <summary>
        /// Identifies primitive operations
        /// </summary>
        public const string primops = numeric + "primops/";

        /// <summary>
        /// Identifies primitive conversion operations
        /// </summary>
        public const string primconv = primops + "convert/";


        /// <summary>
        /// Identifies structural analogs
        /// </summary>
        public const string analogs = numstructs + "analogs/";

        /// <summary>
        /// Identifies a binary digit
        /// </summary>
        public const string binary = "binary/";

        /// <summary>
        /// Identifies a decimal digit
        /// </summary>
        public const string @decimal = "binary/";

        /// <summary>
        /// Identifies a hexadecimal digit
        /// </summary>
        public const string hex = "hex/";
        
        /// <summary>
        /// Identifies a primitive int8 data type
        /// </summary>
        public const string int8 = "int8/";

        /// <summary>
        /// Identifies a generic int8 data type
        /// </summary>
        public const string int8g = "int8g/";

        /// <summary>
        /// Identifies a primitive uint8 data type
        /// </summary>
        public const string uint8 = "uint8/";

        /// <summary>
        /// Identifies a generic uint8 data type
        /// </summary>
        public const string uint8g = "uint8g/";

        /// <summary>
        /// Identifies a primitive int16 data type
        /// </summary>
        public const string int16 = "int16/";

        /// <summary>
        /// Identifies a generic int16 data type
        /// </summary>
        public const string int16g = "int16g/";

        /// <summary>
        /// Identifies a primitive uint16 data type
        /// </summary>
        public const string uint16 = "uint16/";

        /// <summary>
        /// Identifies a generic uint16 data type
        /// </summary>
        public const string uint16g = "uint16g/";

        /// <summary>
        /// Identifies a primitive int32 data type
        /// </summary>
        public const string int32 = "int32/";

        /// <summary>
        /// Identifies a generic int32 data type
        /// </summary>
        public const string int32g = "int32g/";

        /// <summary>
        /// Identifies a primitive uint32 data type
        /// </summary>
        public const string uint32 = "uint32/";

        /// <summary>
        /// Identifies a generic uint32 data type
        /// </summary>
        public const string uint32g = "uint32g/";

        /// <summary>
        /// Identifies a primitive int64 data type
        /// </summary>
        public const string int64 = "int64/";

        /// <summary>
        /// Identifies a generic int64 data type
        /// </summary>
        public const string int64g = "int64g/";

        /// <summary>
        /// Identifies a primitive uint64 data type
        /// </summary>
        public const string uint64 = "uint64/";

        /// <summary>
        /// Identifies a generic uint64 data type
        /// </summary>
        public const string uint64g = "uint64g/";

        /// <summary>
        /// Identifies a primtive float32 := System.Single data type
        /// </summary>
        public const string float32 = "float32/";

        /// <summary>
        /// Identifies a generic float32 := System.Single data type
        /// </summary>
        public const string float32g = "float32g/";

        /// <summary>
        /// Identifies a primitive float64 := System.Double data tpe
        /// </summary>
        public const string float64 = "float64/";

        /// <summary>
        /// Identifies a generic float64 := System.Double data tpe
        /// </summary>
        public const string float64g = "float64g/";


        /// <summary>
        /// Identifies a generic real uint8 data type
        /// </summary>
        public const string realu8 = "realg/uint8/";
        
        /// <summary>
        /// Identifies a generic real uint16 data type
        /// </summary>
        public const string realu16 = "realg/uint16/";
        
        /// <summary>
        /// Identifies a generic real uint32 data type
        /// </summary>
        public const string realu32 = "realg/uint32/";
        
        /// <summary>
        /// Identifies a generic real uint64 data type
        /// </summary>
        public const string realu64 = "realg/uint64/";

        /// <summary>
        /// Identifies a generic real int8 data type
        /// </summary>
        public const string reali8 = "realg/int8/";
        
        /// <summary>
        /// Identifies a generic real int16 data type
        /// </summary>
        public const string reali16 = "realg/int16/";
        
        /// <summary>
        /// Identifies a generic real int32 data type
        /// </summary>
        public const string reali32 = "realg/int32/";
        
        /// <summary>
        /// Identifies a generic real int64 data type
        /// </summary>
        public const string reali64 = "realg/int64/";

        /// <summary>
        /// Identifies a generic real float32 (single) data type
        /// </summary>
        public const string realf32 = "realg/float32/";
        
        /// <summary>
        /// Identifies a generic real float64 (double) data type
        /// </summary>
        public const string realf64 = "realg/float64/";
        
        /// <summary>
        /// Identifies a generic real decimal data type
        /// </summary>
        public const string realdec = "realg/decimal/";


        /// <summary>
        /// Identifies an add operation
        /// </summary>
        public const string add = "add/";

        /// <summary>
        /// Identifies a multiplication operation
        /// </summary>
        public const string mul = "mul/";

        /// <summary>
        /// Identifies a division operation
        /// </summary>
        public const string div = "div/";

        /// <summary>
        /// Identifies a modulus operation
        /// </summary>
        public const string mod = "mod/";

        /// <summary>
        /// Identifies a gcd operation
        /// </summary>
        public const string gcd = "gcd/";

        /// <summary>
        /// Identifies a power operation
        /// </summary>
        public const string pow = "pow/";

        /// <summary>
        /// Identifies a factorial operation
        /// </summary>
        public const string fact = "fact/";

        /// <summary>
        /// Identifies a bitwise and operation
        /// </summary>
        public const string and = "and/";
        
        /// <summary>
        /// Identifies a bitwise or operation
        /// </summary>
        public const string or = "or/";

        /// <summary>
        /// Identifies a bitwise xor operation
        /// </summary>
        public const string xor = "xor/";

        /// <summary>
        /// Identifies a bitwise flip (two's complement) operation
        /// </summary>
        public const string flip = "flip/";

        /// <summary>
        /// Identifies an increment operation
        /// </summary>
        public const string inc = "inc/";


        /// <summary>
        /// Identifies an decrement operation
        /// </summary>
        public const string dec = "dec/";

        /// <summary>
        /// Identifies an equality operation
        /// </summary>
        public const string eq = "eq/";

        /// <summary>
        /// Identifies a non-equality comparison operation
        /// </summary>
        public const string neq = "neq/";

        /// <summary>
        /// Identifies an less-than operation
        /// </summary>
        public const string lt = "lt/";

        /// <summary>
        /// Identifies an greate-than operation
        /// </summary>
        public const string gt = "gt/";

        /// <summary>
        /// Identifies an greater-than-or-equal operation
        /// </summary>
        public const string gteq = "gteq/";


        /// <summary>
        /// Identifies an less-than-or-equal operation
        /// </summary>
        public const string lteq = "lteq/";


    }
}
