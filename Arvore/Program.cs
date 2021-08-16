using System;
using System.Linq;



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
            int[] myIntArray = new int[6] { 3, 2, 1, 6, 0, 5 };

            var maxValue = myIntArray.Max();
            int maxIndex = myIntArray.ToList().IndexOf(maxValue);
            // changing array to list to use linq

            var arrayList = myIntArray.ToList();
            var rightArray = arrayList.GetRange(0, maxIndex).ToArray();
            var leftArray  = arrayList.Skip(maxIndex+1).ToArray();

            for (int i = 0; i < myIntArray.Length; i++)
            {
                if (i==0)
                {
                    Console.Write("".PadRight(myIntArray.Length));
                    Console.WriteLine($"{maxValue}");
                }

                if (i < rightArray.Length)
                {
                    Console.Write("".PadRight(myIntArray.Length - i - 1));
                    Console.Write($"{rightArray[i]}");
                }

                if (i < leftArray.Length)
                {

                    Console.Write("".PadLeft(i + 1 + leftArray.ToList().IndexOf(leftArray[i])));
                    Console.Write($"{leftArray[i]}");

                }

                Console.WriteLine("");
            }

        }

        public static void print(int index,dynamic obj)
        {
     
        }  
        public static void spaceRight(int index,dynamic obj, int index2)
        {
            for (int i = 0; i < index2; i++)
            {
                Console.Write("".PadRight(index-i));
                Console.WriteLine($"{obj[i]}");
            }

        }

        public static void spaceLeft(int index, dynamic obj, int index2)
        {
            for (int i = 0; i < index2; i++)
            {
                Console.Write("".PadLeft(index + i));
                Console.WriteLine($"{obj[i]}");
            }

        }

    }
}
