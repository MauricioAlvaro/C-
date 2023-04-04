//Ejercicio 1
Console.WriteLine("Ingrese sus datos personales");
Console.Write("Ingrese su Nombre Completo :");
string? nombre = Console.ReadLine();
Console.Write("Ingrese su correo electronico :");
string? email = Console.ReadLine();
Console.Write("Ingrese si cuenta con un cupon (true or false) :");
bool cupon = Convert.ToBoolean(Console.ReadLine());
string producto = "Reloj";
int precio = 100; 

if(cupon == true)
{
    Console.WriteLine("Cuenta con cupon de descuento");
    Console.WriteLine("El precio de " + producto + ", con descuento es de : " + (precio * 0.3));
}
else
{
    Console.WriteLine("No cuenta con cupon de descuento");
    Console.WriteLine("El precio de " + producto + ", sin descuento es de : " + precio);
}
//Ejercicio 2
Console.WriteLine("Eliga alguno de los lenguiajes de programacion que desee (1-7)");
List<string> list = new List<string>() {"1. C#", "2. Java", "3. PHP", "4. Python", "5. Rubi", "6. GO", "7. JavaScript"};
foreach(string str in list)
{
    Console.WriteLine(str);
}
Console.WriteLine("Escriba el numero que correponda al lenguaje que desee");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case (1):
        Console.WriteLine("Hola Mundo en " + list[0].Substring(3));
        break;
    case (2):
        Console.WriteLine("Hola Mundo en " + list[1].Substring(3));
        break;
    case (3):
        Console.WriteLine("Hola Mundo en " + list[2].Substring(3));
        break;
    case (4):
        Console.WriteLine("Hola Mundo en " + list[3].Substring(3));
        break;
    case (5):
        Console.WriteLine("Hola Mundo en " + list[4].Substring(3));
        break;
    case (6):
        Console.WriteLine("Hola Mundo en " + list[5].Substring(3));
        break;
    case (7):
        Console.WriteLine("Hola Mundo en " + list[6].Substring(3));
        break;
    default:
        Console.WriteLine("No reconocio ninguno ");
        break;
}