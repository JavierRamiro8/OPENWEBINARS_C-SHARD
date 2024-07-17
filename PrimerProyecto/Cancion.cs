using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    public class Cancion : IMedia
    {
        public long Segundos { get; set; }

        public string Titulo {  get; set; }

        public Disco disco { get; set; }

        public void Play()
        {
            Console.WriteLine("Escuchando: "+ Titulo);
        }
    }
}
