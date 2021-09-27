using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment03
{
  public static class Extensions
  {
    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) {
      return items.SelectMany(x => x.ToList());
    }

    public static IEnumerable<int> DivisibleBySeven(this IEnumerable<int> numbers) {
      return numbers.Where(x => (x % 7 == 0 && x > 42));
    }

    public static IEnumerable<int> LeapYears(this IEnumerable<int> years) {
      return years.Where(year => (year >= 1582) && (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0));
    }
  }
}
