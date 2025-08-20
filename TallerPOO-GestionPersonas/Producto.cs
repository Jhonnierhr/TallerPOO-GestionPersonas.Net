using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase base Producto
    public class Producto
    {
        // Encapsulamiento: propiedades con getters y setters
        public string _nombre { get; set; }
        public decimal _precio { get; set; }
        public int _stock { get; set; }

        // Constructor
        public Producto(string nombre, decimal precio, int stock)
        {
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }

        // Método virtual para aplicar descuento (por defecto sin descuento)
        public virtual void AplicarDescuento()
        {
            Console.WriteLine($"El producto {_nombre} no tiene descuento especial. Precio: {_precio:C}");
        }

        // Método para mostrar información
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Producto: {_nombre}, Precio: {_precio:C}, Stock: {_stock}");
        }
    }

    // Clase Electronico hereda de Producto
    public class Electronico : Producto
    {
        public int _garantiaMeses { get; set; }

        // Constructor
        public Electronico(string nombre, decimal precio, int stock, int garantiaMeses)
            : base(nombre, precio, stock)
        {
            _garantiaMeses = garantiaMeses;
        }

        // Sobrescribimos el método AplicarDescuento (10% menos)
        public override void AplicarDescuento()
        {
            _precio = _precio - (_precio * 0.10m);
            Console.WriteLine($"[Electrónico] {_nombre} con garantía de {_garantiaMeses} meses. Precio con 10% de descuento: {_precio:C}");
        }

        // Mostrar información
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Electrónico] {_nombre}, Precio: {_precio:C}, Stock: {_stock}, Garantía: {_garantiaMeses} meses");
        }
    }

    // Clase Ropa hereda de Producto
    public class Ropa : Producto
    {
        public string _talla { get; set; }

        // Constructor
        public Ropa(string nombre, decimal precio, int stock, string talla)
            : base(nombre, precio, stock)
        {
            _talla = talla;
        }

        // Sobrescribimos el método AplicarDescuento (20% menos)
        public override void AplicarDescuento()
        {
            _precio = _precio - (_precio * 0.20m);
            Console.WriteLine($"[Ropa] {_nombre} talla {_talla}. Precio con 20% de descuento: {_precio:C}");
        }

        // Mostrar información
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Ropa] {_nombre}, Precio: {_precio:C}, Stock: {_stock}, Talla: {_t  alla}");
        }
    }
}
