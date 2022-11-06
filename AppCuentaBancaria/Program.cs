using AppCuentaBancaria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crea un objeto de la clase Cuenta.
            Cuenta cuenta = new Cuenta();
            
            //Asigna un número de cuenta, un nombre, un saldo y un tipo de interés. 
            cuenta.setNumCuenta(1);
            cuenta.setNombre("Amnellah");
            cuenta.setSaldo(1000);
            cuenta.setTipoInteres("Deporte");

            //Muestra el estado de dicha cuenta.

            Console.WriteLine("ToString: "+cuenta.ToString());
            Console.ReadKey();

            //Crea un objeto de la clase CuentaAhorro.
            CuentaAhorro cAhorro = new CuentaAhorro(0, "", 0, "", 0);
            
            //Asigna un número de cuenta, un nombre, un saldo, un tipo de interés y una cuota de mantenimiento. 
            cAhorro.setNumCuenta(2);
            cAhorro.setNombre("Laura");
            cAhorro.setSaldo(1200);
            cAhorro.setTipoInteres("Educacion");
            cAhorro.setCuotaMantenimiento(200);

            //Muestra el estado de dicha cuenta. 
            Console.WriteLine("ToStringAhorro: " + cAhorro.ToString());
            Console.ReadKey();
        }
    }
}
