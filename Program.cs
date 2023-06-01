// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escriba su nombre");
string nombre = Console.ReadLine();;
Console.WriteLine(nombre);
string hora = DateTime.Now.ToString("h:mm:ss tt");
Console.WriteLine("La hora es {0}", hora);