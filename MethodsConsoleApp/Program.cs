using System;
using System.Linq;

namespace WordsArray
{
    internal class Program
    {
        /// <summary>
        /// Преобразует текст в массив слов при помощи цикла
        /// </summary>
        /// <param name="Text">Исхордный текст</param>
        /// <returns>Массив из слов исходного текста</returns>
        private static string[] ArrayFromText (string text)
        {
            string[] result;
            int wordCount = 1;
            string currentWord = "";
            int currentPos = 0;
            
            foreach (char c in text)
            {
                if(c == ' ')
                {
                    wordCount++;
                }
            }
            result = new string[wordCount];

            for (int i = 0; i < text.Length; i++) { 
                if (text[i] != ' ')
                {
                    currentWord += text[i];
                    if (i != text.Length - 1) 
                    {
                        continue;
                    }
                    
                }                
                result[currentPos] = currentWord;
                currentPos++;
                currentWord = "";
                
            } 
            return result;
        }

        /// <summary>
        /// Преобразует текст в массив слов при помощи метода Split
        /// </summary>
        /// <param name="text">Исхордный текст</param>
        /// <returns>Массив из слов исходного текста</returns>
        private static string[] ArrayFromTextSplit (string text)
        {
            return text.Split(' ');
        }

        /// <summary>
        /// Выводит массив слов на экран построчно
        /// </summary>
        /// <param name="array">Массив для вывода</param>
        private static void PrintStringArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }

        
        static void Main(string[] args)
        {
            string userText;

            Console.WriteLine("Введите текст");
            userText = Console.ReadLine();
            Console.WriteLine();

            // Решение с помощью цикла
            Console.WriteLine("Решение с помощью цикла:");
            PrintStringArray(ArrayFromText(userText));

            Console.WriteLine();

            // Решение с помощью Split
            Console.WriteLine("Решение с помощью split:");
            PrintStringArray(ArrayFromTextSplit(userText));

            Console.ReadKey();
        }
    }
}
