using System;

class MainClass {
  public static void Main (string[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());

    double bonus = (vendas * (0.15));
    double total = (salario + bonus);
    Console.WriteLine($"TOTAL = R${total}");
  }
}
