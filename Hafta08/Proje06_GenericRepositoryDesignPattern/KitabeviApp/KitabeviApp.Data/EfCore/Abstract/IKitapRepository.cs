using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository :IGenericRepository<Kitap>
    {
        // �U AN IGenericRepositoryden kitap i�in haz�rlanm�l crud metotlar� var
        //E�er class IkitapRepositoryden miras al�rsa t�m bu crud metotlar� oraya implenmente edilir.
        // Buraya yaz�lacak metotlar sadece(a�ag�daki gibi) sadece kitaap entitysine �zg� metotlard�r.
        List<Kitap> KategoriyeG�reKitapListesi();

        
    }
}