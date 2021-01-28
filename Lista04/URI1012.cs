string[] valor = Console.ReadLine().Split(' ');
            double a,b,c;
            double pi = 3.14159;

            a = double.Parse(valor[0]);
            b = double.Parse(valor[1]);
            c = double.Parse(valor[2]);

            double triangulo = (a * c) / 2 ;
            double circulo = (Math.Pow(c, 2)) * (pi);
            double trapezio = ((a+b) * c) / 2;
            double quadrado = Math.Pow(b,2);
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo:.000}");
            Console.WriteLine($"CIRCULO: {circulo:.000}");
            Console.WriteLine($"TRAPEZIO: {trapezio:.000}");
            Console.WriteLine($"QUADRADO: {quadrado:.000}");
            Console.WriteLine($"RETANGULO: {retangulo:.000}");
