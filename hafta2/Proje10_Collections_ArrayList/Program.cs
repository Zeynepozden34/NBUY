using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            static void Yazdır(ArrayList arrayList)
            {
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }
            }                                               

            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine( "Default Sıra");
            Yazdır(sayilar);
            sayilar.Sort();
            Console.WriteLine("*********");
            Console.WriteLine("küçükten büyüğe sıralı");
            Yazdır(sayilar);
            sayilar.Sort();
            Console.WriteLine("**********");
            Console.WriteLine("Büyükten küçüğe sıralı");
            sayilar.Reverse();
            Yazdır(sayilar);




            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < sayilar.Count; i++) //araylistlerde length yerine count kullanılır.
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


















            //ArrayList myList = new ArrayList(); // Arraylistelerinin içinde farklı tipller tanımlanabilir.

            //myList.Add(120);
            //myList.Add("120");
            //myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);

            //myList.Insert(0, "yeniEleman"); // Insert(arayaekleme) listeye sonradan yeni değer atayabilir. değer atarken new yazmak zorundayız dizilerdeki gibi süslüparantez içine yazılmaz.


            //ArrayList addedList = new ArrayList() { "Ayşen Umay", "Fercan Sercan", "Kazım Kolkanat" };

            //myList.InsertRange(4, addedList); // 4. elemanandan sonra addedlisti eklemeye başladı.
            //myList.AddRange(addedList);// Mylist listesinin sonuna ekler.

            ////myList.Remove("120"); // Listeden bu indexi siler. (Listenin değerini direk yazmalıyız.)
            ////myList.RemoveAt(0); // listenin 0'incı indexi sildi.
            ////myList.RemoveRange(0, 3); // listenin belli aralığını siler.



            //foreach (var sıradaki in myList)
            //{
            //    Console.WriteLine(sıradaki);
            //}
            //if (myList.Contains("Zeynep")==true)
            //{
            //    Console.WriteLine("Evet, Zeynep listede mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Acil, Zeynep'e haber ver. listede yok");
            //}

            //Console.WriteLine();
            //Console.WriteLine(myList[3]);




            Console.ReadLine();
        }
    }
}