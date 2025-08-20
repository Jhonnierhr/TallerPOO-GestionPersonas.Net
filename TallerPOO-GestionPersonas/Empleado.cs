using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase base Empleado
    public class Empleado
    {
        // Atributos de Empleado
        public string _nombre { get; set; }
        public decimal _salarioBase { get; set; }

        // Constructor
        public Empleado(string nombre, decimal salarioBase)
        {
            _nombre = nombre;
            _salarioBase = salarioBase;
        }

        // Método virtual para calcular salario
        public virtual decimal CalcularSalario()
        {
            return _salarioBase;
        }

        // Mostrar información del empleado
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Empleado: {_nombre}, Salario: {CalcularSalario():C}");
        }
    }


    // Clase EmpleadoTiempoCompleto hereda de Empleado
    public class EmpleadoTiempoCompleto : Empleado
    {
        // Constructor
        public EmpleadoTiempoCompleto(string nombre, decimal salarioBase)
            : base(nombre, salarioBase) { }

        // Salario = SalarioBase (no cambia nada)
        public override decimal CalcularSalario()
        {
            return _salarioBase;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Tiempo Completo] {_nombre}, Salario: {CalcularSalario():C}");
        }
    }



    // Clase EmpleadoPorHoras hereda de Empleado
    public class EmpleadoPorHoras : Empleado
    {
        public int _horasTrabajadas { get; set; }

        // Constructor
        public EmpleadoPorHoras(string nombre, decimal salarioPorHora, int horasTrabajadas)
            : base(nombre, salarioPorHora)
        {
            _horasTrabajadas = horasTrabajadas;
        }

        // Salario = HorasTrabajadas * SalarioBase (que en este caso es salario por hora)
        public override decimal CalcularSalario()
        {
            return _horasTrabajadas * _salarioBase;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Por Horas] {_nombre}, Horas: {_horasTrabajadas}, Salario: {CalcularSalario():C}");
        }
    }
}
