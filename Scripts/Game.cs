using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan.Scripts
{
    public class Game
    {

        public int score = 0;
        public int tries = 6;


        public List<KeyValuePair<char, bool>> discoveredLetters = new List<KeyValuePair<char, bool>>();
        public List<char> usedLetters = new List<char>();

        // You may modify the path to the list of words here
        //private readonly string wordsPath = Helper.App.GetApplicationPath() + "//Data//words.txt";
        private readonly string wordsPath = Application.StartupPath + "//Data//words.txt";
        private string word = "";


        public void AddScore(int amount) { this.score += amount; }


        public void Initiate()
        {
            tries = 6;
            word = GetNewWord();

            discoveredLetters.Clear();
            foreach(char c in word)
            {
                discoveredLetters.Add(new KeyValuePair<char, bool>(c, false));
            }

            usedLetters = new List<char>();
        }

        public string GetWord() { return word; }

        public bool GuessLetter(string letter)
        {
            AddLetterToQueue(char.Parse(letter));
            bool letterFound = false;

            foreach (var c in discoveredLetters.ToList())
            {
                if (c.Key.ToString().ToLower().Equals(letter.ToLower()))
                {
                    int index = discoveredLetters.IndexOf(c);
                    discoveredLetters[index] = new KeyValuePair<char, bool>(c.Key, true);

                    letterFound = true;
                }
            }

            if (!letterFound)
                tries--;

            return letterFound;
        }

        private void AddLetterToQueue(char letter)
        {
            if(!usedLetters.Contains(letter))
                usedLetters.Add(letter);
        }


        private string GetNewWord()
        {  
            return Helper.Files.Reader.GetStringRandLine(wordsPath);
        }


    }
}
