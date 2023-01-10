namespace CryptogramGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cryptogram cryptogram = new Cryptogram(
                "C:\\Users\\Никита\\source\\repos\\CryptogramGenerator\\CryptogramGenerator\\bin\\Debug\\net7.0\\Input.txt",
                "C:\\Users\\Никита\\source\\repos\\CryptogramGenerator\\CryptogramGenerator\\bin\\Debug\\net7.0\\Output.txt");
            Console.ReadKey();
        }
    }
}