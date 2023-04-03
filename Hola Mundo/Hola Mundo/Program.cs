// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Hola "+nombre);

string hora = DateTime.Now.ToString("h:mm:ss tt");
Console.WriteLine("La hora es : " + hora);