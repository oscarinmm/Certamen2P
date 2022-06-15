
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arreglo = new int[5];
            int numero = 0;

            Console.WriteLine("*****************");
            Console.WriteLine("   Bienvenido");
            Console.WriteLine("*****************");
            Console.WriteLine("*****************");
            Console.WriteLine("   Ejercicio 1");
            Console.WriteLine("*****************");
            Console.WriteLine();


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingresa un numero {0}:", i + 1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("El arreglo corresponde a:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese otro valor:");
            numero = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Valores mayores que " + numero);

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (numero < arreglo[i])
                {
                    
                    Console.WriteLine(arreglo[i]);
                }

            }



            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("****** Ejercicio 3 ******");
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            var random = new Random();
            
            int[] vector = new int[10];
            

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(50, 200);
            }
            ImprimeVector(vector);
            Console.WriteLine();
            Console.WriteLine("El numero mayor es:" + vector.Max());
            Console.WriteLine("El numero menor es:" + vector.Min());
            int a = Array.IndexOf(vector, vector.Max());
            Console.WriteLine("La posicion del mayor es:"+a);
            int b = Array.IndexOf(vector, vector.Min());
            Console.WriteLine("La posicion del menor es:"+b);



            static void ImprimeVector(int[] vector)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i] + " ");
                }
            }







           
            Console.ReadKey();
            
        }

    }

}