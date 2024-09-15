using System;

class Program {
  static void Main ()
  {
    const double baseRate = 200.00;
    const double hourlyRate = 150.00;
    const double perMileRate = 2.00;
    Console.WriteLine("Enter the estimated number of hours: ");
    double hours = Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter the estimated number of miles: ");
    double miles = Convert.ToDouble(Console.ReadLine());
    double totalFee = baseRate + (hourlyRate * hours) + (perMileRate * miles);
  Console.WriteLine($"The total moving fee is: {totalFee:C2}");
  }
}