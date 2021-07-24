using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManClasses
{
    public class Board
    {
        public string WordToGuess { get; }
        public string WordCategory { get; }
        public int NumberOfUserIncorrectGuess { get; set; }
        public List<char> LettersGuessed { get; }
        private HangmanArt TheMan { get; }
        
        public Board()
        {
            LettersGuessed = new List<char>();
            TheMan = new HangmanArt();
        }

        public Board(string word, string wordCategory)
        {
            WordToGuess = word;
            WordCategory = wordCategory;
            //Initializes an empty list of characters so that when we call Board.LettersGuessed it doesn't return null.
            LettersGuessed = new List<char>();
            TheMan = new HangmanArt();
        }

        public string GetWordWithUserGuesses()
        {
            string currentWord = "";
            foreach(char letter in WordToGuess)
            {
                if(letter == ' ')
                {
                    currentWord += " ";
                    //currentWord = currentWord + " ";
                }
                else if (LettersGuessed.Contains(letter))
                {
                    currentWord += letter;
                }
                else
                {
                    currentWord += " _ ";
                }
            }
            return currentWord;
        }

        public bool WordIsComplete()
        {
            string currentWordAsUserHasGuessed = GetWordWithUserGuesses();
            if (currentWordAsUserHasGuessed == WordToGuess)
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }

        public string GetCurrentHangmanArt()
        {
            switch(NumberOfUserIncorrectGuess)
            {
                case 1:
                    return TheMan.Head;
                case 2:
                    return TheMan.Body;
                case 3:
                    return TheMan.LeftArm;
                case 4:
                    return TheMan.RightArm;
                case 5:
                    return TheMan.LeftLeg;
                case 6:
                    return TheMan.RightLeg;
                default:
                    return TheMan.EmptyNoose;
            }
        }

    }
}
