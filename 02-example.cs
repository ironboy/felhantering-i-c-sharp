// how do we know all Excpetion sub classes / types
// that a built in method like File.ReadAllText
// can throw - look at the Microsoft documentation
// https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-10.0#exceptions

try
{
  // This can throw an expection if the file does not exist:
  string text = File.ReadAllText("poang.txt");
  // This can throw an exception if we can't parse the text to integer
  int poang = int.Parse(text);
  // This will only run of no expection has be thrown
  Console.WriteLine($"Poäng: {poang}");
}
// If we specify subclasses to Exception only
// the catch that matches the the type of exception thrown will run
catch (FileNotFoundException /*exception*/)
{
  Console.WriteLine("Poängfilen saknas.");
  Console.WriteLine("Se till att filen ligger i projektets mapp på grundnivå och heter exakt poang.txt");
  // Console.WriteLine(exception.Message); // actual c# error
}
catch (FormatException /*exception*/)
{
  Console.WriteLine("Filen innehåller inte ett heltal.");
  Console.WriteLine("Kontrollera att filen bara innehåller sifffror, inga andra tecken");
  // Console.WriteLine(exception.Message); // actual c# error
}
// Always but the most generic Exception data type
// last in a series of catch blocks
catch (Exception exception)
{
  // Catch all other types of exceptions
  // that we might have failed to foresee
  Console.WriteLine(exception.GetType());
  Console.WriteLine(exception.Message);
}
// The code inside a finally program block
// will run regardless of if the catch program block threw an exception or not
// (i.e. regardless of if we run any code inside a catch program block)
finally
{
  Console.WriteLine("Nu var vi klara med att titta på poäng!");
}