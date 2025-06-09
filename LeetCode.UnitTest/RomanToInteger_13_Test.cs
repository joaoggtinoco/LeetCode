namespace LeetCode.Easy
{
  [TestClass]
  public sealed class RomanToInteger_13_Test
  {
    [TestMethod]
    [DataRow("DCXXI", 621)]
    [DataRow("LVIII", 58)]
    [DataRow("MCMXCIV", 1994)]
    public void Test(string romanNumber, int expectedNumber)
    {
      int result = RomantoInteger_13.RomanToInt(romanNumber);
      Assert.AreEqual(expectedNumber, result);
    }
  }
}
