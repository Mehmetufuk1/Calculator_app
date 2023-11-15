namespace Calculator_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Basit Bir C# hesap makinesi");
            Console.WriteLine("işlem seçiniz [+],[-],[/],[*]");
            string islem = (Console.ReadLine());
        yeniIslem:
            try
            {
                Console.WriteLine("Birinci Sayıyı giriniz");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı Giriniz");
                sayi2 = int.Parse(Console.ReadLine());
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
                goto yeniIslem;
            }


            if (sayi2 != 0)

            {

                switch (islem)
                {
                    case "+":
                        Console.WriteLine("Toplama" + (sayi1 + sayi2));
                        break;
                    case "-":
                        Console.WriteLine("çıkarma: " + (sayi1 - sayi2));
                        break;
                    case "/":
                        Console.WriteLine("Bölme İşlemi: " + (sayi1 / sayi2));
                        break;
                    case "":
                        Console.WriteLine("Çarpma İşlemi " + (sayi1 * sayi2));
                        break;
                    default:
                        Console.WriteLine("işlem yapılamadı yanlış işlem yaptınız ");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Hatalı Giriş yaptınız");
                goto yeniIslem;
            }

        }
    }
}