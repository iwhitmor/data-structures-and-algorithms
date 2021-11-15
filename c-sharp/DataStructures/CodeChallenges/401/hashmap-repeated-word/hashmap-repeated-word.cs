using System;
using System.Collections.Generic;

namespace CodeChallenges.hashmaprepeatedword
{
  public class hashmap_repeated_word
  {
    public static string RepeatedWord(string word)
    {
      HashSet<string> hashSet = new HashSet<string>();

      for (int i = 0; i < word.Length; i++)
      {
        if (hashSet.Contains(word))
          return word;

        else
          hashSet.Add(word);
      }
      return word;
    }
  }
}
