using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase base Factura (abstracta para forzar la implementación de GenerarFactura)
    public abstract class Factura
    {
        //Atributos de la factura
        public int _numeroFactura { get; set; }
        public string _cliente { get; set; }
        public decimal _total { get; set; }

        // Constructor
        public Factura(int numeroFactura, string cliente, decimal total)
        {
            _numeroFactura = numeroFactura;
            _cliente = cliente;
            _total = total;
        }

        // Método abstracto (obliga a las clases hijas a implementarlo)
        public abstract void GenerarFactura();

        // Método común para mostrar datos básicos
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Factura N°: {_numeroFactura}, Cliente: {_cliente}, Total: {_total:C}");
        }
    }

    // Clase FacturaElectronica hereda de Factura
    public class FacturaElectronica : Factura
    {
        public FacturaElectronica(int numeroFactura, string cliente, decimal total)
            : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"[Factura Electrónica] N° {_numeroFactura} enviada por correo electrónico al cliente {_cliente}.");
        }
    }

    // Clase FacturaFisica hereda de Factura
    public class FacturaFisica : Factura
    {
        public FacturaFisica(int numeroFactura, string cliente, decimal total)
            : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"[Factura Física] N° {_numeroFactura} impresa para el cliente {_cliente}.");
        }
    }
}
