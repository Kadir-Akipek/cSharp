/*staric methods doğrudan sınıf üzerindeki değerlere
ulaşmamızı sağlar. Örnek Math*/
using System;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args){
            Random rnd = new Random(); //instance method
            Console.WriteLine(rnd.Next(1,100));
            
            Math.Min(10,30); //static method

            var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlendirme");
            Console.WriteLine(sonuc);
        }
    }
    class HelperMethods {
        public static string KarakterDuzelt(string str) {
            return
                str.Replace("ö","o").
                Replace("ü","u").
                Replace("ı","i").
                Replace("ç","c").
                Replace(" ","-");
        }
    }
}



