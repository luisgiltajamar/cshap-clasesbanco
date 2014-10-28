using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class CuentaAhorro:Cuenta
    {
       public bool PuedeSacar { get; set; }
       public double Comision { get; set; }

       public CuentaAhorro()
       {
       }

       public CuentaAhorro(String titular, double saldo,
           bool sacar = false, double comision = 0):base(titular,saldo)
       {
           PuedeSacar = sacar;
           Comision = comision;
       }

       public override double Sacar(double cantidad)
       {
           if (PuedeSacar)
           {
               Saldo -= cantidad + cantidad*Comision;

           }
           return Saldo;
       }

       public override void Detalles()
       {
           base.Detalles();
           Console.WriteLine("Puede sacar: {0}, Comision: {1:P}",
              PuedeSacar ? "Si" : "No", Comision);
       }
    }
}
