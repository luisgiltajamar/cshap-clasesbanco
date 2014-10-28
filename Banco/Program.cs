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


            var cc = CrearCuentaConsola();
            var cc2 = CrearCuentaConsola();
            var ca = new CuentaAhorro("Maria", 5000, true, 0.02);

            Console.WriteLine(cc.Sacar(2000));
            Console.WriteLine(cc2.Sacar(4000));
            Console.WriteLine(ca.Sacar(2000));


            cc.Detalles();
            cc2.Detalles();
            ca.Detalles();

            Console.ReadLine();
        }

        private static CuentaCorriente CrearCuentaConsola()
        {
            Console.Write("Titular:");
            var t = Console.ReadLine();
            Console.Write("Saldo:");
            double s;  
            double.TryParse(Console.ReadLine(), out s);
            Console.Write("Credito:");
            bool credito; 
            bool.TryParse(Console.ReadLine(), out credito);
            Console.Write("Limite:");
            var limite = 0D;
            double.TryParse(Console.ReadLine(), out limite);
           
            return new CuentaCorriente(t,s,credito,limite);
        }


    }
}
