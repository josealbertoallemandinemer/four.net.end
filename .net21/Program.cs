// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Alumno alumno1=new Alumno();

alumno1.Nombre="luis";
Console.WriteLine(alumni1.Nombre);

Alumno alumno2=alumno1;

alumno1.Nombre="erick";

Console.WriteLine(alumni1.Nombre);

//////////

Transferencia transferencia1= new Transferencia();
transferencia1.fecha=DateTime.Now;
transferencia1.monto=1000;
transferencia1.destinatario="jose";
transferencia1.numeroCuenta="2746383827";
transferencia1.concepto="pago prestamo";

Console.WriteLine(transferencia1.ToString());

/////////////

Estudiante estudiante1=new Estudiante();

estudiante1.Nombre="Luis";
estudiante1.Apellido="gutierrez";

Calificacion[] calificaciones=new Calificacion[3]
{

   new Calificacion {Materia="matematicas",Puntaje=9},
   new Calificacion {Materia="historia",Puntaje=7},
   new Calificacion {Materia="fisica",Puntaje=4}


};


estudiante1.Calificaciones=calificaciones;

Console.WriteLine($"nombre:{estudiante1.Nombre} {estudiante1.Apellido}\n");

foreach (Calificacion elemento in estudiante1.Calificaciones)
{
    Console.WriteLine($"{elemento.Materia}={elemento.Puntaje}");
}


//////////

struct Alumno
{
    string nombre;

    public string Nombre{get=>nombre;set=>nombre=value;}
    
}

////////////

struct Transferencia
{
    publicDateTime fecha;
    public double monto;
    public string destinatario;
    public string numeroCuenta;
    public string concepto;
    
    public overide string ToString()
    {

          string mensaje;

          mensaje=$"fecha:{fecha.ToString()}\nmonto:${monto}\nDestinatario:{destinatario}";

          return mensaje;

    }



}

//////

class jugador
{
    string nombre;
    int vida;
    int puntaje;

    List<Item> inventario;


}

struct item                  //no mayor a 16bytes?//inmutable//no conversiones boxing//temporal//formar parte de algo mas grande

{

   string nombre;
   int tipo;
   int dano;
   int vida;



}

//////

struct Calificacion
{
    string materia;
    double puntaje;

    public string Materia{get=>materia;set=>materia=value;}
    public string Puntaje{get=>puntaje;set=>puntaje=value;}
}

struct Estudiante
{
    string nombre;
    string apellido;
    Calificacion[] calificaciones;

    public string Nombre{get=>nombre;set=>nombre=value;}
    public string Apellido{get=>apellido;set=>apellido=value;}
    public Calificacion[] Calificaciones {get=>calificaciones;set=>calificaciones=value;}


}