using System;

namespace md01_CadernoExercicios_05
{
    class Program
    {
        static void Main(string[] args)

        /*
           5. Faça um algoritmo que leia uma temperatura em Fahrenheit e a apresente convertida em graus
           Celsius. A fórmula de conversão é C = (F – 32) * ( 5 / 9), na
           qual F é a temperatura em Fahrenheit e C é a temperatura em Celcius.
        */
        {
            double c, f, i = 0.5556;
           
            Console.WriteLine("Digite a Temperatura em Fahrenheit para conversão em Celsius");
            f = Convert.ToDouble(Console.ReadLine());
            c = (f - 32) * i;
            Console.WriteLine("Temperatura convertida em celsius: {0}", c.ToString("0.0") + "°C");


        }
    }
}
