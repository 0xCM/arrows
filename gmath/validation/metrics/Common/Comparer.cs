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
    using static mfunc;

    public static class MetricComparer
    {

        public static void Validate(this MetricComparisonSpec spec, IOpMetrics lhs, IOpMetrics rhs)
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

        public static BenchComparisonRecord Run(this MetricComparisonSpec spec, MetricConfig config = null)
        {            
            var lhs = spec.BaselineId.Run(true, config);
            var rhs = spec.BenchId.Run(false, config);        
            spec.Validate(lhs,rhs);
            
            var compare = lhs.Compare(rhs);
            var record = compare.ToRecord();
            var info = record.Describe();

            print(lhs.Describe(true));
            print(rhs.Describe(true));
            print(items(info));
            
            return record;                    
        }

         public static IEnumerable<BenchComparisonRecord> Run(this IEnumerable<MetricComparisonSpec> specs, MetricConfig config = null)
         {
             foreach(var spec in specs)
                yield return spec.Run(config);
         }   
    }
}