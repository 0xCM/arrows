//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{


    partial class Operative
    {
        public interface Parser<T>
        {
            Option<T> tryParse(string src);


            T parse(string src);
        }

        public interface Parseable<T>
        {
            Parser<T> parser();
        }

    }

}