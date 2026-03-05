Dictionary<string, string> usuarios = new Dictionary<string, string>();

string usuario;

Console.WriteLine("Ingrese la cantidad de usarios que ingresara: ");
int cant = int.Parse(Console.ReadLine());

for (int x = 0; x < cant; x++)
{
    Console.WriteLine("Ingrese el usuario: ");
    usuario = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña: ");
    string contraseña = Console.ReadLine();

    usuarios.Add(usuario, contraseña);
}