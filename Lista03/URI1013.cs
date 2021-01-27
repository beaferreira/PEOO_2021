using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        double a,b,c;
                        
        a = double.Parse(valor[0]);
        b = double.Parse(valor[1]);
        c = double.Parse(valor[2]);

        double ab = (a + b + Math.Abs (a -b))/2;
        double total = (ab + c + Math.Abs (ab - c)) / 2;
            
        Console.WriteLine($"{total} eh o maior");

    }

}
