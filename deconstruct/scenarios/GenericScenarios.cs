namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static zfunc;

    class GenericScenarios
    {
        public static MethodDisassembly[] GInX()
        {
            var opnames = set
            (
                nameof(ginx.add),
                nameof(ginx.sub),
                nameof(ginx.and),
                nameof(ginx.or),
                nameof(ginx.xor)
            );
            var open = typeof(ginx).Methods().Public().OpenGeneric().Where(m => opnames.Contains(m.Name));
            var closed = from om in open
                        from t in PrimalTypes.All
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm;
            return closed.Deconstruct("ginx");
        }


        static IEnumerable<MethodInfo> CloseOpenGenerics(IEnumerable<MethodInfo> open, IEnumerable<Type> args)
            =>  from om in open
                from t in args
                let def = om.GetGenericMethodDefinition()
                let gm = def.MakeGenericMethod(t)
                select gm;

        public static MethodDisassembly[] GMath()
        {
            var opnames = set(
                nameof(gmath.add), 
                nameof(gmath.sub), 
                nameof(gmath.mul), 
                nameof(gmath.div), 
                nameof(gmath.mod)
                );

            var unopnames = set(
                nameof(gmath.negate),
                nameof(gmath.inc),
                nameof(gmath.dec));

            var closedBinOps = CloseOpenGenerics(gmath.BinOps().Where(m => opnames.Contains(m.Name)), PrimalTypes.All);
            var closedUnaryOps = CloseOpenGenerics(gmath.UnaryOps().Where(m => unopnames.Contains(m.Name)), PrimalTypes.All);
            var closedOps = closedBinOps.Union(closedUnaryOps);
            
            return closedOps.Deconstruct("gmath");
        }

    }

}