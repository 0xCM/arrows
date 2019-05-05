//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    /// <summary>
    /// Defines a basic vocabulary for resource attribution
    /// </summary>
    public static class Bibliography
    {

        /// <summary>
        /// Represents a bibliographic resource identifier
        /// </summary>
        public readonly struct Identifier
        {
            /// <summary>
            /// Defines a resource identifier 
            /// </summary>
            /// <param name="year">The year of publication</param>
            /// <param name="moniker">An alphanumeric identifier</param>
            /// <returns></returns>
            public static Identifier define(int year, string moniker)
                => new Identifier(year,moniker);

            /// <summary>
            /// Parses a bibliographic resource identifier which is required to be 
            /// of the form Y[year][moniker]
            /// </summary>
            /// <param name="identifier"></param>
            /// <returns></returns>
            public static Identifier parse(string identifier)
                => define(int.Parse(identifier[1..4]), identifier[5..(identifier.Length - 1)]);

            public Identifier(int year, string moniker)
            {
                this.year = year;
                this.moniker = moniker;
            }

            /// <summary>
            /// Specifies the year of publication
            /// </summary>
            /// <value></value>
            public int year {get;}

            /// <summary>
            /// Specifies an alphanumeric identifier that is sufficiently
            /// unique to identify the resource, relative to a given year,
            /// in the context of a bibliography
            /// </summary>
            /// <value></value>
            public string moniker {get;}

            public override string ToString() => $"Y{year}{moniker}";
        }

        public readonly struct Resource
        {
            public static Resource define(int year, string moniker, string title, string author)
                => new Resource(Identifier.define(year,moniker),title,author);

            public Resource(Identifier id, string title, string author)
            {
                this.id = id;
                this.author = author;
                this.title = title;
            } 


            public Identifier id {get;}

            public string author {get;}

            public string title {get;}
        }

        /// <summary>
        /// Applied to any code element any number of times to specify
        /// relevant citations
        /// </summary>
        public class CiteAttribute : Attribute
        {
            public CiteAttribute(string bibid, int location)
            {
                this.bibid = bibid;
                
                this.location = location;
            }

            /// <summary>
            /// The bibliographic resource identifier
            /// </summary>
            /// <value></value>
            public string bibid {get;}

            public int location {get;}
        }

        /// <summary>
        /// Records the usage of a bibliography entry
        /// </summary>
        public readonly struct Citation
        {
            /// <summary>
            /// Constructs a reference to a bibliographic resource
            /// </summary>
            /// <param name="resource"></param>
            /// <param name="location"></param>
            /// <returns></returns>
            public static Citation define(Resource resource, int location)
                => new Citation(resource, location);
            
            public Resource resource {get;}

            public int location { get;}

            public Citation(Resource resource, int location)
            {
                this.resource  = resource;
                this.location = location;
            }
        }
    }
}