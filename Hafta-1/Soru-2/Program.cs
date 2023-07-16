
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace hackerrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ?userinput = Console.ReadLine();

            if (userinput != null)
            {
                Dictionary<char, int> kvp = new Dictionary<char, int>();

                for (int i = 0; i < userinput.Length; i++)
                {
                    char c = userinput[i];
                    if (kvp.ContainsKey(c))
                    {
                        kvp[c]++;
                    }
                    else
                    {
                        kvp.Add(c, 1);
                    }
                }
                KeyValuePair<char, int> maxPair = new KeyValuePair<char, int>(char.MinValue,int.MinValue);


                foreach (KeyValuePair<char, int> kvp2 in kvp)
                {
                    if(kvp2.Value >  maxPair.Value)
                    {
                        maxPair = kvp2;
                    }
                }
                Console.WriteLine("Most repeated letter:");
                Console.WriteLine("Letter: " + maxPair.Key);
                Console.WriteLine("Value: " + maxPair.Value);


            }

                    }
    }
}








