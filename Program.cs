using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>()
            {
                 "Mercury", "Mars"
                  };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> newPlanets = new List<string>() {
                "Jupiter", "Saturn"
                    };

            planetList.AddRange(newPlanets);
            planetList.Insert(0, "Earth");
            planetList.Insert(5, "Venus");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");


            planetList.ForEach(i => Console.Write("{0}\t", i));

            // Console.WriteLine(planetList[1]);

        }
    }
}

