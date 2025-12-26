using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    
    public class Person
    {
        [NonSerialized]
        public int sample;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterless constructor required for XML serialization
        public Person() { }

        public Person(int id, string name, int age, int sample)
        {
            Id = id;
            Name = name;
            Age = age;
            this.sample = sample;   
        }
    }

    public class Class1
    {
        public static void Main3()
        {
            Person person = new Person(1, "John Smith", 30,20);

            // ---------------- JSON SERIALIZATION ----------------
            string jsonFile = "person.json";
            string jsonString = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFile, jsonString);

            Console.WriteLine("JSON Serialized");

            Person jsonPerson = JsonSerializer.Deserialize<Person>(File.ReadAllText(jsonFile));
            Console.WriteLine("JSON Deserialized: " + jsonPerson.Name);

            // ---------------- XML SERIALIZATION ----------------
            string xmlFile = "person.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream(xmlFile, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, person);
            }

            Console.WriteLine("XML Serialized");

            Person xmlPerson;
            using (FileStream fs = new FileStream(xmlFile, FileMode.Open))
            {
                xmlPerson = (Person)xmlSerializer.Deserialize(fs);
            }

            Console.WriteLine("XML Deserialized: " + xmlPerson.Name);
        }
    }

}


