using System;

class Program {
  public static void Main (string[] args) {


    Console.WriteLine("What is the temperture in Celsius:");
    var temp = Console.ReadLine();
    
    Console.WriteLine("Farenheit equivlent for"); 
    Console.WriteLine(temp);
    Console.WriteLine("degree celsius is");

    int x1 = Convert.ToInt32(temp);
    int x2 = Convert.ToInt32(9);
    int x3 = Convert.ToInt32(5);
    int x4 = Convert.ToInt32(32);
    
    Console.WriteLine(x1*9/5+32);

    int sum = (x1*9/5+32);

    if (sum > 100)
    {
      Console.WriteLine("This is above farenheit boiling temperture of 212");
    }
    if (sum == 100)
    {
      Console.WriteLine("temperture is equal to 100");
    }
    if (sum < 32)
    {
      Console.WriteLine("This is below the farenheit freezing temperture of 32");
    }

  }
}