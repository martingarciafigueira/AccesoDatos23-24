namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMERO_LINEAS_LEIDAS = 3;

            using (StreamReader fichero = new StreamReader("Log_Usuario.txt"))
            {
                for (int i = 0; i < NUMERO_LINEAS_LEIDAS; i++)
                {
                    string linea = fichero.ReadLine();
                    Console.WriteLine(linea);
                }
            }
            Console.ReadKey();
        }
    }
}