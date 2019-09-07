namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public class AsmRdRand
    {
        
        static AsmRdRand()
        {
            var rdrand = new byte[] 
            { 
                0x0f, 0xc7, 0xf0,  // rdrand eax
                0x0f, 0x92, 0x01,  // setc byte ptr [rcx]                           
                0xc3               // ret
            };            
            
            Marshal.Copy(rdrand, 0, methodPtr<AsmRdRand>(nameof(RandNative)), rdrand.Length);
        
            
            var code = AsmCode.FromBytes<uint>(rdrand);
            var emitter = code.CreateEmitter();
            emitter();

            //var il = code.CreateEmitter().Method.GetMethodBody().GetILAsByteArray();
            //var emitter = code.CreateEmitter();
            //var il = emitter.Method.GetMethodBody().GetILAsByteArray();
            //var dst = methodPtr<AsmRdRand>(nameof(Next));
            //Marshal.Copy(il, 0, dst, il.Length);

        }


        [MethodImpl(Inline)]
        public static uint Rand()
            => RandNative();


        [MethodImpl(NotInline)]
        static uint RandNative()
        {
            var data = new byte[6];
            return 0;
        }



    }
}