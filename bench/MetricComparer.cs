//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class MetricComparer
    {

        public static void Validate(this MetricComparisonSpec spec, IMetrics lhs, IMetrics rhs)
            
        {
            switch(spec.Primitive)
            {
                case PrimalKind.int8:
                    Claim.eq(lhs.Results<sbyte>(), rhs.Results<sbyte>());
                    break;
                case PrimalKind.uint8:
                    Claim.eq(lhs.Results<byte>(), rhs.Results<byte>());
                    break;
                case PrimalKind.int16:
                    Claim.eq(lhs.Results<short>(), rhs.Results<short>());
                    break;
                case PrimalKind.uint16:
                    Claim.eq(lhs.Results<ushort>(), rhs.Results<ushort>());
                    break;
                case PrimalKind.int32:
                    Claim.eq(lhs.Results<int>(), rhs.Results<int>());
                    break;
                case PrimalKind.uint32:
                    Claim.eq(lhs.Results<uint>(), rhs.Results<uint>());
                    break;
                case PrimalKind.int64:
                    Claim.eq(lhs.Results<long>(), rhs.Results<long>());
                    break;
                case PrimalKind.uint64:
                    Claim.eq(lhs.Results<ulong>(), rhs.Results<ulong>());
                    break;
                case PrimalKind.float32:
                    Claim.eq(lhs.Results<float>(), rhs.Results<float>());
                    break;
                case PrimalKind.float64:                
                    Claim.eq(lhs.Results<double>(), rhs.Results<double>());
                    break;
                default:
                    throw unsupported(spec.Primitive);
            }
        }

    }
}