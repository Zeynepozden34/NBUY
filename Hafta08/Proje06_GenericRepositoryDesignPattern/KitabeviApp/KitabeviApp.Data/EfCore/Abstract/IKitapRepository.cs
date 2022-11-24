using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository :IGenericRepository<Kitap>
    {
        // þU AN IGenericRepositoryden kitap için hazýrlanmýl crud metotlarý var
        //Eðer class IkitapRepositoryden miras alýrsa tüm bu crud metotlarý oraya implenmente edilir.
        // Buraya yazýlacak metotlar sadece(aþagýdaki gibi) sadece kitaap entitysine özgü metotlardýr.
        List<Kitap> KategoriyeGöreKitapListesi();

        
    }
}