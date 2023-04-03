// Ejercicio 1
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
Console.WriteLine("Tienes " + edad + " años") ;
Console.WriteLine("Sabe programar :" + programar);
//Ejercicio 2
Console.WriteLine("Ingrese los Datos se su Coche");
Console.Write("Ingrese el Número de puertas: ");
int? puertas = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el Número de Ruedas: ");
int? ruedas = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la Marca: ");
string? marca = Console.ReadLine();
Console.WriteLine("¿Tiene el ITV vigente? (True or False)");
bool? itv = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Su coche es de la marca: " + marca);
Console.WriteLine("Tiene " + puertas + " puertas");
Console.WriteLine("Tiene " + ruedas+ " ruedas");
Console.WriteLine("¿ITV vigente? :" + itv);

Console.WriteLine("Ingrese los Datos se su Mesa");
Console.Write("Ingrese el Peso: ");
double? peso = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el largo: ");
double? largo = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el nombre del material del que esta hecho: ");
string? material = Console.ReadLine();
Console.Write("Ingrese el nombre del color de la mesa: ");
string? color = Console.ReadLine();
Console.WriteLine("Su mesa tiene un peso de: " + peso);
Console.WriteLine("Tiene " + largo + " de largo");
Console.WriteLine("Es del material de: " + material);
Console.WriteLine("Es de Color :" + color);
//Ejercicio 3
Console.WriteLine("El número ingresado, " + 20 + " ¿Es mayor o igual a 18? " + (20 >= 18));
char letra = 'a';
Console.WriteLine("¿a es un char? " + char.IsLetter(letra));
Console.WriteLine((20 >= 18) && (char.IsLetter(letra)));
Console.WriteLine((12 >= 18) && (char.IsLetter(letra)));