using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptogramGenerator
{
    public class Cryptogram
    {
        public Cryptogram(string inputFilePath, string outupFilePath)
        {
            InputFilePath = inputFilePath;
            OutupFilePath = outupFilePath;
            InputStr = File.ReadAllText(inputFilePath);
            OutputStr = new string (TransformAlphabet());
            File.WriteAllText(outupFilePath, OutputStr);
        }

        public static string InputStr { get; set; }
        public static string OutputStr { get; set; }
        public static string InputFilePath { get; set; }
        public static string OutupFilePath { get; set; }
        public static char[] RussianAlphabet = new char[]
        { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public static char[] TransformedAlphabet;
        public static char[] TransformAlphabet ()
        {
            TransformedAlphabet = new char[RussianAlphabet.Length];
            RussianAlphabet.CopyTo(TransformedAlphabet, 0);
            Shuffle(TransformedAlphabet);
            char[] output;
            output = new char[InputStr.Length];
            for (int i = 0; i < InputStr.Length; ++i)
            {
                int index = Array.IndexOf(RussianAlphabet, InputStr[i]);
                if (index == -1)
                {
                    output[i] = InputStr[i];
                    continue;
                }
                output[i] = TransformedAlphabet[index];
            }
            return output;
        }
        public static T[] Shuffle<T>(T[] arr)
        {
            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
            return arr;
        }

    }
}
