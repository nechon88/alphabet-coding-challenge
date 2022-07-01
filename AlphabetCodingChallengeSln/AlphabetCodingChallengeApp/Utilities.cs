using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCodingChallengeApp
{
    public static class AlphabetUtility
    {
        // All letters in the english alphabet
        private static readonly string _alphabetCharacters = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Validate user input for the the AlphabetUtility.Parse() function.
        /// </summary>
        /// <param name="userInput">User input to validate</param>
        /// <param name="error">Description of validation error</param>
        /// <returns>True if valid, false if invalid</returns>
        public static bool ValidateInput(string userInput, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(userInput))
                error = "Input was empty.";
            else if (userInput.Length > 256)
                error = "Input is too long.";
            return string.IsNullOrWhiteSpace(error);
        }

        /// <summary>
        /// Accepts a string of up to 256 characters, and returns a string of 
        /// letters in the english alphabet that were not present in the input 's'
        /// </summary>
        /// <param name="s">input to parse</param>
        /// <returns>string of english letters</returns>
        public static string Parse(string s)
        {
            // process only a lowercase string
            string lower = s.ToLower();
            
            // create hashset of characters we see in the input
            HashSet<char> chars = new HashSet<char>();
            foreach (char c in lower)
                if (char.IsLetter(c) && !chars.Contains(c))
                    chars.Add(c);

            // build a string of alphabetic characters not present in our hashset
            StringBuilder ret = new StringBuilder();
            foreach (char c in _alphabetCharacters)
                if (!chars.Contains(c))
                    ret.Append(c);

            return ret.ToString();
        }
    }

}
