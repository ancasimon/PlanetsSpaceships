using System;
using System.Collections.Generic;

namespace PlanetsSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanetsList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanetsList);

            Console.WriteLine($"Planets in our solar system while list still in progress: {string.Join(",", planetList)}.");

            planetList.Insert(1, "Earth");
            Console.WriteLine($"Planets in our solar system while list still in progress / after Earth was added: {string.Join(",", planetList)}.");

            planetList.Insert(1, "Venus");
            Console.WriteLine($"Planets in our solar system: {string.Join(",", planetList)}.");

            planetList.Add("Pluto");
            Console.WriteLine($"Planets in our solar system - with Pluto too: {string.Join(",", planetList)}.");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"The four rocky planets are: {string.Join(",", rockyPlanets)}.");

            planetList.Remove("Pluto");
            Console.WriteLine($"Our solar system planet list for real - no more joking about any dwarf planets formerly knowns as planets: {string.Join(",", planetList)}.");








        }
    }
}
