
//using Solid04_LiskovsSubstition.Before;

using Solid04_LiskovsSubstition.After;


namespace Solid04_LiskovsSubstition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before
            //Guvercin guvercin= new Guvercin();
            //Penguen penguen= new Penguen();
            //Console.WriteLine("Penguen uçmaz");
            //Serce serce = new Serce();
            //Console.WriteLine(serce.UcmaMesafesi());
            //Console.WriteLine(guvercin.UcmaMesafesi());


            //Kus[] kuslar = { new Guvercin(), new Penguen(), new Serce() };
            //foreach (var kus in kuslar)
            //{
            //    Console.WriteLine(kus.UcmaMesafesi());
            //}
            #endregion


            #region After
            Kus[] kuslar = { new Guvercin(), new Penguen() };
            foreach (var kus in kuslar)
            {
                Console.WriteLine(kus.UcmaMesafesi());
            }
            #endregion

            Console.ReadLine();
       
        }
    }
}