/// Week 11		Lab 
/// File Name: Program.cs
/// @author: Antonio Monteiro

using System;
using System.Collections.Generic;

namespace Lecture_11_Lab {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> phonebook = new Dictionary<string, int>();
            AddNumber(phonebook, "A", 1234);
            AddNumber(phonebook, "B", 5678);
            AddNumber(phonebook, "C", 9101);

            foreach (KeyValuePair<string, int> e in phonebook) {
                Console.WriteLine("{0}: {1}", e.Key, e.Value);
            }

            Console.WriteLine("-----------------");

            DeleteNumber(phonebook, "B");

            foreach (KeyValuePair<string, int> e in phonebook) {
                Console.WriteLine("{0}: {1}", e.Key, e.Value);
            }

            Console.WriteLine("-----------------");

            FindNumber(phonebook, "C");

        }

        public static void AddNumber(Dictionary<string, int> phonebook, string person, int number) {

            phonebook.Add(person, number);

        }

        public static void DeleteNumber(Dictionary<string, int> phonebook, string key) {

            if (phonebook.ContainsKey(key)) {
                phonebook.Remove(key);
            }

        }

        public static void FindNumber(Dictionary<string, int> phonebook, string key) {

            if (phonebook.ContainsKey(key)) {
                Console.WriteLine(phonebook.GetValueOrDefault(key).ToString());
            }

        }

    }
}
