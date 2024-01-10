namespace Actividad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellidos;
            const string RUTA_FICHERO = @"Alumnos\\nombres.txt";
            StreamWriter fichero;

            if (!File.Exists(RUTA_FICHERO))
            {
                fichero = File.CreateText(RUTA_FICHERO);
                fichero.Close();
            }

            Console.Write("Escriba su nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escriba sus apellidos:");
            apellidos = Console.ReadLine();

            Console.WriteLine("Su nombre y apellidos son: {0} {1}", nombre, apellidos);

            fichero = File.AppendText(@"Alumnos\nombres.txt");
            fichero.WriteLine(nombre + " " + apellidos);
            fichero.Close();

            Console.ReadKey();
        }
    }
}