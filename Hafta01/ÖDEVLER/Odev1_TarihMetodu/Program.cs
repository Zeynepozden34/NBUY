namespace Odev1_TarihMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime bugun = DateTime.Now;
            int day = bugun.Day + 2;
            int year= bugun.Year;
            DateTime sonuc = new DateTime(year, 1, day);
            Console.WriteLine(sonuc.ToLongDateString());

        }
    }
}