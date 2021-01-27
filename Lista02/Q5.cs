using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o intervalo de tempo no formato HH:MM:SS");
            string[] hora = Console.ReadLine().Split(':');
            double h, m, s;
            h = double.Parse(hora [0]) * 3600;
            m = double.Parse(hora [1]) * 60;
            s = double.Parse(hora [2]);          
            

            double conta = (h + m + s) * 300000;
            Console.WriteLine($"A luz percorreu {conta}km nesse intervalo");

        
            
     }
    }
}
