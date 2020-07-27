using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w zabawie o tajemniczej nazwie 'FizzBuzz'!\nPodaj dowolną liczbę całkowtitą i zobacz co zrobi program: ");

            try
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                    throw new Exception("\nNie podałeś liczby całkowitej!");

                var fizzBuzz = new FizzBuzz();

                var result = fizzBuzz.DoFizzBuzz(userNumber);

                Console.WriteLine("\nWynik zabawy w 'FizzBuzz' to: ");
                Console.WriteLine(result);
            }

            catch (Exception ex)
            {
                //Logowanie do pliku
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("\nDziękuję za udział w zabawie.\nNaciśnij dowolny klawisz, aby zakończyć program i wyjść.");
                Console.ReadKey();
            }
        }
    }
}
