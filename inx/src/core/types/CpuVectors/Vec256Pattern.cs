//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Defines lookup/cache for common vector patterns
    /// </summary>
    public readonly struct Vec256Pattern<T> 
        where T : struct
    {

        public static readonly Vec256<T> Increasing = Vec256Pattern.Increments<T>();

        public static readonly Vec256<T> Decrements = Vec256Pattern.Decrements<T>(convert<T>(Vec256<T>.Length - 1));

        public static readonly Vec256<T> LaneMerge = MergeLanes();

        public static readonly Vec256<T> ClearAlt = ClearAlternating();

        static Vec256<T> ClearAlternating()
        {
            var mask = Span256.Alloc<T>(1);
            var chop = PrimalInfo.Get<T>().MaxVal;
            
            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i] = chop;
                else
                    mask[i] = convert<byte,T>(i);
            }

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i + half] = chop;
                else
                    mask[i + half] = convert<byte,T>(i);
            }

            return Vec256.Load(mask);
        }

        static Vec256<T> MergeLanes()
        {
            if(typeof(T) == typeof(byte))
                return MergeLanesU8().As<T>();
            else if(typeof(T) == typeof(ushort))
                return MergeLanesU16().As<T>();
            else throw unsupported<T>();
        }

        static Vec256<byte> MergeLanesU8()
        {
            //<0, 0, 2, 0, 4, 0, 6, 0, 8, 0, 10, 0, 12, 0, 14, 0, 16, 0, 18, 0, 20, 0, 22, 0, 24, 0, 26, 0, 28, 0, 30, 0>
            //<lo = i,i+2,i+4 ... n-2 | hi = i+1, i + 3, i+5, ... n-1 >           
            byte i = 0, j = 1;
            return Vec256.FromBytes(
                i, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2,
                j, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2
            );
        }

        static Vec256<ushort> MergeLanesU16()
        {
            ushort i = 0, j = 1;
            return Vec256.FromParts(
                i, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, 
                j, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2 
            );
        }
    }

}