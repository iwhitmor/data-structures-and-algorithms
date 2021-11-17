using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeChallenges.hashmaprepeatedword
{
  public class hashmap_repeated_word
  {
    public static string RepeatedWord(string words)
    {
      string[] wordList = Regex.Split(words, @"[^\w]+");

      var wordsSeen = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);

      foreach (var word in wordList)
      {
        if (wordsSeen.Contains(word))
          return word;

        wordsSeen.Add(word);
      }

      return null;
    }
  }
}
