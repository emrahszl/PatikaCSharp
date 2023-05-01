namespace Hw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------- 1. Ödev -------------------------
            #region 1. Ödev
            Console.Write("Girmek istediğiniz sayı adedi : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            //Girilen sayıları bir dizide tutuyoruz.
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Oluşturduğumuz dizideki elemanları gezerek çift olanları yazdırıyoruz.
            Console.Write("Girilen sayılardan çift olanlar : ");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + ", ");
                }
            }
            #endregion

            //-------------------- 2. Ödev -------------------------
            #region 2. Ödev
            Console.Write("Girmek istediğiniz sayı adedi : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Karşılaştırılacak sayıyı giriniz : ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            //Sayıları alıyoruz.
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Girilen sayılarla m'yi karşılaştırıp m'ye eşit veya bölünenleri yazdırıyoruz.
            Console.Write($"{m}'ye eşit veya tam bölünenler : ");
            foreach (int number in numbers)
            {
                if (number == m || number % m == 0)
                {
                    Console.Write(number + ", ");
                }
            }
            #endregion

            //-------------------- 3. Ödev -------------------------
            #region 3. Ödev
            Console.Write("Girmek istediğiniz kelime adedi : ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[n];

            //Girmek istenilen adet kadar kelime alınarak diziye ekliyoruz.
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{i + 1}. kelimeyi giriniz : ");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words); //Diziyi ters çeviriyoruz.

            //Sondan başa diziyi yazdırıyoruz.
            Console.WriteLine($"Sondan başa : {string.Join(",", words)}");
            #endregion

            //-------------------- 4. Ödev -------------------------
            int totalLetter = 0;

            Console.Write("Girmek istediğiniz cümle : ");
            string sentence = Console.ReadLine(); //Cümleyi aldık.

            //Cümleyi burada boşlukları yoksayacak şekilde kelimelere bölüp, her kelimeyi bir diziye atıyoruz.
            string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //Dizinin her kelimesini gezip kelime uzunluklarını topladığımızda toplam harf sayısını verecektir.
            foreach (string word in words)
            {
                totalLetter += word.Length;
            }

            Console.WriteLine($"Cümledeki toplam kelime sayısı : {words.Length}, Toplam harf sayısı : {totalLetter}");
        }
    }
}