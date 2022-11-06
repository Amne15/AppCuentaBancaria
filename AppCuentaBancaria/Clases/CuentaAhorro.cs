using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuentaBancaria.Clases
{
    internal class CuentaAhorro : Cuenta
    {
        //private Cuenta cuenta;
        private int cuotaMantenimiento;
        

        /**/
        public CuentaAhorro() : base()
        {
        }

        /**/
        public CuentaAhorro(int cuotaMantenimiento) : base()
        {            
            //this.cuenta = cuenta;
            this.cuotaMantenimiento = cuotaMantenimiento;            
        }

        public CuentaAhorro(int numCuenta, string nombre, double saldo, string tipoInteres, int cuotaMantenimiento) : base(numCuenta, nombre, saldo, tipoInteres)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }


        /**/
        public int getCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }

        /**/
        public void setCuotaMantenimiento(int cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public override string ToString()
        {
            //return base.ToString();
            
            return base.ToString() +", Cuota Mantenimiento: " + cuotaMantenimiento +" !!";
        }
    }
}
