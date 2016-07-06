using Xunit;
namespace Palindrome.Objects
{
  public class PalindromeTest
  {
    [Fact]
    public void IsPalindrome_NotPalindrome_False()
    {
      Word newWord = new Word ();
      Assert.Equal(false, newWord.IsPalindrome("charlie"));
    }
    [Fact]
    public void IsPalindrome_Palindrome_True()
    {
      Word newWord = new Word ();
      Assert.Equal(true, newWord.IsPalindrome("radar"));
    }
  }
}
