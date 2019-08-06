//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Specifies a dimension with an arbitrary number of axes
    /// </summary>
    public readonly struct DimK : IDim
    {
        public readonly ulong[] Axes;

        public static implicit operator DimInfo(DimK src)
            => new DimInfo(src.Order, src.Axes, src.Volume);

        public DimK(params ulong[] Axes)
        {
            this.Axes = Axes;            
        }

        public ulong this[int index]
        {
            get => (index < Axes.Length && index >= 0) ? Axes[index] : 0;
        }

        public readonly ulong Volume
        {
            get
            {
                var v = 1ul;
                for(var i=0; i<Axes.Length; i++)
                    v *= Axes[i];
                return v;
            }
        }

        public int Order 
            => Axes.Length;

    }


}