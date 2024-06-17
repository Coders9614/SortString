using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine($"Oringal Characters {word1} + {word2}");
            string result = MergeAlternately(word1, word2);
            Console.WriteLine($"Output : {result}");  // Output: "apbqcr"
            /*	i (word1 index)	j (word2 index)	merged
            1	0	0	"a"
            1	1	1	"ap"
            2	1	1	"apb"
            2	2	2	"apbq"
            3	2	2	"apbqc"
            3	3	3	"apbqcr"
            Final	-	-	"apbqcr" */
            word1 = "ab";
            word2 = "pqrs";
            Console.WriteLine($"Oringal Characters {word1} + {word2}");
            result = MergeAlternately(word1, word2);
            Console.WriteLine($"Output : {result}");  // Output: "apbqrs"
            Console.ReadKey();
            /*i (word1 index)	j (word2 index)	merged
                        1   0   0   "a"
                        1   1   1   "ap"
                         2   1   1   "apb"
                      2   2   2   "apbq"
                     append  2   2   "apbqr"
                     append  2   3   "apbqrs"
            final - -"apbqrs"
            */
        }

        static string MergeAlternately(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;

            char[] merged = new char[len1 + len2];

            int position = 0, i = 0, j = 0;
            while (i < len1 && j < len2)
            {

                merged[position] = word1[i];
                position++;
                i++;
                merged[position] = word2[j];
                position++;
                j++;

            }

            // Append remaining characters from word1
            while (i < len1)
            {
                merged[position] = word1[i];
                position++;
                i++;

            }

            // Append remaining characters from word2
            while (j < len2)
            {
                merged[position] = word2[j];
                position++;
                j++;

            }

            return new string(merged);
        }
    }
}

