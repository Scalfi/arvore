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
            string show = null;
            int[] myIntArray = new int[6] { 3, 2, 1, 6, 0, 5 };

            var maxValue = myIntArray.Max();
            int maxIndex = myIntArray.ToList().IndexOf(maxValue);
            show = $"   {maxValue}";
            // changing array to list to use linq

            var arrayList = myIntArray.ToList();
            var rightArray = arrayList.GetRange(0, maxIndex).ToArray();
            var leftArray  = arrayList.Skip(maxIndex+1).ToArray();

            print(maxIndex, show);

            spaceRight(maxIndex, rightArray, rightArray.Length);
            spaceLeft(maxIndex, leftArray, leftArray.Length);


        }

        public static void print(int index,dynamic obj)
        {
            Console.Write("".PadLeft(index));
            Console.WriteLine($"{obj}");
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
