// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


//using System.IO;

MemoryStream ms1= new MemoryStream(100);

InformacionStream(ms1);


Console.WriteLine("ingresa un texto");
string cadena1=Console.ReadLine();

byte[] matrizCadenaByte;

matrizCadenaByte=Encoding.UTF8.GetBytes(cadena1);  //UNICODE O UTF8 VALEN

ms1.Write(matrizCadenaByte,0,matrizCadenaByte.Length);

InformacionStream(ms1);



ms1.Seek(5,SeekOrigin.Begin); //posicion despues asi hay espacio o ms1.Seek(1,SeekOrigin.Current);  y esto sobreescribe: ms1.Seek(-4,SeekOrigin.End);
Console.WriteLine($"la posicion ahora es de : {ms1.Position} bytes");






byte[] nuevaMatrizCadenaByte=Encoding.UTF8.GetBytes("llena");
ms1.Write(nuevaMatrizCadenaByte,0,nuevaMatrizCadenaByte.Length);

InformacionStream(ms1);



byte[] buferBytesLeidos= new byte(100);

ms1.Seek(5,SeekOrigin.Begin);//se coloca

int bytesLeidos = ms1.Read(buferBytesLeidos,0, (int)ms1.Length);


Console.WriteLine($"bytes leidos : {bytesLeidos} ");

string cadenaDescodificada=Encoding.UTF8.GetString(buferBytesLeidos);
Console.WriteLine($"cadena descodificada : {cadenaDescodificada} ");

ms1.Close();



static void InformacionStream(MemoryStream ms1Pa)
{
    Console.WriteLine($"la capacidad es de : {ms1Pa.Capacity} bytes");
    Console.WriteLine($"la longitud es de : {ms1Pa.Length} bytes");
    Console.WriteLine($"la posicion es de : {ms1Pa.Position} bytes");
}