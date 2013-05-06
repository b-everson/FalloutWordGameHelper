using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FalloutWordGameHelper
{
    class Words:System.Collections.CollectionBase
    {
        string guess1 = "";
        int guess1CorrectChars = -1;
        string guess2 = "";
        int guess2CorrectChars = -1;
        string guess3 = "";
        int guess3CorrectChars = -1;
        
        public void Add(string word)
        {
            List.Add(word);
        }

        public bool Contains(string word)
        {
            return List.Contains(word);
        }

        public string this[int index]
        {
            get { return (string)List[index]; }
            set { List[index] = value; }
        }

        int charsInCommon(int firstIndex, string other)           //overloaded method used to get string from index instead of value
        {
            string guess = (string)List[firstIndex];
            return charsInCommon(guess ,other);
        }

        int charsInCommon(string guess, string other)
        {
            int counter = 0;
            for(int index = 0; index < guess.Length; index++)       //loop through guess word         
                if (index < other.Length)
                    if (guess[index] == other[index])               //increment counter if character at index of other word is same as character from guess word
                        counter++;
            return counter;
        }

        void discardIncorrect(string guess, int correctChars)
        {
            string[] discardList = new string[List.Count];  //create list for strings to be discarded
            for (int i = 0; i < List.Count;i++)
            {
                string other = (string)List[i];
                if (charsInCommon(guess, other) < correctChars) //add words to list that don't have required amount of characters in common
                    discardList[i] = other;
            }
            foreach (string discard in discardList)
            {
                if (List.Contains(discard))
                {
                    List.Remove(discard);  //remove any of the words included in 
                }
            }
        }

        public void setGuess(string guess, int correctChars)
        {
            List.Remove(guess);  //remove guess from word list
            if (guess1 == "")
            {
                guess1 = guess;
                guess1CorrectChars = correctChars;

            }
            else if (guess2 == "")
            {
                guess2 = guess;
                guess2CorrectChars = correctChars;
            }
            else if (guess3 == "")
            {
                guess3 = guess;
                guess3CorrectChars = correctChars;
            }
            discardIncorrect(guess, correctChars); //discard any words with less than the given number of common characters
        }
    }
}
