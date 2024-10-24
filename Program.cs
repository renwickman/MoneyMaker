using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();

      double totalAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{totalAsDouble} is equal to: ");

      double goldCoins = Math.Floor(totalAsDouble / 10);
      double remainder = totalAsDouble % 10;

      double silverCoins = Math.Floor(remainder / 5);
      remainder = totalAsDouble % 5;
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}
