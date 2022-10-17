namespace proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen sayının 5 olursa 2 katını 10 olması halinde 3 katını yada 15 olması halinde 4 katını alıp olup olmadıpnı ekrana yazan program üü de değilse tanınmayan değer yazsın

            //Console.Write("bir sayı giriniz: ");
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //if (sayı == 5)
            //{
            //    sonuc = sayı * 2;

            //}
            //else if (sayı == 10)
            //{
            //        sonuc = sayı * 3;

            //    }
            //    else if (sayı==15)
            //    {
            //        sonuc = sayı * 4;

            //    }
            //    if (sonuc==0)
            //    {
            //        Console.WriteLine("girilen değer tanımsızdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(sonuc);
            //    }
            //}

            //Console.Write("bir sayı giriniz: ");
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;

            //switch (sayı)
            //{
            //    case 5:
            //        sonuc = sayı * 2;
            //        break;
            //    case 10:
            //        sonuc = sayı * 3;
            //        break;
            //    case 15:
            //        sonuc = sayı * 4;
            //        break;

            //}
            //if (sonuc==0)
            //{
            //    Console.WriteLine("tanımlanmamış değer");
            //}

            //else
            //{
            //    Console.WriteLine(sonuc);
            //}





            //int x = 11;
            // x 0 ile 10 arasındaysa 2 ile çarp 11 ile 20 arasında ise 3 ile çarp 21 ile 50 arasındaysa 4 ile çarp 51 ile 100 arasında 5 ile çarp 100 den büyükse 10 ile çarp


            //int x = 120;
            //int katsayı = 0;


            //switch (x)
            //{
            //    case (>=0 and <=10):
            //        katsayı = 2;
            //        break;
            //    case (>= 11 and <= 30):
            //        katsayı = 3;
            //            break;
            //    case (>= 21 and <= 50):
            //        katsayı=4;
            //        break;

            //}

            //Console.WriteLine();




            // içinde bulunduğumuz günün hafta içi mi hafta sonu jmu olduğunu bulun

            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //DateTime Tarih = new DateTime(2022, 10, 8);
            //DayOfWeek gun = Tarih.DayOfWeek;
            //if (gun == DayOfWeek.Sunday || gun == DayOfWeek.Saturday) 

            //{
            //    Console.WriteLine("hafta sonu eğlen");
            //}
            //else
            //{
            //    Console.WriteLine("hafta içi çalış");
            //}

            //switch (gun)
            //{

            //    case DayOfWeek.Monday:                 
            //    case DayOfWeek.Tuesday:                
            //    case DayOfWeek.Wednesday:                
            //    case DayOfWeek.Thursday:                  
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("hafta içi çalışmalısın");
            //        break;

            //    case DayOfWeek.Saturday:                
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("hafta sonu eğlen");
            //        break ;
            //    default:
            //        break;
            //}

            DateTime Tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun = Tarih.DayOfWeek;

            switch (gun)
            {

                case DayOfWeek.Monday or DayOfWeek.Tuesday or DayOfWeek.Wednesday or DayOfWeek.Thursday or DayOfWeek.Friday:
          
                    Console.WriteLine("hafta içi çalışmalısın");
                    break;
                case DayOfWeek.Saturday or DayOfWeek.Sunday:        
                    Console.WriteLine("hafta sonu eğlen");
                    break;
                default:
                    break;
            }

        }
    }

}
