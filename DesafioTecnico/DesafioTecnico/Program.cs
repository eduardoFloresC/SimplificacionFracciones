using System;

namespace DesafioTecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Líneas para probar la función.
            string numero;
            int algo;
            algo = 20 % 5;
            Console.WriteLine(algo);
            Console.WriteLine("Ingrese el nro con el formato: num1/num2");
            numero = Console.ReadLine();
            Console.WriteLine("El resultado es: "+simplificar(numero));
            */
        }
        public static string simplificar(string numero)//Función que devuelve una versión simplificada de una fracción 
        {
            string resultado = "";
            string[] subs = numero.Split('/');
            int numerador = int.Parse(subs[0]);
            int denominador = int.Parse(subs[1]);
            int numero_divisor=divisor(numerador, denominador);
            numerador = numerador / numero_divisor;
            denominador = denominador / numero_divisor;
            resultado = numerador.ToString() + "/" + denominador.ToString();
            return resultado;

            static int divisor(int num1, int num2)//obtiene el divisor común para el cálculo de la función "simplificar"
            {
                int r = 0;
                int a = Math.Max(num1, num2);
                int b = Math.Min(num1, num2);
                do
                {
                    r = b;
                    b = a % b;
                    a = r;
                }
                while (b != 0);
                return r;
            }
        }
        
        
    }
}
