//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class App : TestApp<App>
    {            

        protected override void RunTests()
        {
            var m = FastMod.computeM_u32(19);

            {
                var x = 17u;
                var y = 15u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 16u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }


            {
                var x = 17u;
                var y = 17u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 18u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 19u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 20u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 21u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 22u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }


            {
                var x = 17u;
                var y = 23u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }

            {
                var x = 17u;
                var y = 24u;
                var z = FastMod.mod(x, m, y);
                print($"{x} (8) {y} = {z}");
            }



        }

        public static void Main(params string[] args)
            => Run(args);
    }
}