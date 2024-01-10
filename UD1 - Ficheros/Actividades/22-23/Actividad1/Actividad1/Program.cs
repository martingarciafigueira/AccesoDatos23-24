StreamWriter fichero;
string entradaTexto = "";

fichero = File.CreateText("C:/prueba/Log_Usuario.txt");

while (entradaTexto != "END")
{
    Console.Write("Escribe lo que quieras: ");
    entradaTexto = Console.ReadLine();
    if (entradaTexto != "END")
    {
        fichero.WriteLine(entradaTexto);
    }    
}

fichero.Close();

Console.ReadLine();