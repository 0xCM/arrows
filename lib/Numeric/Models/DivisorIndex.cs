namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;

    using static zcore;

    public static class DivisorIndex
    {
        public static DivisorIndex<T> define<T>(Interval<T> range, IReadOnlyList<DivisorList<T>> lists)
            where T : struct, IEquatable<T>
                => new DivisorIndex<T>(range, lists);
    }

    /// <summary>
    /// Associates a contiguous sequence of dividends with their divisor lists
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DivisorIndex<T> : Formattable
        where T : struct, IEquatable<T>
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

        public string format()
        {
            var sb = new StringBuilder();
            foreach(var item in Lists)
                sb.AppendLine(item.format());
            return sb.ToString();
        }

        public override string ToString()
            => format();
    }

}