using System;

namespace helloworld
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool sair = false;
            while(!sair)
            {
                double a, b, c, xpos, xneg, delta, resultado1, resultado2;
                string menu; 
                Console.WriteLine("Insira o valor de A:");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor de B:"); 
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor de C:");
                c = float.Parse(Console.ReadLine());
                delta = (Math.Pow(b,2) - (4 * a * c));
                Console.WriteLine("O valor de delta é:");
                Console.WriteLine(delta);
                if (delta < 0)
                {
                    Console.WriteLine("Numero não adequado a equação");
                    Console.WriteLine("Deseja sair? Digite 's' para sim ou 'n' para não");
                    menu = (Console.ReadLine());
                    if (menu == "s"){
                    sair = true;
                    }

                    if (menu == "n"){
                        sair = false;
                    }
                    
                                    
                }
                else if (delta >= 0)
                {
                    Console.WriteLine("Agora calculando o valor de X positivo");
                    xpos = (-b + Math.Sqrt(delta)) / (2*a);
                    Console.WriteLine(xpos);
                    Console.WriteLine("Agora calculando o valor de X negativo");
                    xneg = (-b - Math.Sqrt(delta)) / (2*a);
                    Console.WriteLine(xneg);
                    Console.WriteLine("Agora calculando as funções:");
                    resultado1 = a * (Math.Pow(xneg,2)) + (b * xneg) + c;
                    Console.WriteLine(resultado1);
                    resultado2 = a * (Math.Pow(xpos,2)) + (b * xpos) + c;
                    Console.WriteLine(resultado2);

                    Console.WriteLine("Deseja sair? Digite 's' para sim ou 'n' para não");
                    menu = (Console.ReadLine());
                    if (menu == "s"){
                        sair = true;
                    }

                    if (menu == "n"){
                        sair = false;
                    }
                    
                }
            }
                    
        }

    }
}

