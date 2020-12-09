using System;
using System.Collections.Generic;

namespace Sieve.Models
{
  public class Prime
  {
    public List<int> numbers = new List<int> {};
    public void NumberCount(int userNum)
    {
      // int userNum = 5;
      for (int i = 1 ; i <= userNum; i++)
      {
        // Console.WriteLine(i);
        numbers.Add(i);
      }
    }
  }
}