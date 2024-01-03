// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///
/// 
Semana DiaDePago=Semana.viernes;
Console.WriteLine(DiaDePago);
Console.WriteLine((int)DiaDePago+1);

string quinto=DiaDePago.ToString();
Console.WriteLine(typeof(int));

int num=5+(int)DiaDePago;
Console.WriteLine(num);


Type tipoDatoEntero;

tipoDatoEntero=typeof(int);

Console.WriteLine(tipoDatoEntero);
///

Type tipoEnumeracion=typeof(Continentes);

Continentes[] costantesContinentes;

costantesContinentes=(Continentes[])Enum.GetValues(tipoEnumeracion);

foreach (Continentes elemento in costantesContinentes)
{
    Console.WriteLine(elemento);
}
///
string cadenaAConvertir;
Console.WriteLine("ingresa un rgb");
cadenaAConvertir=Console.ReadLine();

object valorEnumDevuelto;

valorEnumDevuelto= Enum.Parse(typeof(rgb),cadenaAConvertir);
rgb cadenaConvertidaEnum;
cadenaConvertidaEnum=(rgb)valorEnumDevuelto;
/// guion bajo sirve para separar numeros visualmente
/// 
int a=10, b=2;
opcionesMenu opcion;

Console.WriteLine("selecciona del 1-4");
opcion=(opcionesMenu)Enum.Parse(typeof(opcionesMenu),Console.ReadLine());


switch (opcion)
{
    case opcionesMenu.suma:
    Console.WriteLine($"{a}+{b}={a+b}");
    break;
}
///





enum Semana//: uIn cambia el tipo de los componentes
{
    lunes,martes,miercoles,jueves,viernes,sabado,domingo
}

enum Continentes//: uIn cambia el tipo de los componentes
{
    africa,america,asia,europa,oceania

}

enum rgb
{
    rojo,verde,azul
}

enum opcionesMenu
{
   suma=1,resta,multiplicacion,division
}