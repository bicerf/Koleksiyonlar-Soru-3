using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz:");
            string sentence = Console.ReadLine();

            char[] sesli= { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            Console.WriteLine(sentence.RemoveWhiteSpaces());

            char[] seslilerim = new char[sentence.Length];
           


            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (sentence[i]==sesli[j])
                    {
                        seslilerim[i] = sentence[i];
                    }
                }
            }
            seslilerim.ToString().RemoveWhiteSpaces();
            Console.WriteLine(seslilerim);
            
            //foreach (var harf in seslilerim)
            //{
            //    Console.WriteLine(harf);
            //}
 
            

        }

     
    }
    public static class MyExtensions
    {
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] sentence = param.Split(" ");
            return string.Join("", sentence);
        }
    }
  
  
}
