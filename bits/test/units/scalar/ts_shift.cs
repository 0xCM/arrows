//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class ts_shift : UnitTest<ts_shift>
    {

        public void shift8i()
        {
            var lhs = Random.Array<sbyte>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<sbyte>.BitSize));            

            Shift<sbyte>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq((sbyte)(lhs[i] << rhs[i]), gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<sbyte>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq((sbyte)(lhs[i] >> rhs[i]), gbits.sra(lhs[i], rhs[i])));    
        }

        public void shift8u()
        {
            var lhs = Random.Array<byte>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<byte>.BitSize));            

            Shift<byte>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq((byte)(lhs[i] << rhs[i]), gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<byte>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq((byte)(lhs[i] >> rhs[i]), gbits.sra(lhs[i], rhs[i])));    
        }

        public void shift32i()
        {
            var lhs = Random.Array<int>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<int>.BitSize));            

            Shift<int>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<int>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] >> rhs[i], gbits.sra(lhs[i], rhs[i])));
        }

        public void shift32u()
        {
            var lhs = Random.Array<uint>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<uint>.BitSize));            

            Shift<uint>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<uint>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] >> rhs[i], gbits.sra(lhs[i], rhs[i])));

        }
        public void shift64i()
        {
            var lhs = Random.Array<long>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<long>.BitSize));            

            Shift<long>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<long>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] >> rhs[i], gbits.sra(lhs[i], rhs[i])));
        }

        public void shift64u()
        {
            var lhs = Random.Array<ulong>(SampleSize);            
            var rhs = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<ulong>.BitSize));            

            Shift<ulong>(Orientation.Left, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<ulong>(Orientation.Right, lhs, rhs);        
            iter(SampleSize, i => Claim.eq(lhs[i] >> rhs[i], gbits.sra(lhs[i], rhs[i])));
        }


        void Shift<T>(Orientation dir, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {            
            var x = lhs.Replicate();

            if(dir == Orientation.Left)
            {
                for(var i=0; i< SampleSize; i++)
                {
                    gbits.shiftl(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.shiftl(lhs[i],rhs[i]));
                }
            }
            else
            {
                for(var i=0; i< SampleSize; i++)
                {
                    gbits.sra(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.sra(lhs[i],rhs[i]));
                }
            }
        }

    }

}
