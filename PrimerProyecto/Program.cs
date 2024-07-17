using PrimerProyecto;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion = new Cancion();
            cancion.Titulo = "Dark side of the moon";
            cancion.Segundos = 500;
            cancion.disco=new Disco(0,0);
            cancion.Play();

            Console.ReadKey();
        }
        static int Declaraciones()
        {
            int numero1 = 1;
            double numeroDoble = 1.21d;
            bool numeroVerdad = true;
            string numeroEscrito = "1";
            return numero1;
        }
    }
}

