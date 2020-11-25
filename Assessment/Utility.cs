using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
   public class Utility
    {
        public string showRepeatedLetters(string input)
        {
            string output="";
            input = input.Replace(" ", "");
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in input.ToArray())
                if (!map.ContainsKey(c))
                    map.Add(c, 1);
                else
                    map[c] = map[c] + 1;
            foreach(KeyValuePair<char,int> entry in map)
            {
                if(entry.Value > 1)
                    output = output + entry.Key;
                
            }
            if (output == "")
                output = "No duplicate values were found";
  

            return output;
            
        }
        
        public int showNumberOfVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char vowel in vowels)
            {
                if (input.Contains(vowel))
                    map.Add(vowel, 1);
            }
  
               
            return map.Count;


        }

        public int showNonVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            List<char> vowelList = vowels.OfType<char>().ToList(); 

            StringBuilder sb = new StringBuilder(input);

            for (int i = 0; i < sb.Length; i++)
            {

                if (vowelList.Contains(sb[i]))
                {
                    sb.Replace(sb[i].ToString(), "");
                    i--;
                }
            }
            sb.Replace(" ", "");
            return sb.Length;

        }

        public string performFunction(string operation, string input)
        {
            String outputString = "";
            int vowels=0;
            if (operation.Contains("1"))
            {
                outputString = showRepeatedLetters(input);

            }
            if (operation.Contains("2"))
            {
                
                vowels = showNumberOfVowels(input);
                if (vowels > 0)
                {
                    outputString = outputString + "\n" +"The number of vowels is " + vowels;
                }
                else
                {
                    outputString = outputString + "\n"+ "No vowels were found";
                }

            }
            if (operation.Contains("3"))
            {
                int nonVowels = showNonVowels(input);
                if (vowels > nonVowels)
                {
                    outputString = outputString +"\n"+ "The text has more non vowels than vowels";

                }
                else if (vowels < nonVowels)
                {
                    outputString = outputString + "\n" + "The text has more non vowels than vowels";

                }
                else
                {
                    outputString = outputString + "\n" + "The text has an equal amount of vowels and non vowels";

                }
            }
            return outputString;
        }

    }
}
