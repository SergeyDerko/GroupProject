//http://code.dblock.org/2009/02/18/nesting-multiple-configurationelement-types-in-a-configurationelementcollection.html

using System;
using System.Configuration;
using Common;

namespace AppConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            var section = Config.Instance.CollectionSection;
            Console.WriteLine("Nested configurations: {0}", section.Collection.Count);
            foreach (Proxy proxy in section.Collection)
            {
                Console.WriteLine("Type: {0}", proxy.Parent.GetType());
            }
        }
    }
}