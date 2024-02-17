using System;

class Program {
  public static void Main (string[] args) {
  string text = "";

    while (text != "exit"){
      Console.WriteLine("Enter text: ");
      text = Console.ReadLine();
      Console.WriteLine("You entered: " + text + ",");
    }
    Console.WriteLine("Closing program...");
  }
}