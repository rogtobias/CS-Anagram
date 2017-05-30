using System;
using System.Collections.Generic;

namespace AnagramApp.Objects
{
  public class Anagram
  {
    private string _singleWord;
    private List<string> _multipleWord;

    //Anagram Object
    public Anagram (string singleWord)
    {
      _singleWord = singleWord;
      _multipleWord = new List<string> {};
    }

    //Get and Set the users inputted words
    public string GetWord()
    {
      return _singleWord;
    }
    public void SetWord(string singleWord)
    {
      _singleWord = singleWord;
    }
    public List<string> GetAnagramList()
    {
      return _multipleWord;
    }

    //function to compare the user inputted words with their list of words
    public bool Compare(string multipleWord)
    {
      //split users inputted word list
      string[] multiWordSplit = multipleWord.Split(' ');

      //take each inputted word to compare to the users single word
      for (int i = 0; i < multiWordSplit.Length; i++)
      {
        int count = 0;
        string userWord = GetWord();
        //takes the user main word and the single word from the list and breaks them into character arrays for comparison
        char[] inputtedWord = userWord.ToCharArray();
        char[] inputtedList = multiWordSplit[i].ToCharArray();
        //sorts the two words to be compared
        Array.Sort(inputtedWord);
        Array.Sort(inputtedList);
        Console.WriteLine(userWord);
        Console.WriteLine(inputtedWord);
        Console.WriteLine(inputtedList);
        //compares the length of the 2 words
        if (inputtedWord.Length == inputtedList.Length)
        {
          //steps through the 2 words to identify the letters
          for (int j = 0; j < inputtedWord.Length; j++)
          {
            if (inputtedWord[j] == inputtedList[j])
            {
              count +=1;
              Console.WriteLine(count);
            }
          }
        }
        else
        {
          break;
        }

        if (count == inputtedWord.Length)
        {
          //the word is added back to an array to be outputted
          _multipleWord.Add(multiWordSplit[i]);
        }
      }

      Console.WriteLine(multipleWord);
      return true;
    }
  }
}
