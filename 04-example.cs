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

// We want to try several calls to a function/methods with different argument values
// and continue even if one of the calls fails
// ... so we can not put all the calls in the same try (see 03-example)
// but can create a wrapper function/method and call instead

static double? TryCalculateDiscount(double price, double discountPercentage = 10)
{
  try
  {
    return CalculateDiscount(price, discountPercentage);
  }
  catch (Exception exception)
  {
    Console.WriteLine("Tyvärr gick det inte att ge en av rabatterna.");
    Console.WriteLine(exception.Message);
  }
  return null;
}


Console.WriteLine($"10% rabatt på 100 kr: {TryCalculateDiscount(100)} kr.");
Console.WriteLine($"10% rabatt på -50 kr: {TryCalculateDiscount(-50)} kr.");
Console.WriteLine($"20% rabatt på 100 kr: {TryCalculateDiscount(100, 20)} kr.");