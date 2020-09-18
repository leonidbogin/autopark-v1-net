using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class DictionaryDetails
    {
        private ConcurrentDictionary<string, int> dictionary;

        public DictionaryDetails()
        {
            dictionary = new ConcurrentDictionary<string, int>();
        }

        public void Add(string word)
        {
            if (!dictionary.TryAdd(word, 1)) 
            {
                dictionary[word]++;
            }
        }

        public void Print()
        {
            ICollection<string> keys = dictionary.Keys;
            foreach (string key in keys)
                Console.WriteLine($"{key} - {dictionary[key]}");
        }
    }
}
