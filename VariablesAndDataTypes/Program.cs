namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişken Tanımlama Yapısı : (degisken_turu) (degisken adi) = (degeri);

            /*--------------- Sayısal Değişkenler --------------
             * Tam Sayı Değişkenler : byte, sbyte, short, ushort, int, uint, long, ulong
             * Ondalık Değişkenler : float, double, decimal
             * 
             * -------------- Metinsel Değişkenler -------------
             * Metinsel  : string
             * Karakter : char
             * -------------- Mantıksal Değişken ---------------
             * bool : sadece true ya da false değer tutar.
             * 
             * ----------------- DateTime -----------------------
             * Tarih ve saat işlemleri
             * 
             * ------------------- Object -----------------------
            */

            //s : signed u : unsigned

            byte b1 = 1; //8 bit = 1 byte
            sbyte b2 = -1; //8 bit = 1 byte
            short s1 = -654; //16 bit = 2 byte
            ushort s2 = 654; //16 bit = 2 byte
            int i1 = -1245654; //32 bit = 4 byte
            int i2 = 1245646; //32 bit = 4 byte
            long l1 = -15464546464464;
            ulong l2 = 123564563156465;

            float f = 5.0f; //32 bit = 4 byte
            double d = 5.0; //64 bit = 8 byte
            decimal d1 = 5.000m; //128bit = 16 byte

            string s = "patika"; //sınırsız
            char c = 'a'; //16 bit = 2 byte
            bool b = true; 

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime); // Sistem tarihi ve saatini yazar.

            //string ifadeler
            string str = string.Empty;
            str = "patika";
            string name = "patika";
            string surname = ".dev";
            string nameSurname = name + " " + surname;
            Console.WriteLine(nameSurname);

            //int ifadeler
            int number1 = 0;
            int number2 = 5;
            int result = number1 * number2;

            //mantıksal ifadeler
            bool isBig = number1 > number2;

            //Değişken dönüşümleri
            string str1 = "20";
            int int1 = 20;
            string newValue = str1 + int1.ToString();
            Console.WriteLine(newValue); //Çıktısı : 2020

            int int2 = int1 + Convert.ToInt32(str1);
            Console.WriteLine(int2); // çıktısı : 40
        }
    }
}