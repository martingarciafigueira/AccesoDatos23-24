namespace Actividad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                
            }
        }
            string rutaFichero = "";
            const int NUMERO_LINEAS_POR_VEZ = 10;

            Console.WriteLine("EMPIEZA A LEER EL FICHERO");

            using (StreamReader fichero = new StreamReader(rutaFichero))
            {
                do
                {
                    for (int i = 0; i < NUMERO_LINEAS_POR_VEZ; i++)
                    {
                        Console.WriteLine(fichero.ReadLine());
                    }
                    Console.ReadKey();
                } while (!fichero.EndOfStream);
            }
        }
    }
}