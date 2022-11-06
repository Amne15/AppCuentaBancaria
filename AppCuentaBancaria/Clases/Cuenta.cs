using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppCuentaBancaria.Clases
{
    public class Cuenta
    {
        // Iidentificación fiscal de la cuenta bancaria
        private int numCuenta;
        // Hace referencia al nombre del cliente
        private String nombre = "";
        // saldo monetario de la cuenta
        private double saldo = 0;
        //Tipo interés aplicado en tanto por ciento
        private String tipoInteres = "";

        public Cuenta()
        {
        }

        public Cuenta(int numCuenta, string nombre, double saldo, string tipoInteres)
        {
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.saldo = saldo;
            this.tipoInteres = tipoInteres;
        }

        /**/
        public int getNumCuenta() 
        {
            return this.numCuenta;
        }

        /**/
        public void setNumCuenta(int numCuenta)
        {
            this.numCuenta = numCuenta;
        }

        /**/
        public String getNombre()
        {
            return this.nombre;
        }

        /**/
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        /**/
        public double getSaldo()
        {
            return this.saldo;
        }

        /**/
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        /**/
        public String getTipoInteres()
        {
            return this.tipoInteres;
        }

        /**/
        public void setTipoInteres(String tipoInteres)
        {
            this.tipoInteres = tipoInteres;
        }

        /**/
        public override string ToString()
        {
            return "Numero Cuenta: " + numCuenta + ", Nombr Cuenta: " +nombre + ", Saldo: "+saldo +". Tipo de cuenta: " + tipoInteres;
        }

        /**/
        //interface de acceso a los atributos(set y get: asignar y obtener)
        //estado(obtiene el estado de la cuenta es decir el valor de cada uno de los atributos de la clase).



    }
}
