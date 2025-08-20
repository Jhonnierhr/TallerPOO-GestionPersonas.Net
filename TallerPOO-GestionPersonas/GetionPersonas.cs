using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    internal class GetionPersonas
    {        
        //Clase persona
        public class Persona
        {
            //Atributos de Persona
            private String _nombre {  get; set; }
            private int _edad;
            private String _documento { get; set; }

            //propiedades de validadcion para _edad
            public int Edad
            {
                get { return _edad; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("La edad no puede ser negativa. Se asignará 0 por defecto.");
                        _edad = 0;
                    }
                    else
                    {
                        _edad = value;
                    }
                }
            }

            //Constructor de Persona
            public Persona(string nombre, int edad, string documento)
            {
                _nombre = nombre;
                _edad = edad;
                _documento = documento;
            }

            //Metodo mostrarDatos
            public virtual void mostrarDatos()
            {
                Console.WriteLine($"El nombre de la persona es: {_nombre}, La edad es = {_edad}, El documento es = {_documento} ");
            }

            //Metodo validar si es mayor de edad
            public bool esMayorEdad()
            {
                return _edad >= 18;
            }
        }

        // Clase Empleado que hereda de Persona
        public class Empleado : Persona
        {           

            //atributos de Empleado 
            public String _puesto { get; set; }


            //Constructor de Empleado
            public Empleado(string nombre, int edad, string documento, String puesto) : base(nombre, edad, documento)
            {
                _puesto = puesto;
            }

            // Sobrescribe el método MostrarDatos de Persona (polimorfismo)
            public override void mostrarDatos()
            {
                base.mostrarDatos(); // Llama al método original de Persona
                Console.WriteLine($"Puesto: {_puesto}");
            }


        }

    }
}
