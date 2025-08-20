using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    internal class CuentaBancaria
    {
        // Atributos privados
        private String _titular { get; set; }
        private decimal _saldo { get; set; }
        private string _numeroCuenta { get; set; }

        // Constructor
        public CuentaBancaria(string titular, string numeroCuenta, decimal saldoInicial)
        {
            _titular = titular;
            _numeroCuenta = numeroCuenta;

            // Validamos que el saldo inicial no sea negativo
            if (saldoInicial < 0)
                _saldo = 0;
            else
               _saldo = saldoInicial;
        }


        // Método para depositar dinero
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0) // Solo aceptamos depósitos positivos
            {
                _saldo += cantidad;
                Console.WriteLine($"Se depositaron {cantidad:C}. Nuevo saldo: {_saldo:C}");
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
        }

        // Método para retirar dinero
        public void Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
            }
            else if (cantidad > _saldo) // Evitamos que el saldo quede negativo
            {
                Console.WriteLine("Fondos insuficientes. Retiro no permitido.");
            }
            else
            {
                _saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad:C}. Nuevo saldo: {_saldo:C}");
            }
        }

        // Método para mostrar el saldo actual
        public void MostrarSaldo()
        {
            Console.WriteLine($"El saldo actual de la cuenta {_numeroCuenta} a nombre de {_titular} es: {_saldo:C}");
        }



    }
}
