using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Interfaz que define las acciones de reservar y cancelar
    public interface IReservable
    {
        void Reservar();
        void CancelarReserva();
    }
}
