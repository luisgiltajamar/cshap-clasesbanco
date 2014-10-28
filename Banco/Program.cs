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
            var carr = new Cuenta[3];

            carr[0] = CrearCuentaConsola();
            carr[1] = CrearCuentaConsola();
            carr[2] = new CuentaAhorro("Maria", 5000, true, 0.02);

            //Console.WriteLine(cc.Sacar(2000));
            //Console.WriteLine(cc2.Sacar(4000));
            //Console.WriteLine(ca.Sacar(2000));

            foreach (var cuenta in carr)
            {
                cuenta.Detalles();

                if(cuenta is CuentaAhorro)
                    Console.WriteLine("Soy de ahorro");
            }
            
            Console.ReadLine();

            Cuenta cap = new CuentaAhorro();
            Cuenta cp=new CuentaCorriente("Pepe",3000,true,25000);

          

            CuentaCorriente cpc = (CuentaCorriente) cp;

              Console.WriteLine(((CuentaCorriente)cp).Limite);

            cp.Detalles();

            CuentaCorriente cpn =  cap as CuentaCorriente;


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
