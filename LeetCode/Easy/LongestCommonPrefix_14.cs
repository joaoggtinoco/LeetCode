using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
  internal class LongestCommonPrefix_14
  {
    public string LongestCommonPrefix(string[] strs)
    {
      string result = string.Empty;
      List<string> filteredStrs = [];
      FilterArray(strs, filteredStrs);
      filteredStrs.OrderBy(x => x.Length);

      foreach (string str in filteredStrs)
      {

      }


      return result;
    }

    private static void FilterArray(string[] strs, List<string> filteredStrs)
    {
      foreach (string str in strs)
      {
        if (str.Length <= 1)
          break;
        filteredStrs.Add(str);
      }
    }
  }
}
