//While
/*Console.WriteLine("Ingrese un numero:");
int numero = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= 10)
{
    Console.WriteLine(numero+" x "+a+" = "+(a*numero));
    a++;
};
//Do while
int num = 0;
int pos = 0;
int neg = 0;
do
{
    Console.WriteLine("Ingrese un numero:");
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        pos += 1;
    }
    else if (num != 0)
    {
        neg += 1;
    }
} while (num != 0);
Console.WriteLine("Números Positivos :" + pos);
Console.WriteLine("Números Negativos :" + neg);*/
//For
Console.WriteLine("Ingresa 4 datos");
Console.Write("Ingresa la cantidad :");
int cantidad = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el alto :");
int alto = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Ingresa el ancho :");
int ancho= Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el relleno (true o false) :");
bool relleno = Convert.ToBoolean(Console.ReadLine());
string[,] matriz = new string[alto,ancho];

for(int k = 0; k < cantidad; k++)
{
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (relleno == true)
            {
                matriz[i, j] = "*";
            }
            else if ((i == 0 || j == 0) || (i == alto - 1 || j == ancho - 1))
            {
                matriz[i, j] = "*";
            }
            else
            {
                matriz[i, j] = " ";
            }
        }
    }
}
for(int k = 0; k < cantidad; k++)
{
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            Console.Write(matriz[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
