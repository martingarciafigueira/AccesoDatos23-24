namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            string frase = "";

            fichero = File.CreateText("C:\\Log_Usuario.txt");

            do
            {
                Console.WriteLine("Escribe una frase: ");
                frase = Console.ReadLine();
                if (frase != "END")
                {
                    fichero.WriteLine(frase);
                }
            } while (frase != "END");

            fichero.Close();
        }
    }
}