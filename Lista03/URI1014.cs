using System;

class MainClass {
  public static void Main (string[] args) {
    int a = int.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double consumo = a/b;

    Console.WriteLine($"{consumo:.000} km/l");
  }
}
