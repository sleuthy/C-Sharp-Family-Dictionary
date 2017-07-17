using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

        myFamily.Add("wife", new Dictionary<string, string>(){ 
        {"name", "Cara"},
        {"age", "32"}
        });

        myFamily.Add("dog1", new Dictionary<string, string>(){ 
        {"name", "Sophie"},
        {"age", "6"}
        });

        myFamily.Add("dog2", new Dictionary<string, string>(){ 
        {"name", "Elliott"},
        {"age", "12"}
        });

        foreach (KeyValuePair <string, Dictionary<string, string>> person in myFamily){
            Console.WriteLine($"{person.Value["name"]} is {person.Value["age"]} and is my {person.Key}.");
        }
            
        }
    }
}
