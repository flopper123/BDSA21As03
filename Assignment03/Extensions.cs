using System;
using System.Collections.Generic;

namespace Assignment03
{
  public static class Extensions
  {


    // Array.ForEach(xs, inner => foreach (var item in inner) { yield return item; });

    // 


    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) {

      // Error checking
      if (items == null) yield break;
      
      // Iterate through out loop
      foreach (IEnumerable<T> innerItems in items)
      {
        // Iterate through inner loop
        foreach (var item in innerItems) {
          // Return item
          yield return item;
        }
      }

      yield break;
    }
  }
}
