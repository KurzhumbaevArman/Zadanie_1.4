using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_z_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            int j;
            int a = 0;
           
            string words;
            Console.WriteLine("Введите предложение: ");
            words = Console.ReadLine();

            string[] slova = words.Split(new Char[] { ' ', ',', '.', ':', '\t','!','?','&','-',';' });
            int[] x = new int[slova.Length];
            foreach(string raz in slova)
            {
                x[i]=raz.Length;
                i++;
            }

            int min = x[0];
            foreach (int value in x)
            {
                if (value < min)
                    min = value;
            }
            for (j = 0; j < slova.Length; j++)
            {
                Console.WriteLine("Длина слова  \""+(slova[j])+"\" = "+(x[j]) );
                if (min == x[j]) a = j;
            }
            Console.WriteLine("\r\nСамое короткое слово :  \"" + (slova[a])+"\"");
            Console.WriteLine("Его длина составляет   " + (min) + "   символов");
            Console.WriteLine("Номер данного слова в предложении :" + (a+1));
            Console.ReadKey();
        }
    }
}
