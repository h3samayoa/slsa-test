namespace Sample.Core;

public static class Main
{
  public static string ToFizzBuzzFormat(this int i)
  => i % 15 == 0 ? "Fizz Buzz"
  : i % 5 == 0 ? "Buzz"
  : i % 3 == 0? "Fizz"
  : i.ToString();
}