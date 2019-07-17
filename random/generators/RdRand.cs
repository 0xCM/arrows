namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class RdRand
    {
        static RdRand()
        {
            var instructions = new byte[] 
            { 
                0x0f, 0xc7, 0xf0,  // rdrand eax
                0x0f, 0x92, 0x01,  // setc byte ptr [rcx]                           
                0xc3               // ret
            };            
                
            Marshal.Copy(instructions, 0, typeof(RdRand).GetMethod(nameof(RandNative)).MethodHandle.GetFunctionPointer(), instructions.Length);
        }
 
    
        [MethodImpl(Inline)]
        public static uint Rand()
            => RandNative(out byte status);
    
        [MethodImpl(NotInline)]
        public static uint RandNative(out byte status)
        {
            status = 16;
            return 32;
        }
    }
}