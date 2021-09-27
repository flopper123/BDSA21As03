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

    // public static IE
  }
}
