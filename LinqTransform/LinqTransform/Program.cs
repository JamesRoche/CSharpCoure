using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<PErson>();
            people.Add(new PErson() { Name = "John", Age = 21, Online = false });
            people.Add(new PErson() { Name = "Jim", Age = 22, Online = false });
            people.Add(new PErson() { Name = "Steve", Age = 25, Online = true });

            var tranformedtoString = people.Select(s => s.Name).ToList();
            var averageAge = people.Select(s => s.Age).Sum() / people.Count;
            var anonList = people.Select(s => new { Summary = s.Name + ":" + s.Age }).ToList();

            anonList.First().Summary;
        }

        public class PErson
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Online { get; set; }
        }
    }
}
