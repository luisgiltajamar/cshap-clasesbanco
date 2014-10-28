using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente:Cuenta
    {
        public bool Credito { get; set; }
        public double Limite { get; set; }

        public CuentaCorriente()
        {
        }

        public CuentaCorriente(String titular, double saldo,
            bool credito=false, double limite=0)
            : base(titular, saldo)
        {
            Credito = credito;
            Limite = limite;
        }

        public override double Sacar(double cantidad)
        {
            if (cantidad <= Saldo)
            {
                Saldo -= cantidad;
            }
            else if (Credito && (Limite > Saldo - cantidad))
            {
                Saldo -= cantidad;
            }
            return Saldo;
        }

        public override void Detalles()
        {
            base.Detalles();
            Console.WriteLine("Credito: {0}, Limite: {1}",
                Credito?"Si":"No",Limite);
        }

        
    }
}
