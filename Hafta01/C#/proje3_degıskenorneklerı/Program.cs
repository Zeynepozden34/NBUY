namespace proje3_degıskenorneklerı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  bir alt satıra geçmek için "/n"  kullanılır.
            // "$" işareti açıklamın yanına komut yazmadan değeri yazdırır.
            // tipleri dönüştürmek için to kullanılırız mesele int'isringe dönüştürmek için toSring deriz
            //int sayi1 = 120;
            //int sayi2 = 110;
            //Console.WriteLine(sayi1 + "/n" + sayi2);
           // Console.WriteLine($"SAYI1:  {sayi1}\nSAYI2: {sayi2}" );
            //Console.WriteLine(sayi1.ToString()+ sayi2.ToString());


            //string sayi3 = "120";
            //int sayi4 = 110;
            //Console.WriteLine(Convert.ToString(sayi3)+sayi4);


            double sayi1 = 0.1;
            double sayi2 = 0.7;
            double sayi3 = 0.8;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi1);
           
            Console.WriteLine(sayi1+sayi2);
            Console.WriteLine((sayi1 + sayi2) == sayi3);



        }
    }
}