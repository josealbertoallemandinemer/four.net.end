using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {

        decimal r;
        decimal num1ar,num2ar;
        (decimal n1, decimal n2, decimal res) numeros;
        Sumar();

       // r= Restar();

       numeros= Restar();

        Console.WriteLine("el resultado es: {0}",numeros.res);



   /* Console.Write("ingresa primer num");
    num1ar=Convert.ToDecimal(Console.ReadLine());
     
    Console.Write("ingresa segundo num");
    num2ar=Convert.ToDecimal(Console.ReadLine());*/

    num1ar=IngresarNumero("ingresa el 1ro:");
    num2ar=IngresarNumero("ingresa el 2ro:");


    Multiplicar(num1ar,num2ar);


    Console.Write("ingresa primer num");
    num1ar=Convert.ToDecimal(Console.ReadLine());
     
    Console.Write("ingresa segundo num");
    num2ar=Convert.ToDecimal(Console.ReadLine());

   r=Dividir(num1ar,num2ar);


   Console.WriteLine("el resultado es: {0}",r);


byte numar;
numar=10;
Console.WriteLine(numar);
Prueba(ref numar);
Console.WriteLine(numar);

byte numar0;
string saludoar;
int numeroprimo;
//var es para todo

Prueba1(out numar0, out saludoar, out numeroprimo);
Console.WriteLine(numar0);
Console.WriteLine(saludoar);
Console.WriteLine(numeroprimo);

//dupla
(string, byte, long num5, int) persona1 = ("luis", 50, 677688976, 001122);
//var persona1 = ("luis", 50, 677688976, 001122);

var persona2 = (nombre:"luis",edad: 50, Id:677688976, Calle: 001122);

Console.WriteLine(persona1);

Console.WriteLine(persona1.Item1);

Console.WriteLine(persona1.num5);

Console.WriteLine(persona2.edad);



//grados a rad

double gradosar, radianes;

Console.Write("grados:");
gradosar=Convert.ToDouble(Console.ReadLine());

radianes=gradosRadianes(gradosar);
Console.Write("{0} grados = {1} radianes",gradosar,radianes);








    }


 
static void Sumar()
 
 {
    decimal num1, num2, resultado;

    

    Console.Write("ingresa primer num");
    num1=Convert.ToDecimal(Console.ReadLine());
     
    Console.Write("ingresa segundo num");
    num2=Convert.ToDecimal(Console.ReadLine());


   resultado=num1+num2;

   Console.WriteLine("{0}+{1}={2}",num1,num2,resultado);


 }


  /*static decimal Restar()
 
 {
    decimal num1, num2, resultado;

    Console.Write("ingresa primer num");
    num1=Convert.ToDecimal(Console.ReadLine());
     
    Console.Write("ingresa segundo num");
    num2=Convert.ToDecimal(Console.ReadLine());


   resultado=num1-num2;

   return resultado;



 }*/

 static (decimal,decimal,decimal) Restar()
 
 {
    decimal num1, num2, resultado;

    Console.Write("ingresa primer num");
    num1=Convert.ToDecimal(Console.ReadLine());
     
    Console.Write("ingresa segundo num");
    num2=Convert.ToDecimal(Console.ReadLine());


   resultado=num1-num2;

   return (num1,num2,resultado);



 }

  static void Multiplicar(decimal num1pa, decimal num2pa)

{
    decimal resultado;

    resultado= num1pa*num2pa;

    Console.WriteLine(resultado);



}

static decimal Dividir(decimal num1pa, decimal num2pa)
{
   decimal resultado;

   if (num2pa!=0)
   {
      resultado=num1pa/num2pa;
   }else
   {
     Console.WriteLine("no es posible");
     resultado=0;
   }

return resultado;

}

static decimal IngresarNumero(string peticion)
{
   decimal numero;

   Console.Write(peticion);

   numero= Convert.ToDecimal(Console.ReadLine());

   return numero;


}


static void Prueba(ref byte numPa)
{
    numPa=20;
}

static void Prueba1(out byte numPa, out string saludopa, out int numeroprimopa)
{
    numPa=20;
    saludopa="hola a todos";
    numeroprimopa=7;
}


static double gradosRadianes (double gradospa)
{
    double radianes;
    radianes=(gradospa* Math.PI)/100;

    return radianes;
}



 }
   




