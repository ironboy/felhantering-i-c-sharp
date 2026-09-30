Console.Write("Ange namnet på filen du vill läsa in: ");
string? fileName = Console.ReadLine();

// Declare text outside try and catch-blocks
// so that text has a scope where is available
// after running the try-catch clause
string text;

// When do you use try?
// When you realize that certain code can throw an exception
// "crash the program" - one typical case: in/out operations:
// read/write to files, databases etc

// Put code you know can give us run time errrors ("exceptions")
// inside a try program block
try
{
  text = File.ReadAllText(fileName!);
}
// If you want to notify the user about the actual technical
// fault or do something else when things go wrong - put that
// code inside a catch program block
// notice the code in the catch block will only run 
// if the code in the try block fails i.e. "casts an exception"
catch (Exception exception)
{
  text = "Kunde inte hitta filen!";
  Console.WriteLine("Följande fel uppstod: " + exception.Message);
}

Console.WriteLine(text);