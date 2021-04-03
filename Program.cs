using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
           CorbaBuilder builder = new MercimekConcreteBuilder();
           CorbaYapici corbaYapici = new CorbaYapici();
            corbaYapici.CorbaYap(builder);
            builder.Corba.ToString();

            builder = new TarhanaConcreteBuilder();
           corbaYapici.CorbaYap(builder);
            builder.Corba.ToString();

            Console.Read();
        }
    }
}
