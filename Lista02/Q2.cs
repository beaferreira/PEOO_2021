using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            string nome = (a[0]);
            Console.WriteLine($"Bem vindo ao C#, {nome}");

            
        }
    }
}
