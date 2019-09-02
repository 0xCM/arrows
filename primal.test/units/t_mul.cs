//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using D = PrimalDelegates;
    
    public class t_mul : UnitTest<t_mul>
    {
        public void mul8i()        
            => VerifyOp((x,y) => (sbyte)(x * y), D.mul<sbyte>());
        
        public void mul8u()        
            => VerifyOp((x,y) => (byte)(x * y), D.mul<byte>());
                
        public void mul16i()        
            => VerifyOp((x,y) => (short)(x * y), D.mul<short>());        

        public void mul16u()        
            => VerifyOp((x,y) => (ushort)(x * y), D.mul<ushort>());            
        
        public void mul32i()        
            => VerifyOp((x,y) => (x * y), D.mul<int>());            
        
        public void mul32u()        
            => VerifyOp((x,y) => (x * y), D.mul<uint>());
                
        public void mul64i()        
            => VerifyOp((x,y) => (x * y), D.mul<long>());                    

        public void mul64u()
            => VerifyOp((x,y) => (x * y), D.mul<ulong>());            
        
        public void mul32f()        
            => VerifyOp((x,y) => (x * y), D.mul<float>());
        
        public void mul64f()        
            => VerifyOp((x,y) => (x * y), D.mul<double>());                  
    }
}