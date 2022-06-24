
using System.Text.Json;

int cantidadProductos = 0;
cantidadProductos = int.Parse(Console.ReadLine());
List<Producto> Lproductos = new List<Producto>();

for (int i = 0; i < cantidadProductos; i++)
{
    Producto product = new Producto();
    Lproductos.Add(product);

}

string pathArchivoJson = @"C:\TallerLenguajesC#\tp09-2022-SantiagoYalux\PutnoUnoYDos\punto2\Json\productos.json";

if (!File.Exists(pathArchivoJson))
    File.Create(pathArchivoJson);

 string jsonStringProductos = JsonSerializer.Serialize<List<Producto>>(Lproductos);

File.WriteAllText(pathArchivoJson, jsonStringProductos);

string jsonStringProductoArchivo = File.ReadAllText(pathArchivoJson);


List<Producto> listaProductos = JsonSerializer.Deserialize<List<Producto>>(jsonStringProductoArchivo);

MostrarProductos(listaProductos);


void MostrarProductos(List<Producto> ListaProductos)
{
    foreach (Producto producto in ListaProductos)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine(producto.NOMBRE);
        Console.WriteLine(producto.FECHAVENCIMIENTO);
        Console.WriteLine(producto.PRECIO.ToString());
        Console.WriteLine(producto.TAMANIO);
        Console.WriteLine("--------------------------");
    }
}

class Producto
{
    private string nombre;
    private string fechavencimiento;
    private float precio;
    private string tamanio;

    public string NOMBRE { get { return nombre; } set { nombre = value; } }
    public string FECHAVENCIMIENTO { get { return fechavencimiento; } set { fechavencimiento = value; } }
    public float PRECIO { get { return precio; } set { precio = value; } }
    public string TAMANIO { get { return tamanio; } set { tamanio = value; } }

    public Producto()
    {
        Random rnd = new Random();
        NOMBRE = Enum.GetName(typeof(Nombres), rnd.Next(1, Enum.GetNames(typeof(Nombres)).Length));
        PRECIO = rnd.Next(1000, 5000);
        FECHAVENCIMIENTO = DateTime.Now.ToShortDateString();
        tamanio = "hola";
    }
}

public enum Nombres
{
    Santiago,
    Sergio,
    Josefina,
    Agustina,
    Mariana,
    Messi,
    Roberto,
    LuisMiguel,
    Amets,
    Amaro,
    Aquiles,
    Algimantas,
    Alpidio,
    Amrane,
    Anish,
    Arián,
    Ayun,
    Azariel,
    Bagrat,
    Bencomo,
    Bertino,
    Candi,
    Cesc,
    Cirino,
    Crisólogo,
    Cruz,
    Danilo,
    Dareck,
    Dariel,
    Darin,
    Delmiro,
    Damen,
    Dilan,
    Dipa,
    Doménico,
    Drago,
    Edivaldo,
    Elvis,
    Elyan,
    Emeric,
    Engracio,
    Ensa,
    Eñaut,
    Eleazar,
    Eros,
    Eufemio,
    Feiyang,
    Fiorenzo,
    Foudil,
    Galo,
    Gastón,
    Giulio,
    Gautam,
    Gentil,
    Gianni,
    Gianluca,
    Giorgio,
    Gourav,
    Grober,
    Guido,
    Guifre,
    Guim,
    Hermes,
    Inge,
    Irai,
    Iraitz,
    Iyad,
    Iyán,
    Joao,
    Jun,
    Khaled,
    Leónidas,
    Lier,
    Lionel,
    Lisandro,
    Lucián,
    Mael,
    Misael,
    Moad,
    Munir,
    Nael,
    Najim,
    Neo,
    Neil,
    Nikita,
    Nilo,
    Otto,
    Pep,
    Policarpo,
    Radu,
    Ramsés,
    Rómulo,
    Roy,
    Severo,
    Sidi,
    Simeón,
    Taha,
    Tao,
    Vadim,
    Vincenzo,
    Zaid,
    Zigor,
    Zouhair,
}