namespace proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <5; i++)
            //{

            //    Console.WriteLine($"{i+1} Hello, World!");

            //}
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    //toplam = toplam + i;
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            // 1 ile 10 arasındaki çft ayıların tılamını bulun
            //int toplam = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        toplam = toplam + i;
            //    }      
            //}
            //Console.WriteLine(toplam);




            //int toplam = 0;
            //for (int i = 0; i < 10; i=i+2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);


            int cifttoplam = 0;
            int tektoplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    tektoplam += i;
                }

                else
                {
                    cifttoplam += i;
                }






        }

    }
}