using System;

namespace ejercicios_forwhile_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int numero, max=0;
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un número:");
                numero = int.Parse(Console.ReadLine());
                
                if(x == 0) 
                max = numero;

                else if(numero > max)
                max = numero; 
            }

        
            Console.WriteLine("El numero mayor es:" + max);

        }
    }
}
