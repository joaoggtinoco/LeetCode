using LeetCode.Easy;

namespace LeetCode
{
  internal class Program
  {
    static void Main(string[] args)
    {
      args = new string[3];
      args[0] = "DCXXI";
      args[1] = "LVIII";
      args[2] = "MCMXCIV";

      foreach (string arg in args)
      {
        RomantoInteger_13.RomanToInt(arg);
      }
    }


  }
}
