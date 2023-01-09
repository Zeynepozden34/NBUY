
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_SingleResponsibility.Before
{
    public class Customer
    {
        void Login(string username, string password)
        {
            //login işlemleri ilgili kodlar
        }
        void Register(string username, string password, string email)
        {
            //registerİşleleri
            SendMail("kaydınız başarıla gerçekleşti");
        }
        void SendMail(string text) //MAİL GÖNDERME SADECE CUSTOMERLE İLGİLİ DEĞİL BAŞKA BİRŞEYDE MAİL GÖNDEREBİLRİİZ. BUNUN BURADA OLMAMASI GEREKİYIR
        {
            //MAİL GÖNDERME İLE İLGİLİ KODLAR
        }
    }
}
