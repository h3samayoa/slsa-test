namespace Sample.Core;

public static class FizzBuzz
{
  public static string ToFizzBuzzFormat(int i)
  {
    => i % 15 == 0 ? "Fizz Buzz"
    : i % 5 == 0 ? "Buzz"
    : i % 3 == 0? "Fizz"
    : i.ToString();
  }

  static void Main(string[] args) {
    ToFizzBuzzFormat(5);
  }


}