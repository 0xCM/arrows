//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Microsoft.Z3;
    using Z3 = Microsoft.Z3;
    using Z3C = Microsoft.Z3.Context;

    using static zfunc;

   public static class Z3Examples
    {
        /// <summary>
        /// Simple bit-vector example.
        /// </summary>
        /// <remarks>
        /// This example disproves that x - 10 &lt;= 0 IFF x &lt;= 10 for (32-bit) machine integers
        /// </remarks>
        public static void BitvectorExample1()
        {
            var ctx = new Z3.Context();
            using var svc = Z3Api.Own(ctx);

            
            var bv_type = ctx.MkBitVecSort(32);
            var x = (BitVecExpr)ctx.MkConst("x", bv_type);
            var zero = (BitVecNum)ctx.MkNumeral("0", bv_type);
            BitVecNum ten = ctx.MkBV(10, 32);
            BitVecExpr x_minus_ten = ctx.MkBVSub(x, ten);
            /* bvsle is signed less than or equal to */
            BoolExpr c1 = ctx.MkBVSLE(x, ten);
            BoolExpr c2 = ctx.MkBVSLE(x_minus_ten, zero);
            BoolExpr thm = ctx.MkIff(c1, c2);
            print("disprove: x - 10 <= 0 IFF x <= 10 for (32-bit) machine integers");
            Disprove(ctx, thm);
        }

        /// <summary>
        /// Find x and y such that: x ^ y - 103 == x * y
        /// </summary>
        public static void BitvectorExample2()
        {
            print("BitvectorExample2");
            using var svc = Z3Api.Create();

            var bvSize = default(N32);
            /* construct x ^ y - 103 == x * y */
            var x = svc.BvConst("x", bvSize);
            var y = svc.BvConst("y", bvSize);
            var x_xor_y = svc.XOr(x, y);
            var c103 = svc.BvNumeral("103",bvSize);
            var lhs = svc.Sub(x_xor_y, c103);
            var rhs = svc.Mul(x, y);
            var ctr = svc.Eq(lhs, rhs);

            print("find values of x and y, such that x ^ y - 103 == x * y");

            /* find a model (i.e., values for x an y that satisfy the constraint */
            Model m = Check(svc, ctr, Status.SATISFIABLE);
            foreach(var e in m.Consts)
                print($"{e.Key.Name}:{e.Key.ASTKind} = {e.Value}");
        }

        public static void BvExamples()
        {
            BvExample1();

        }

        public static void EnumExamples()
        {
            using var svc = Z3Api.Create();
            var choices = svc.Enum("Choices", "ChoiceA", "ChoiceB", "ChoiceC");
            for(var i = 0u; i<choices.Consts.Length; i++)
            {
                inform($"Choice {i} = {choices.Const(i)}");
            }

        }

        public static void BvExample1()
        {
            using var svc = Z3Api.Create();
            var x = svc.BvVal(3);
            var y = svc.BvVal(5);
            var z = svc.Or(x,y);      
            var eval = z.Simplify();
            inform($"{z.SExpr()} = {eval}:{eval.ASTKind}");


        }
        
        static void Disprove(Z3.Context ctx, BoolExpr f, bool useMBQI = false, params BoolExpr[] assumptions)
        {
            Console.WriteLine("Disproving: " + f);
            Solver s = ctx.MkSolver();
            Params p = ctx.MkParams();
            p.Add("mbqi", useMBQI);
            s.Parameters = p;
            foreach (BoolExpr a in assumptions)
                s.Assert(a);
            s.Assert(ctx.MkNot(f));
            Status q = s.Check();

            switch (q)
            {
                case Status.UNKNOWN:
                    Console.WriteLine("Unknown because: " + s.ReasonUnknown);
                    break;
                case Status.SATISFIABLE:
                    Console.WriteLine("OK, model: " + s.Model);
                    break;
                case Status.UNSATISFIABLE:
                    throw new Exception("Test failed");
            }
        }    


        static void Prove(Z3.Context ctx, BoolExpr f, bool useMBQI = false, params BoolExpr[] assumptions)
        {
            Console.WriteLine("Proving: " + f);
            Solver s = ctx.MkSolver();
            Params p = ctx.MkParams();
            p.Add("mbqi", useMBQI);
            s.Parameters = p;
            foreach (BoolExpr a in assumptions)
                s.Assert(a);
            s.Assert(ctx.MkNot(f));
            Status q = s.Check();

            switch (q)
            {
                case Status.UNKNOWN:
                    Console.WriteLine("Unknown because: " + s.ReasonUnknown);
                    break;
                case Status.SATISFIABLE:
                    throw new Exception("Test failed");
                case Status.UNSATISFIABLE:
                    Console.WriteLine("OK, proof: " + s.Proof);
                    break;
            }
        }        

        static Model Check(Z3.Context ctx, BoolExpr f, Status sat)
        {
            Solver s = ctx.MkSolver();
            s.Assert(f);
            if (s.Check() != sat)
                throw new Exception("Test Failed");
            if (sat == Status.SATISFIABLE)
                return s.Model;
            else
                return null;
        }        

    }   



}