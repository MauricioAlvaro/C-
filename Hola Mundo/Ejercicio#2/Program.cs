// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese sus Datos personales");
Console.Write("Ingrese su Nombre: ");
string? nombre = Console.ReadLine();
Console.Write("Ingrese su Apellido: ");
string? apellido = Console.ReadLine();
Console.Write("Ingrese su Edad: ");
int? edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Sabe Programar? (True or False)");
bool? programar = Convert.ToBoolean(Console.ReadLine()); 

Console.WriteLine("Bienvenido " + nombre + " " + apellido);
Console.WriteLine("Tienes " + edad + "años") ;
Console.WriteLine("Sabe programar :" + programar);
