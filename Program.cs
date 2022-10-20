using System;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz ve ardından çıkarmak istediğiniz karakterin indeksini giriniz(Aralarında virgül kullanınız):");
            string word = Console.ReadLine();

            string[] word1 = word.Split(","); 
            string kelime = word1[0];
            int çevirme = Convert.ToInt32(word1[1]); 
            string sonHal = kelime.Remove(çevirme, 1); 

            Console.WriteLine(sonHal);
        }
    }
}
