using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);


            string[] legendary = new string[]
            {
                "shards",
                "fragments",
                "motes"

            };
            bool isObtain = false;
            while (!isObtain)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < commands.Length; i += 2)
                {
                    int qty = int.Parse(commands[i]);
                    string name = commands[i + 1].ToLower();

                    if (legendary.Contains(name))
                    {

                        if (name == "shards")
                        {
                            if (keyMaterials.ContainsKey(name))
                            {
                                keyMaterials[name] += qty;
                            }

                            if (keyMaterials[name] >= 250)
                            {
                                keyMaterials[name] -= 250;
                                Console.WriteLine($"Shadowmourne obtained!");
                                isObtain = true;
                                break;
                            }
                        }
                        else if (name == "fragments")
                        {
                            if (keyMaterials.ContainsKey(name))
                            {
                                keyMaterials[name] += qty;
                            }

                            if (keyMaterials[name] >= 250)
                            {
                                keyMaterials[name] -= 250;
                                Console.WriteLine($"Valanyr obtained!");
                                isObtain = true;
                                break;
                            }



                        }
                        else if (name == "motes")
                        {
                            if (keyMaterials.ContainsKey(name))
                            {
                                keyMaterials[name] += qty;
                            }

                            if (keyMaterials[name] >= 250)
                            {
                                keyMaterials[name] -= 250;
                                Console.WriteLine($"Dragonwrath obtained!");
                                isObtain = true;
                                break;
                            }
                        }


                    }
                    else
                    {
                        if (!junk.ContainsKey(name))
                        {
                            junk.Add(name, 0);
                        }
                        junk[name] += qty;
                    }
                }
            }

            keyMaterials = keyMaterials.OrderByDescending(q => q.Value).ThenBy(m => m.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            junk = junk.OrderBy(k => k.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
