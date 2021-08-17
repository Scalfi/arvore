using System;
using System.Linq;
using System.Threading.Tasks;



//Dado um array inteiro sem duplicidade, construa um algoritmo de uma árvore a partir das
//seguintes regras:
//A raiz da árvore deve ser o maior valor do array
//Os galhos da esquerda devem ser compostos somente por números à esquerda do valor raiz,
//na ordem decrescente
//Os galhos da direita devem ser compostos somente por número à direita do valor raiz,
//na ordem decrescente




namespace Arvore
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array1 = new int[6] { 3, 2, 1, 6, 0, 5 };
            int[] array2 = new int[7] { 7, 5, 13, 9, 1, 6, 4 };

            printArvoce(array1);

            Task.Delay(1000);
            printArvoce(array2);

        }

        public static void printArvoce(int[] array)
        {
            Console.WriteLine($"Array de entrada: [{string.Join(",", array)}]");

            var maxValue = array.Max();
            int maxIndex = array.ToList().IndexOf(maxValue);
            var length = array.Length;
            Console.WriteLine($"Raiz:{maxValue}");

            // changing array to list to use linq

            var arrayList = array.ToList();
            var leftArray  = arrayList.GetRange(0, maxIndex).OrderByDescending(a => a).ToArray();
            var rightArray = arrayList.Skip(maxIndex + 1).OrderByDescending(a => a).ToArray();

            Console.WriteLine($"Galhos da esquerda:{string.Join(",", leftArray)}");
            Console.WriteLine($"Galhos da direita:{string.Join(",", rightArray)}");
            Console.WriteLine("");

            var cursor = Console.GetCursorPosition();
            int l = length;
            int c = cursor.Top + 1;
            
            int l2 = length;
            int c2 = cursor.Top + 1;
            
            Console.SetCursorPosition(length, c );
            Console.WriteLine(maxValue);

            for (int i = 0; i < rightArray.Length; i++)
            {
                l++;
                c++;
                Console.SetCursorPosition(l, c);
                Console.WriteLine("\\");
               
                c++;
                l++;
                Console.SetCursorPosition(l, c );
                Console.WriteLine($"{rightArray[i]}");
            }

            for (int i = 0; i < leftArray.Length; i++)
            {
                l2--;
                c2++;
                Console.SetCursorPosition(l2, c2);
                Console.WriteLine("/");

                c2++;
                l2--;
                Console.SetCursorPosition(l2, c2);
                Console.WriteLine($"{leftArray[i]}");
            }

            Console.WriteLine($"");
        }

    }
}
