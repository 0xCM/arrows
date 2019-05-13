//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{


    public interface IParser<T>
    {
        Option<T> tryParse(string src);


        T parse(string src);
    }



}