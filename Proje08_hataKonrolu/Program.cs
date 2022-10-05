namespace Proje08_hataKonrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            try
            {
                // try catch komutu normalde çalışmasını isediğimiz kodları yazarız.
                // try blogunda herhani bir hata var mı yok mu kontrol edilir.
                //hata varsa catch komutna gider
                Console.Write("1.sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.sayıyı giriniz: ");
               int sayi2 = Convert.ToInt32(Console.ReadLine());
               int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);

            }
            catch (DivideByZeroException ex) // exception hatanın sebebini verir bir tip olarak düşünebilirsin
            {

               Console.WriteLine("0'a bölünme hatası var");
               // Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("haddnden fazla büyük sayı girdiniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu");
            }
           
            finally
            {
                // try yada catch bloklarımızdan hangisi çalışırsa çalışsın, herhalükarda çalışmasını
                // istediğimiz kodları buraya yazarız.
                Console.WriteLine("program sona ermiştir");
            }











        }
    }
}