using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyProgram
{
     class Program
    {
        static void Main(string[] agrs)
        {
            static MorseSet ParseMorseSet (string content) {
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvetion.Instance)
                    .Build();
                return deserializer.Deserialize<MorseSet>(contents);
            }
            
            
            int dot = 600;
            int line = 900;
           
            Console.Beep(1000, dot);
            Console.Beep(1000, line); // Beep after a code is running

        }
    }

    public class MorseSet{
        public List<Morse> Alphabet { get; set;}
    }

    public class Alphabet{

    }
}