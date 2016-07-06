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
        Input newInput = new Input ();
        string IsIt="";
        if (!newInput.IsPalindrome(Request.Form["input"]))
        {
          IsIt="not ";
        }
        return View["index.cshtml", "Your word/number is "+IsIt+"a palindrome"];
      };
    }
  }
}
