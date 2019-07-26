namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public class RdRand
    {
        static RdRand()
        {
            var rdrand = new byte[] 
            { 
                0x0f, 0xc7, 0xf0,  // rdrand eax
                0x0f, 0x92, 0x01,  // setc byte ptr [rcx]                           
                0xc3               // ret
            };            
            
            Marshal.Copy(rdrand, 0, methodPtr<RdRand>(nameof(RandNative)), rdrand.Length);
        
            Marshal.Copy(AndInstructions.ToArray(), 0, methodPtr<RdRand>(nameof(AndNative)), AndInstructions.Length);
        
        }
 
        static ReadOnlySpan<byte> AndInstructions
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x23, 0xc2, 0xc3 };

        [MethodImpl(Inline)]
        public static uint Rand()
            => RandNative();

        [MethodImpl(Inline)]
        public static ulong And(ulong x, ulong y)
            => AndNative(x, y);


        [MethodImpl(NotInline)]
        static uint RandNative()
        {
            var data = new byte[6];
            return 0;
        }

        [MethodImpl(NotInline)]
        static ulong AndNative(ulong x, ulong y)
        {
            var data = new byte[AndInstructions.Length - 1];
            return 0;
        }


    }
}