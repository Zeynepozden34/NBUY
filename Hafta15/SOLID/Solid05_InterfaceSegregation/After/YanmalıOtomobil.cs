using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterfaceSegregation.After
{
    public class YanmalıOtomobil : IOtomobilOrtak, IYanmalıMtor
    {
        public int KapiSayisiGetir()
        {
            throw new NotImplementedException();
        }

        public double MotorGücünüGetir()
        {
            throw new NotImplementedException();
        }

        public int UretimYiliGetir()
        {
            throw new NotImplementedException();
        }

        public string YakitTipiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
