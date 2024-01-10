StreamReader fichero;

fichero = File.OpenText("C:/prueba/Log_Usuario.txt");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(fichero.ReadLine());
}

fichero.Close();

Console.ReadLine();
