//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    sealed class VslSSTaskF32 : VslSSTask<float>
    {
        public static VslSSTaskF32 Define(int Dim,  float[] Samples)
        {
            var task = new VslSSTaskF32(Dim, Samples);
            task.Allocate().AutoThrow();
            return task;
        }
                 
        public VslSSTaskF32(int Dim,  float[] Samples)
            : base(Dim, Samples)
        {
            
        }

        public VslSSTaskF32(int Dim,  float[] Samples, float[] Weights, int[] Indices)
            : base(Dim, Samples, Weights, Indices)
        {

        }


        public unsafe override VslSSStatus Allocate()
        {
           
            if(Weights.Length == 0 && Indices.Length == 0)
                return VSL.vslsSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0]);
            else if(Weights.Length != 0 && Indices.Length == 0)
                return VSL.vslsSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], ref Weights[0]);
            else if(Weights.Length != 0 && Indices.Length != 0)
                return VSL.vslsSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], ref Weights[0], ref Indices[0]);
            else //Weights.Length == 0 && Indices.Length != 0)  
                return VSL.vslsSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], null, ref Indices[0]);

        }
    }


}