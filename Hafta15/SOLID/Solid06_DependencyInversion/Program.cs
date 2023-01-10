//using Solid06_DependencyInversion.Before;
using Solid06_DependencyInversion.After;

namespace Solid06_DependencyInversion
{
    internal class Program
    {
        //SNIFLAR ARASI BAĞIMLILIKLAR OLABİLDİĞİNCE AZ OLMALI, ÖZELLİKLE DE ÜST SEVİYE SINIFLAR ALT SEVİYE SINIFLARA BAĞLI OLMAMALIDIR. Bağımlıkları tersine çevirecez yani 
        static void Main(string[] args)
        {
            #region Before
            //MailService mailService=new MailService();
            //mailService.SendMail(new GmailServer());
            #endregion

            #region After
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(), "zeynep@gmail.com", "Selam");
            mailService.SendMail(new HotmailServer(), "engin@gmail.com", "Merhaba");
            #endregion
        }
    }
}