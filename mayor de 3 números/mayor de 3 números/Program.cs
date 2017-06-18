using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_de_3_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("INGRESE LOS VALORES:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a==b && b==c && c==a)
            {
                Console.WriteLine("LOS VALORES SON IGUALES.");
                
            }
            else 
                if (a>b && a>c )
                {
                    Console.WriteLine("A ES MAYOR:  " + a);
                }
                else 
                    if(b>a && b>c)
                    {
                        Console.WriteLine("B ES MAYOR:  " + b);
                    }
                    else 
                        if (c>a && c>b)
                        {
                            Console.WriteLine("C ES MAYOR:  " + c);
                        }
            Console.ReadKey();
           
        }

    }
}
