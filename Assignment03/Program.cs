using System;
using System.Linq;

namespace Assignment03
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] ys = new int[] {
        2, 100, 4, 9, 74, 14 * 42, 7 * 42
      };
      int[] o = ys.Where(item => item % 7 == 0 && item > 42);
      Console.WriteLine(o);
    }
  }
}
