using Xunit;
namespace Palindrome.Objects
{
  public class PalindromeTest
  {
    [Fact]
    public void IsPalindrome_NotPalindrome_False()
    {
      Input newInput = new Input ();
      Assert.Equal(false, newInput.IsPalindrome("charlie"));
    }
    [Fact]
    public void IsPalindrome_Palindrome_True()
    {
      Input newInput = new Input ();
      Assert.Equal(true, newInput.IsPalindrome("radar"));
    }
    [Fact]
    public void IsPalindrome_IgnoreSpaces_True()
    {
      Input newInput = new Input ();
      Assert.Equal(true, newInput.IsPalindrome("taco cat"));
    }
  }
}
