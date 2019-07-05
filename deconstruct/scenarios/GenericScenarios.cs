namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

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

        public static MethodDisassembly[] GMath()
        {
            var opnames = set(
                nameof(gmath.add), 
                nameof(gmath.sub), 
                nameof(gmath.mul), 
                nameof(gmath.div), 
                nameof(gmath.mod)
                );

            var open = gmath.BinOps().Where(m => opnames.Contains(m.Name));
            var closed = from om in open
                        from t in PrimalTypes.All
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm;

            return closed.Deconstruct("gmath");
        }

    }

}