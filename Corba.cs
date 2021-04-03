using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    enum CorbaAdi
    {
        Mercimek, Tarhana
    }


    class Corba
    {


        public string CorbaAdi { get; set; }
        public double Tuz { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{CorbaAdi} -> Tuz Oranı : {Tuz}");
            return base.ToString();
        }
    }
}
