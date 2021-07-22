using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            
            //turn a string object into an array of characters
            char[] charactersInString = myString.ToCharArray();


            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            foreach (char item in charactersInString)
            {
                //if item is not in charDictionary, add and count as value of 1
                if (!charDictionary.ContainsKey(item))
                {
                    charDictionary.Add(item, 1);
                }

                //if item is in charDictionary, add to the next value
                else
                {
                    charDictionary[item] += 1;
                }
            }

            //use foreach to loop through the charDictionary and print the key & value
            foreach (var kvp in charDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }



        }
    }
}

