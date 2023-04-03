Cliente cliente1 = new Cliente("Mauricio Rodriguez", 123456, "Zona Alto san antonio", "asd@gmail.com", true);
Console.WriteLine(cliente1);
public struct Cliente
{
    public Cliente(string nombre, int numero, string direccion, string email, bool nuevoCliente)
    {
        Nombre = nombre;
        Numero = numero;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
    }
    public string Nombre { get; }
    public int Numero { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool NuevoCliente { get; }

    public override string ToString() =>$"{Nombre}, {Numero}, {Direccion}, {Email}, {NuevoCliente}";
}
