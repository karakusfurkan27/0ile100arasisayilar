internal class Program
{
    private static void Main(string[] args)
    {
        int sayi;
        Console.Write("Sayıyı Girin : ");
        sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi >= 0 && sayi <= 100)
        {
            Console.WriteLine("Girilen sayı 0-100 aralığında");
        }
        else
        {
            Console.WriteLine("Girilen sayı 0-100 aralığında değil");
        }
        Console.ReadKey();
    }

    
    
      
    }
