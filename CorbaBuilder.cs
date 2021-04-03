using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CorbaBuilder
    {
        protected Corba corba;

        public Corba Corba
        {
            get
            {
                return corba;
            }
        }
      
        abstract public void SetCorbaAdi();
        abstract public void SetTuz();
       
    }
}

