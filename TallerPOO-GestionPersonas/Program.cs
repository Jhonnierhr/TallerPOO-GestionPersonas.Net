using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TallerPOO_GestionPersonas
{
    class Program
    {
        static void Main(string[] args)
        {

            //instacias personas
            ////Personas
            //GetionPersonas.Persona persona1 = new GetionPersonas.Persona("Jhonnier", 15, "2323445");              
            //persona1.mostrarDatos();
            //Console.WriteLine($"¿Es mayor de edad? =  {persona1.esMayorEdad()}");

            ////Empleados
            //GetionPersonas.Empleado empleado1 = new GetionPersonas.Empleado("Jhonatan", 25, "2323445", "Backend");
            //empleado1.mostrarDatos();
            //Console.WriteLine($"¿Es mayor de edad? =  {empleado1.esMayorEdad()}");



            ////instancias cuentas bancarias
            //// Creamos una cuenta bancaria con saldo inicial
            //CuentaBancaria cuenta1 = new CuentaBancaria("Jhonnier Hernandez", "123456789", 500m);

            //// Mostramos saldo inicial
            //cuenta1.MostrarSaldo();

            //// Hacemos un depósito válido
            //cuenta1.Depositar(200m);

            //// Intentamos hacer un depósito inválido
            //cuenta1.Depositar(-50m);

            //// Retiramos una cantidad válida
            //cuenta1.Retirar(100m);

            //// Intentamos retirar más de lo que hay en la cuenta
            //cuenta1.Retirar(700m);

            //// Mostramos saldo final
            //cuenta1.MostrarSaldo();

            //Console.WriteLine("\nOperaciones finalizadas.");



            //Instancias de Vehiculos
            // Creamos instancias de Automóvil y Motocicleta
            //Vehiculo auto1 = new Automovil("Toyota", "Corolla", 2022, 85000000m, 4);
            //Vehiculo moto1 = new Motocicleta("Yamaha", "MT-09", 2023, 48000000m, 890);

            //// Polimorfismo: aunque las variables son del tipo Vehiculo,
            //// al llamar MostrarInfo() se ejecuta el método sobrescrito
            //auto1.MostrarInfo();
            //moto1.MostrarInfo();

            //Console.WriteLine("\n--- Sistema de Vehículos Finalizado ---");


            //Instancias de Productos
            //// Creamos productos
            //Producto laptop = new Electronico("Laptop Dell", 3000000m, 5, 24);
            //Producto camiseta = new Ropa("Camiseta Nike", 120000m, 15, "M");

            //// Mostramos información antes del descuento
            //Console.WriteLine("=== Antes de aplicar descuentos ===");
            //laptop.MostrarInfo();
            //camiseta.MostrarInfo();

            //Console.WriteLine("\n=== Aplicando descuentos ===");
            //laptop.AplicarDescuento();
            //camiseta.AplicarDescuento();

            //Console.WriteLine("\n=== Después de aplicar descuentos ===");
            //laptop.MostrarInfo();
            //camiseta.MostrarInfo();

            //Console.WriteLine("\n--- Sistema de Tienda Finalizado ---");


            //Instancias de Empleados
            //// Creamos empleados
            //Empleado empleado1 = new EmpleadoTiempoCompleto("Ana Pérez", 3000000m);
            //Empleado empleado2 = new EmpleadoPorHoras("Carlos Gómez", 25000m, 160); // 160 horas * $25.000

            //// Polimorfismo: cada uno ejecuta su propia versión de CalcularSalario()
            //empleado1.MostrarInfo();
            //empleado2.MostrarInfo();

            //Console.WriteLine("\n--- Gestión de Empleados Finalizada ---");



            //Instancias de Facturas
            //// Creamos una lista de facturas (polimorfismo en acción)
            //List<Factura> facturas = new List<Factura>
            //{
            //    new FacturaElectronica(1001, "Empresa ABC", 1500000m),
            //    new FacturaFisica(1002, "Juan Pérez", 300000m),
            //    new FacturaElectronica(1003, "María Gómez", 750000m)
            //};

            //// Recorremos la lista y ejecutamos el comportamiento de cada tipo de factura
            //foreach (Factura f in facturas)
            //{
            //    f.MostrarInfo();
            //    f.GenerarFactura();
            //    Console.WriteLine("---------------------------------");
            //}

            //Console.WriteLine("\n--- Sistema de Facturación Finalizado ---");



            //Instancias de Publicaciones
            // Creamos publicaciones de distintos tipos
            //List<Publicacion> publicaciones = new List<Publicacion>
            //{
            //    new PublicacionTexto("Jhonnier", "Hoy aprendí herencia en C#!", DateTime.Now),
            //    new PublicacionImagen("Ana", "Miren esta hermosa foto del atardecer.", DateTime.Now, "https://previews.123rf.com/images/kotangens/kotangens1711/kotangens171100104/90625008-woman-on-kjeragbolten-travel-in-norway-kjerag-mountains-extreme-vacations-adventure-tourist.jpg"),
            //    new PublicacionVideo("Carlos", "Video de chat keyley the best moments.", DateTime.Now, "https://www.youtube.com/watch?v=IRF5cdDlXic&list=RDIRF5cdDlXic&start_radio=1", 120)
            //};

            //// Mostramos cada publicación
            //Console.WriteLine("=== Publicaciones en la Red Social ===\n");
            //foreach (Publicacion p in publicaciones)
            //{
            //    p.MostrarPublicacion();
            //    Console.WriteLine("--------------------------------------");
            //}

            //Console.WriteLine("\n--- Sistema de Publicaciones Finalizado ---");



            //Instancias de Reservas
            //// Creamos instancias de habitaciones y salones usando la interfaz
            //List<IReservable> reservables = new List<IReservable>
            //{
            //    new HabitacionHotel(101),
            //    new HabitacionHotel(202),
            //    new SalonEventos("Gran Salón Real"),
            //    new SalonEventos("Salón Ejecutivo")
            //};

            //Console.WriteLine("=== Sistema de Reservas de Hotel ===\n");

            //// Hacemos reservas
            //foreach (var item in reservables)
            //{
            //    item.Reservar();
            //}

            //Console.WriteLine("\n--- Cancelando algunas reservas ---\n");

            //// Cancelamos reservas
            //reservables[1].CancelarReserva(); // Habitación 202
            //reservables[2].CancelarReserva(); // Gran Salón Real

            //Console.WriteLine("\n--- Sistema de Reservas Finalizado ---");

        }
    }

    
}