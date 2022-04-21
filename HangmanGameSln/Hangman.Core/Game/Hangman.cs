﻿using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;
using HangmanRenderer.Renderer;


namespace Hangman.Core.Game
{
    // 1) Take a random word from a string array
    //  and store it into a string "WordToFind".

    //  2) Convert the "Word to find" string into a character array.
    //     

    //  3) The player provides the input letter (A, B, C.. etc.)

    //  4) When any input button is pressed, the letter is stored into a
    //  "CurrentInputLetter" string.

    //  5) Make another string "StringToDisplay" to display for
    //     the intermediate status.(For example: If the word is "APPLE",
    //      at some point the "StringToDisplay" could be "A_PL_")

    //   6) Iterate each character in the "WordToFind" string and check each letter
    //      in the "WordToFind" character array to determine whether any letter
    //      matches with "CurrentInputLetter".

    public class HangmanGame
    {

        private GallowsRenderer _renderer;
        private int index;
        private string _underscoreWords;
        private int lives = 6;
        private char[] _letterpositions;
        private string _guessWord;
        private string _guessProgress;
        private char[] Overwrite;

        public string ReturnUnderscore()
        {
            return _underscoreWords;
        }

        public HangmanGame()
        {
            // SecretWords (20+)

            string[] SecretWords = { " Harry Potter ", " Lord of the Rings ", "The Hobbit ", " Cat in the Hat ", " Sherlock Holmes ", "Narnia ",
                                     "Dirty Dancing ", " Troy", "God of War ", "Age of Empires", " Assasins Creed ", "Prince of Persia", "The Witcher ",
                                     "Rise ", "Pac-Man ", " Donkey Kong ", " Pokemon ", "Mario ", "Yu-gi-Oh ", };

            //This will randomize the secret word list

            index = new Random().Next(SecretWords.Length);
            _guessWord = SecretWords[index];

            //This changes the characters in the string to a dash

            for (int i = 0; i < _guessWord.Length; i++)
            {
                _underscoreWords += "-";
            }
            //Renders the gallows

            _renderer = new GallowsRenderer();

        }
        

        public void TheOverwrittenWord(char letterGuessed)
        {




        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
        }

    }
}
