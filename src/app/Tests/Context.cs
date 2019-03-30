namespace Z0
{
    using System;

    public static class Context
    {
        static readonly Guid s1 = Guid.Parse("ca3d0da1-271a-4c97-8d4b-062796bc2450");
        
        static readonly Guid s2 = Guid.Parse("83861b3a-8012-4edf-aaee-c7d7136117cf");
        
        public static readonly RandUInt Random = new RandUInt(s1,s2);

        public static Context<T> get<T>()
            => Context<T>.Current;
    }

    public class Context<T>
    {
        public static readonly Context<T> Current = new Context<T>();

        static readonly Guid s1 = Guid.Parse("ca3d0da1-271a-4c97-8d4b-062796bc2450");
        
        static readonly Guid s2 = Guid.Parse("83861b3a-8012-4edf-aaee-c7d7136117cf");
        
        static readonly RandUInt random = new RandUInt(s1,s2);


        public RandUInt Random = random;


    }   
}