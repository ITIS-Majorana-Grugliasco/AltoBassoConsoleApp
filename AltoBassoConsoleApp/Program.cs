using System;

namespace AltoBassoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INDOVINA IL MUMERO");
            Console.WriteLine("Prova ad indovinare il numero che ho pensato, sarà compreso tra 0 e 9. Ad ogni tentativo ti dirò se ci hai azzeccato oppure se il tuo numero è troppo basso o troppo alto");
            Random generatoreNumeriCasuali = new Random();
            int numeroDaIndovinare = generatoreNumeriCasuali.Next(10);
            bool indovinato = false;
            while(indovinato == false)
            {
                Console.WriteLine("Scrivi il tuo numero:");
                int tentativo = int.Parse(Console.ReadLine());
                if (tentativo == numeroDaIndovinare)
                {
                    Console.WriteLine("CORRETTO, hai vinto!");
                    indovinato = true;
                }
                else if (tentativo > numeroDaIndovinare)
                {
                    Console.WriteLine("Il tuo numero è troppo alto");
                }
                else
                {
                    Console.WriteLine("Il tuo numero è troppo basso");
                }
            }
        }
    }
}
