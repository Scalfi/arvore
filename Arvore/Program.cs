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
            Console.WriteLine($"Raiz:{maxValue}");

            // changing array to list to use linq

            var arrayList = array.ToList();
            var leftArray  = arrayList.GetRange(0, maxIndex).OrderByDescending(a => a).ToArray();
            var rightArray = arrayList.Skip(maxIndex + 1).OrderByDescending(a => a).ToArray();

            Console.WriteLine($"Galhos da esquerda:{string.Join(",", leftArray)}");
            Console.WriteLine($"Galhos da direita:{string.Join(",", rightArray)}");
            Console.WriteLine("");



            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("".PadRight(array.Length));
                    Console.WriteLine($"{maxValue}");
                }

                if (i < leftArray.Length)
                {
                    Console.Write("".PadRight(array.Length - i - 1));
                    Console.Write($"/");

                }

                if (i < rightArray.Length)
                {
                    if (i < leftArray.Length)
                    {
                        Console.Write("".PadLeft(i + 1 + rightArray.ToList().IndexOf(rightArray[i])));
                        Console.Write($"\\");

                    }
                    else
                    {
                        Console.Write("".PadRight(array.Length - i));
                        Console.Write("".PadLeft(i + 1 + rightArray.ToList().IndexOf(rightArray[i])));
                        Console.Write($"\\");
                    }

                }

                Console.WriteLine("");


                if (i < leftArray.Length)
                {
                    Console.Write("".PadRight(array.Length - i - 2));
                    Console.Write($"{leftArray[i]}");

                }

                if (i < rightArray.Length)
                {
                    if( i < leftArray.Length)
                    {
                        Console.Write("".PadLeft(i + 2 + rightArray.ToList().IndexOf(rightArray[i])));
                        Console.Write($"{rightArray[i]}");

                    } else
                    {
                        Console.Write("".PadRight(array.Length - i));
                        Console.Write("".PadLeft(i + 2 + rightArray.ToList().IndexOf(rightArray[i])));
                        Console.Write($"{rightArray[i]}");
                    }
                   
                }

                Console.WriteLine("");
            }
        }
 
    }
}
