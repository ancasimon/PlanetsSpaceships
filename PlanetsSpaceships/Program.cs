using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine();

            Dictionary<string, List<string>> spacecraftList = new Dictionary<string, List<string>>
            {
                {
                    "Mariner 10",
                    new List<string>
                    {
                        "Mercury",
                        "Venus"
                    }
                },
                                {
                    "MESSENGER",
                    new List<string>
                    {
                        "Mercury",
                        "Venus"
                    }
                },
                {
                    "Mariner 2",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 4",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Mariner 5",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 5",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 6",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 7",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 8",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 9",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 10",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Pioneer Venus Orbiter",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Pioneer Venus Multiprobe",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 11",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 12",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 13",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 14",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 15",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Venera 16",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Vega 1",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Vega 2",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Galileo",
                    new List<string>
                    {
                        "Venus",
                        "Jupiter"
                    }
                },
                {
                    "Magellan",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Cassini",
                    new List<string>
                    {
                        "Venus",
                        "Jupiter",
                        "Saturn"
                    }
                },
                {
                    "IKAROS",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Mariner 4",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mariner 6",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mariner 7",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mariner 9",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars 2",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars 3",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars 5",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars 6",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars 7",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Viking 1",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Viking 2",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Phobos 2",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars Pathfinder",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Mars Global Surveyor",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Spirit",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Opportunity",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Rosetta",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Phoenix",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Dawn",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "WALL-E",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Eve",
                    new List<string>
                    {
                        "Mars"
                    }
                },
                {
                    "Pioneer 10",
                    new List<string>
                    {
                        "Jupiter"
                    }
                },
                {
                    "Pioneer 11",
                    new List<string>
                    {
                        "Jupiter",
                        "Saturn"
                    }
                },
                {
                    "Venus Express",
                    new List<string>
                    {
                        "Venus"
                    }
                },
                {
                    "Voyager 1",
                    new List<string>
                    {
                        "Jupiter",
                        "Saturn"
                    }
                 },
                 {
                    "Voyager 2",
                    new List<string>
                    {
                        "Jupiter",
                        "Saturn",
                        "Uranus",
                        "Neptune"
                    }
                 },
                 {
                    "Ulysses",
                    new List<string>
                    {
                        "Jupiter",
                    }
                }
            };

            //declare a new dictionary variable that will hold the data we ultimately need to print: a string for the planet name and a list of the probes sent there
            Dictionary<string, List<string>> visitingSpacecraftList = new Dictionary<string, List<string>>();

            foreach(var planet in planetList)
            {
                foreach(var (probeName, planets) in spacecraftList)
                {
                    //check if the planet we are on is included in the Dictionary of spacecrafts and planets they visited.
                    if (planets.Contains(planet))
                    {
                        //if the planet is included, then add a new item to the new Dictionary we just created that has the planet name as the key and that adds the probe name to the value list
                        visitingSpacecraftList.TryAdd(planet, new List<string> { probeName });
                        
                        //the planet key might already have been added to our dictionary, so - check if it already exists and if so, add the current probe name to the list of values for that planet key 
                        foreach (var (indivPlanet, probesList) in visitingSpacecraftList)
                        {
                            if (indivPlanet == planet)
                            {
                                probesList.Add(probeName);
                            }
                        }
                    }
                }
            }

            foreach (var (planet, visitingProbes) in visitingSpacecraftList)
            {
                Console.WriteLine($"{planet}: {string.Join(",", visitingProbes.Distinct())}");
            }

        }
    }
}
