using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Jessica" }, { "age", "48" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Thad" }, { "age", "43" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Gary" }, { "age", "71" } });
            myFamily.Add("grandpa", new Dictionary<string, string>() { { "name", "Wayne" }, { "age", "97" } });
            myFamily.Add("sister in law", new Dictionary<string, string>() { { "name", "Laura" }, { "age", "42" } });



            foreach (var (rel, definition) in myFamily)
            {
                var nameInfo = definition["name"];
                var ageInfo = definition["age"];
                Console.WriteLine($"{nameInfo} is my {rel} and is {ageInfo} years old");
            }
        }
    }
}
