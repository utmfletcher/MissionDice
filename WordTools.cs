using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionDice
{
    internal class WordTools
    {
        public int WordCounter(string words)
        {
            int wordCount = 0;
            string[] individualWords = words.Split(' ');
            wordCount = individualWords.Length;

            return(wordCount);
        }
      
        public int CharCounter(string words)
        {
            int charCount = 0;

            charCount = words.Length;

            return(charCount);
        }

        
        public void AlphabetCounter(string words)
        {
            int[] letters = new int[26];
            
            for (int i = 0; i < words.Length; i++) 
            {
                

                char c = words[i];

                c = Char.ToLower(c);

                if ( c >= 97 && c <= 122)
                {
                    letters[(c - 97)]++;
                }
            }

            //print results 
            for (int i = 0;i < letters.Length;i++) 
            {
                char letter = (char)(i + 97);
                 
                Console.WriteLine(letter + ":" + letters[i]);
            }

        }
        
    }
}
