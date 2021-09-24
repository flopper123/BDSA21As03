using System;
using System.Collections.Generic;

namespace Assignment03
{
  public static class Extensions
  {

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) {
      yield return T; 
    }
  }
}
