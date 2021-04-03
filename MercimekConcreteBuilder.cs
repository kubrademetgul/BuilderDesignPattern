using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MercimekConcreteBuilder:CorbaBuilder
    {
        public MercimekConcreteBuilder()
        {
            corba = new Corba();
        }
        public override void SetTuz() => corba.Tuz = 60;
        public override void SetCorbaAdi() => corba.CorbaAdi = "Mercimek Çorbası";
       
    }
}
