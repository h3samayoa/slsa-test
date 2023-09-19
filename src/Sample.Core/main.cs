using System;
namespace Sample.Core;

public static class FizzBuzz
{
  public static string ToFizzBuzzFormat(int i)
  {
    if (i % 3 == 0 && i % 5 == 0) {
      Console.WriteLine("FizzBuzz")
    }
  }

  static void Main(string[] args) {
    ToFizzBuzzFormat(5);
  }


}