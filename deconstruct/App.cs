//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public class DisaTests
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> add1(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

    }

    public class App
    {            
    
        static IEnumerable<MethodDisassembly> Disassemble(IEnumerable<MethodInfo> methods)
            => Deconstructor.Disassemble(methods.ToArray());

        void Analyze(MethodDisassembly d)
        {
            magenta(d);
        }

        void Disassemble()
        {
            var methods = typeof(Vec128).DeclaredMethods().Static().NonGeneric().ToList();
            //var methods = typeof(dinx).DeclaredMethods().NonGeneric().Public().ToList();
            //var methods = typeof(DisaTests).DeclaredMethods().ToList();
            print($"Method Count: {methods.Count}");
            iter(Disassemble(methods), Analyze);
    
        }

        void Run()
        {

            try
            {
                Disassemble();
            }
            catch(Exception e)
            {
                print(errorMsg(e));
            }
        }

        public static void Main(params string[] args)
            => new App().Run();

    }

}