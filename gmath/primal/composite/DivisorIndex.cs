namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;

    using static zfunc;
    using static mfunc;

    public static class DivisorIndex
    {
        public static DivisorIndex<T> define<T>(Interval<T> range, IReadOnlyList<DivisorList<T>> lists)
            where T : struct
                => new DivisorIndex<T>(range, lists);
    }

    /// <summary>
    /// Associates a contiguous sequence of dividends with their divisor lists
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DivisorIndex<T> 
        where T : struct
    {
        public DivisorIndex(Interval<T> Range, IReadOnlyList<DivisorList<T>> Lists)
        {
            this.Range = Range;
            this.Lookup = Lists.ToDictionary(x => x.Dividend, x => x);
        }

        public Interval<T> Range {get;}        

        IReadOnlyDictionary<T,DivisorList<T>> Lookup {get;}

        public DivisorList<T> this[T dividend]
            => Lookup[dividend];

        public IEnumerable<DivisorList<T>> Lists 
            => Lookup.Values;

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var item in Lists)
                sb.AppendLine(item.ToString());
            return sb.ToString();
        }
    }

}