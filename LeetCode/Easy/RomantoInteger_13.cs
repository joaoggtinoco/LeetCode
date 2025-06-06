

namespace LeetCode.Easy
{
  internal class RomantoInteger_13
  {
    //I 1
    //V 5
    //X 10
    //L 50
    //C 100
    //D 500
    //M 1000
    public static int RomanToInt(string s)
    {
      int result = 0;

      bool isIV = false;
      bool isIX = false;
      bool isXL = false;
      bool isXC = false;
      bool isCD = false;
      bool isCM = false;
      for (int i = 0; i < s.Length; i++)
      {

        bool isLast = i == s.Length - 1;

        switch (s[i])
        {
          case 'I':
            if (!isLast)
            {
              isIV = s[i + 1] == 'V';
              if (isIV)
              {
                result += 4;
                break;
              }
              isIX = s[i + 1] == 'X';
              if (isIX)
              {
                result += 9;
                break;
              }
            }

            result++;
            break;
          case 'V':
            if (isIV)
              break;
            result += 5;
            break;
          case 'X':
            if (isIX)
              break;
            if (!isLast)
            {
              isXL = s[i + 1] == 'L';
              if (isXL)
              {
                result += 40;
                break;
              }
              isXC = s[i + 1] == 'C';
              if (isXC)
              {
                result += 90;
                break;
              }
            }
            result += 10;
            break;
          case 'L':
            if (isXL)
              break;
            result += 50;
            break;
          case 'C':
            if (isXC)
              break;

            if (!isLast)
            {
              isCD = s[i + 1] == 'D';
              if (isCD)
              {
                result += 400;
                break;
              }
              isCM = s[i + 1] == 'M';
              if (isCM)
              {
                result += 900;
                break;
              }
            }
            result += 100;
            break;
          case 'D':
            if (isCD)
              break;
            result += 500;
            break;
          case 'M':
            if (isCM)
              break;
            result += 1000;
            break;
          default:
            throw new ArgumentException("Invalid Roman numeral character");
        }
      }

      return result;
    }
  }
}
