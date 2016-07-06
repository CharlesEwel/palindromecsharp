using Nancy;
using System;
using Palindrome.Objects;
using System.Collections.Generic;

namespace Palindrome
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/palindrome_result"] = _ => {
        Word newWord = new Word ();
        string IsIt="";
        if (!newWord.IsPalindrome(Request.Form["word-input"]))
        {
          IsIt="not ";
        }
        return View["index.cshtml", "Your word is "+IsIt+"a palindrome"];
      };
    }
  }
}
