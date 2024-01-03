// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string elem;
int opcion;

List<string> Personas = new List<string>();
Personas.Add("hugo");
Personas.Add("pitito");
Personas.Add("nico");

console.WriteLine(Personas[1]);
console.WriteLine(Personas.Count());

do
{
    console.WriteLine("1.agregar elemento");
    console.WriteLine("2.salir");
    opcion=Convert.ToInt32(console.ReadLine());

  if (opcion==1)
  {
    console.WriteLine("agregar elemento");
    elem=Console.ReadLine();

    Personas.add(elem);
  }


} while (opcion==1);

Personas.Insert(2,"victor");
Personas.RemoveAt(4);


foreach (string elemento in Personas)
{
   Console.WriteLine(elemento); 
}
string ele;
Console.WriteLine("\ningresa que buscar");
ele=Console.ReadLine();

Console.WriteLine("el elemento esta en {0}",Personas.IndexOf(elem));


//Personas.Clear();