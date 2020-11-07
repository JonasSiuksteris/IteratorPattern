using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Program
    {
        private static void Main()
        {
            var collection = new Collection(new List<object>{2,3,4,5,6});

            var iterator = collection.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            for (var item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine(item);
            }
        }
    }
}
