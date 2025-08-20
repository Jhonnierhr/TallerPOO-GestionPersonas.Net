using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO_GestionPersonas
{
    // Clase base Publicacion
    public class Publicacion
    {
        // Atributos de la clase Publicacion
        public string _autor { get; set; }
        public string _contenido { get; set; }
        public DateTime _fechaPublicacion { get; set; }

        // Constructor
        public Publicacion(string autor, string contenido, DateTime fechaPublicacion)
        {
            _autor = autor;
            _contenido = contenido;
            _fechaPublicacion = fechaPublicacion;
        }

        // Método virtual que será sobrescrito
        public virtual void MostrarPublicacion()
        {
            Console.WriteLine($"Autor: {_autor}, Publicado el: {_fechaPublicacion}");
            Console.WriteLine($"Contenido: {_contenido}");
        }
    }


    // clase Publicación de solo texto que hereda de Publicacion
    public class PublicacionTexto : Publicacion
    {
        public PublicacionTexto(string autor, string contenido, DateTime fechaPublicacion)
            : base(autor, contenido, fechaPublicacion) { }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"[Texto] {_autor} ({_fechaPublicacion})");
            Console.WriteLine($"📝 {_contenido}");
        }
    }

    // clase Publicación con imagen que hereda de Publicacion
    public class PublicacionImagen : Publicacion
    {
        public string _urlImagen { get; set; }

        public PublicacionImagen(string autor, string contenido, DateTime fechaPublicacion, string urlImagen)
            : base(autor, contenido, fechaPublicacion)
        {
            _urlImagen = urlImagen;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"[Imagen] {_autor} ({_fechaPublicacion})");
            Console.WriteLine($"🖼️ {_contenido}");
            Console.WriteLine($"🔗 Imagen: {_urlImagen}");
        }

    }

    // clase Publicación con video que hereda de Publicacion
    public class PublicacionVideo : Publicacion
    {
        public string _urlVideo { get; set; }
        public int _duracion { get; set; } // en segundos

        public PublicacionVideo(string autor, string contenido, DateTime fechaPublicacion, string urlVideo, int duracion)
            : base(autor, contenido, fechaPublicacion)
        {
            _urlVideo = urlVideo;
            _duracion = duracion;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine($"[Video] {_autor} ({_fechaPublicacion})");
            Console.WriteLine($"🎬 {_contenido}");
            Console.WriteLine($"🔗 Video: {_urlVideo}, ⏱️ Duración: {_duracion} segundos");
        }
    }

}
