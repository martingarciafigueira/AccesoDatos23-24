namespace Actividad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = File.AppendText(@"C:\Log.txt\hola\eres\tu\el\otro\jefe");
            string frase;

            do {
                Console.WriteLine("Teclea una frase");
                frase = Console.ReadLine();

                if (frase != "")
                {
                    fichero.WriteLine(frase);
                }
            } while (frase != "");

            fichero.Close();
        }
    }
}