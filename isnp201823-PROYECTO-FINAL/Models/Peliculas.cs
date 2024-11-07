using System.ComponentModel.DataAnnotations;

namespace isnp201823_PROYECTO_FINAL.Models
{
    public class Peliculas
    {[Key]
        public int IdPeliculas { get; set; }

        public string titulo { get; set; }

        public string director { get; set; }

        public string sinopsis { get; set; }

        public string duracion { get; set; }

        public string clasificasion { get; set; }

        public byte foto { get; set; }
    }
}
