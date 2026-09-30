static double CalculateDiscount(double price, double discountPercentage = 10)
{
  if (price < 0)
  {
    // Here we throw an exception
    // It can take some googling or AI help to find the most appropriate
    // existing exception type... but ArgumentOutOfRange seems like a good candidate here
    throw new ArgumentOutOfRangeException(nameof(price), "Priset får inte vara negativt.");
  }
  return price * discountPercentage / 100;
}

// We can catch exception that we throw in our own functions and methods too:
try
{
  Console.WriteLine($"10% rabatt på 100 kr: {CalculateDiscount(100)} kr.");
  // This line will throw an exception...
  Console.WriteLine($"10% rabatt på -50 kr: {CalculateDiscount(-50)} kr.");
  // ..which means that this line (after the exception in the same try clause)
  // will never run
  Console.WriteLine($"20% rabatt på 100 kr: {CalculateDiscount(100, 20)} kr.");
}
catch (Exception exception)
{
  Console.WriteLine("Tyvärr gick det inte att ge en av rabatterna.");
  Console.WriteLine(exception.Message);
}

