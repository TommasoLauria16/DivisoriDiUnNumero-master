using System;

namespace Gestione
{
    public class Divisore
    {
        public static int LeggiNumero()
        {
            Console.Write("inserisci un numero intero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static void StampaDivisori(int n)
        {
            
            int i = 1,count=1;
            int max = n / 2;
            while (i <= max)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }

               i++;
            }
            Console.WriteLine(n);
            if (count== 2)
                Console.WriteLine("il numero è primo");
            else
                Console.WriteLine("il numero non è primo");

                
        }
    }
}
