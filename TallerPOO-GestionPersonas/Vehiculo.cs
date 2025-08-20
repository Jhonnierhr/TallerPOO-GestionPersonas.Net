using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase base que representa un vehículo genérico
    public class Vehiculo
    {
        // Atributos de la clase Vehiculo
        public string _marca { get; set; }
        public string _modelo { get; set; }
        public int _año { get; set; }
        public decimal _precio { get; set; }

        // Constructor
        public Vehiculo(string marca, string modelo, int año, decimal precio)
        {
            _marca = marca;
            _modelo = modelo;
            _año = año;
            _precio = precio;
        }

        // Método virtual que podrá ser sobrescrito por las clases hijas
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {_marca}, Modelo: {_modelo}, Año: {_año}, Precio: {_precio:C}");
        }
    }

    // Clase Automovil que hereda de Vehiculo
    public class Automovil : Vehiculo
    {
        public int _cantidadPuertas { get; set; }

        // Constructor que hereda atributos de Vehiculo y agrega la propiedad propia
        public Automovil(string marca, string modelo, int año, decimal precio, int cantidadPuertas)
            : base(marca, modelo, año, precio) // Llamamos al constructor de la clase base
        {
            _cantidadPuertas = cantidadPuertas;
        }

        // Sobrescribimos el método para mostrar también la cantidad de puertas
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Automóvil] Marca: {_marca}, Modelo: {_modelo}, Año: {_año}, Precio: {_precio:C}, Puertas: {_cantidadPuertas}");
        }
    }

    // Clase Motocicleta que hereda de Vehiculo
    public class Motocicleta : Vehiculo
    {
        public int _cilindraje { get; set; }

        // Constructor que hereda atributos de Vehiculo y agrega el cilindraje
        public Motocicleta(string marca, string modelo, int año, decimal precio, int cilindraje)
            : base(marca, modelo, año, precio)
        {
            _cilindraje = cilindraje;
        }

        // Sobrescribimos el método para mostrar también el cilindraje
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Motocicleta] Marca: {_marca}, Modelo: {_modelo}, Año: {_año}, Precio: {_precio:C}, Cilindraje: {_cilindraje}cc");
        }
    }
}
