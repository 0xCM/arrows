//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{       
    using System.Linq;
    using static zfunc;

    public class App : TestApp<App>
    {           
        
        void TestBitMatrix()
        {
            // var m8 = BitMatrix8.Identity;

            // Claim.eq(m8[0,0], Bit.On);
            // Claim.eq(m8[1,1], Bit.On);
            // Claim.eq(m8[7,6], Bit.Off);
            // Claim.eq(m8[7,7], Bit.On);

            // print(m8.Format());


            // var m4 = BitMatrix4.Identity;
            // print(m4.Format());

            // var m16 = BitMatrix16.Identity;
            // Claim.eq(m16[0,0], Bit.On);
            // Claim.eq(m16[1,1], Bit.On);

            // print(m16.Format());

            var m32 = BitMatrix32.Identity;
            print(m32.Format());

        }
        
        protected override void RunTests(string filter)
        {            
            base.RunTests("BitMatrix");
            //TestBitMatrix();
            
        
        } 
        public static void Main(params string[] args)
            => Run(args);
    }
}