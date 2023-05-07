using System;


namespace ReverseText
{
    internal class Program
    {

        /// <summary>
        /// Преобразует текст в массив слов при помощи метода Split
        /// </summary>
        /// <param name="text">Исхордный текст</param>
        /// <returns>Массив из слов исходного текста</returns>
        private static string[] ArrayFromTextSplit(string text)
        {
            return text.Split(' ');
        }

        /// <summary>
        /// Возвращает слова текста задом наперед
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Слова текста задом наперед</returns>
        private static string ReverseText(string text)
        {
            string result = "";
            string[] array = ArrayFromTextSplit(text);

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] + " ";
            }
            return result;
        }

        static void Main(string[] args)
        {
            string userText;

            Console.WriteLine("Введите текст");
            userText = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(ReverseText(userText));
            Console.ReadKey();
        }
    }
}
