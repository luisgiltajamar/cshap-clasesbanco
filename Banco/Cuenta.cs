using System;

namespace Banco
{
   public abstract class Cuenta
    {
       public String Titular { get; set; }
       public double Saldo { get; set; }

       public Cuenta()
       {
       }

       public Cuenta(String titular, double saldo)
       {
           Titular = titular;
           Saldo = saldo;
       }

       public virtual void Detalles()
       {
           Console.WriteLine("Titular: {0}, Saldo: {1:C}",Titular,Saldo);
       }

       public virtual double Ingresar(double cantidad)
       {
           Saldo += cantidad;
           return Saldo;
       }

       public virtual double Sacar(double cantidad)
       {
           return 0;
       }

    }
}
