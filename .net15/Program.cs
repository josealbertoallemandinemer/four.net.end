// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Stack <double> miPila= new Stack<double>();

miPila.Push(5.9);
miPila.Push(13.1);
miPila.Push(8.7);
miPila.Push(10.5);


int i;

foreach (double elemento in miPila)
{
    Console.WriteLine("{0}. {1}", i++,elemento);
}


miPila.Pop();
miPila.Peek();

bool contiene;
double buscar;

Console.WriteLine("ingresa que buscas");
buscar=Convert.ToDouble(Console.ReadLine());
contiene=miPila.Contains(buscar); //si no devuelve -1

if (contiene)
{
    Console.WriteLine("{0} esta",buscar);
}
else
{
    Console.WriteLine("{0} no esta",buscar);
}

Console.WriteLine("{0} elementos", miPila.Count());

//miPila.clear;

Queue<char> miFila =new Queue<char>();

miFila.Enqueue("a");
miFila.Enqueue("b");
miFila.Enqueue("c");
miFila.Enqueue("d");

foreach (char elemento in miFila)
{
    Console.WriteLine("{0}. {1}", i++,elemento);
}

var elim=miFila.DeQueue();
 Console.WriteLine(elim);

 Dictionary<string,int> empleados = new Dictionary<string,int>();

 empleados.add("hugo",36);
  empleados.add("mario",20);
   empleados.add("jose",31);
    empleados.add("luis",32);
     empleados.add("dany",48);

     foreach (KeyValuePair<string, int> elemento in empleados)
{
    Console.WriteLine(elemento); //elemento.key o elemento.value
}

//esta que sigue sobreescribe no da errores

empleados["miguel"]=45;

//empleados.Add("miguel",45);

Console.WriteLine(empleados["luis"]);

//empleados.Remove("jose");

//tipo bool

empleados.ContainsKey("dany");







