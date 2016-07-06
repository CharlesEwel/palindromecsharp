using Nancy;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome.Objects
{
  public class Input
  {
    public bool IsPalindrome(string potentialPalindrome)
    {
      bool matches = true;
      char[] letters = potentialPalindrome.ToLower().ToCharArray();
      for (int i=0; i<letters.Length; i++)
      {
        if (letters[i]!=letters[letters.Length-(1+i)])
        {
          matches=false;
        }
      }
      return matches;
    }
  }
}
