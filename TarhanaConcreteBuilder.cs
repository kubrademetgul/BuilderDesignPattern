using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   class TarhanaConcreteBuilder:CorbaBuilder
    {
        public TarhanaConcreteBuilder()
        {
            corba = new Corba();
        }
        public override void SetTuz() => corba.Tuz = 75;
        public override void SetCorbaAdi() => corba.CorbaAdi = "Tarhana Çorbası";
        
        
    }
}
