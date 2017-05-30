using Xunit;

namespace AnagramApp.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void Compare_IfAnagram_true()
    {
      Anagram testAnagram = new Anagram("hello");
      Assert.Equal(true, testAnagram.Compare("elloh ahull"));
    }
  }
}
