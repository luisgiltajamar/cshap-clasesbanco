using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new CuentaCorriente("Luis", 1000);
            var cc2 = new CuentaCorriente("Pepe", 3000, true, 1500);
            var ca = new CuentaAhorro("Maria", 5000, true, 0.02);

            Console.WriteLine(cc.Sacar(2000));
            Console.WriteLine(cc2.Sacar(4000));
            Console.WriteLine(ca.Sacar(2000));


            cc.Detalles();
            cc2.Detalles();
            ca.Detalles();

            Console.ReadLine();
        }
    }
}
