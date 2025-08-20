using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase que representa una habitación del hotel
    public class HabitacionHotel : IReservable
    {
        //Atributos de la habitación
        public int _numeroHabitacion { get; set; }
        public bool _estaReservada { get; private set; }

        public HabitacionHotel(int numeroHabitacion)
        {
            _numeroHabitacion = numeroHabitacion;
            _estaReservada = false;
        }

        public void Reservar()
        {
            if (!_estaReservada)
            {
                _estaReservada = true;
                Console.WriteLine($"✅ La habitación {_numeroHabitacion} ha sido reservada.");
            }
            else
            {
                Console.WriteLine($"⚠️ La habitación {_numeroHabitacion} ya está reservada.");
            }
        }

        public void CancelarReserva()
        {
            if (_estaReservada)
            {
                _estaReservada = false;
                Console.WriteLine($"❌ La reserva de la habitación {_numeroHabitacion} ha sido cancelada.");
            }
            else
            {
                Console.WriteLine($"⚠️ La habitación {_numeroHabitacion} no tiene ninguna reserva activa.");
            }
        }

    }


    // Clase que representa un salón de eventos
    public class SalonEventos : IReservable
    {
        public string _nombreSalon { get; set; }
        public bool _estaReservado { get; private set; }

        public SalonEventos(string nombreSalon)
        {
            _nombreSalon = nombreSalon;
            _estaReservado = false;
        }

        public void Reservar()
        {
            if (!_estaReservado)
            {
                _estaReservado = true;
                Console.WriteLine($"✅ El salón de eventos '{_nombreSalon}' ha sido reservado.");
            }
            else
            {
                Console.WriteLine($"⚠️ El salón '{_nombreSalon}' ya está reservado.");
            }
        }

        public void CancelarReserva()
        {
            if (_estaReservado)
            {
                _estaReservado = false;
                Console.WriteLine($"❌ La reserva del salón '{_nombreSalon}' ha sido cancelada.");
            }
            else
            {
                Console.WriteLine($"⚠️ El salón '{_nombreSalon}' no tiene ninguna reserva activa.");
            }
        }
    }
}
