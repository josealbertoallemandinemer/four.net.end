// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");



int opcion;
bool repetir=true;
string mensajeParaCifrar, contrasenaMensaje, mensajeCifrado;

MemoryStream memoryStream1= new MemoryStream();

Console.WriteLine("ingresa mensaje a cifrar");
mensajeParaCifrar=Console.ReadLine();

Console.WriteLine("ingresa contrasena");
contrasenaMensaje=Console.ReadLine();

mensajeCifrado=CifrarMensaje(mensajeParaCifrar);

byte[] matrizCadenaByte=Encoding.UTF8.GetBytes(mensajeCifrado);

memoryStream1.Write(matrizCadenaByte,0,matrizCadenaByte.Length);


Console.WriteLine("mensaje protegido, presiona cualquier tecla para continuar");
Console.ReadKey();


byte[] buferBytesLeidos= new byte[100];

memoryStream1.Seek(0,SeekOrigin.Begin);

memoryStream1.Read(buferBytesLeidos,0,(int)memoryStream1.Length);

string cadenaDescodificadaCifrada=Encoding.UTF8.GetString(buferBytesLeidos);

do
{
    Console.Clear();

    Console.WriteLine("1.Mostrar mensaje");
    Console.WriteLine("2.Decifrar mensaje");
    Console.WriteLine("3.Me rindo :(");

    Console.WriteLine("escoge");
    opcion=Convert.ToInt32(Console.ReadLine());

    switch (opcion)
{
    case 1:
    Console.WriteLine($"mensaje:\"{cadenaDescodificadaCifrada}\"");
    Console.WriteLine("tecla para continuar");
    Console.ReadKey();

    break;

    case 2:
    Console.WriteLine("ingresa contrasena para decifrar mensaje");
    string posibleContrasena=Console.ReadLine();

    if (posibleContrasena==contrasenaMensaje)
    {
        
       string mensajeDecifrado=DecifrarMensaje(cadenaDescodificadaCifrada);

       Console.WriteLine($"mensaje:\"{mensajeDecifrado}\"");

       Console.WriteLine("tecla para continuar");
       Console.ReadKey();

       memoryStream1.Close();

       repetir=false;


    }else
    {
       Console.WriteLine("incorrecto, intentalo otra vez"); 
       Console.WriteLine("tecla para continuar");
       Console.ReadKey();
    }

    break;

    case 3:

    repetir=false;
    
    break;





    default:
    break;
}


} while (repetir);





















static string CifrarMensaje(string mensajeCifrarPa)
{
    string mensajeCifrado;

    mensajeCifrado=mensajeCifrarPa;

    mensajeCifrado=mensajeCifrado.Replace('a','1');
    mensajeCifrado=mensajeCifrado.Replace('e','2');
    mensajeCifrado=mensajeCifrado.Replace('i','3');
    mensajeCifrado=mensajeCifrado.Replace('0','4');
    mensajeCifrado=mensajeCifrado.Replace('u','5');

    return mensajeCifrado;
}

static string DecifrarMensaje(string mensajeCifradoPa)
{
    string mensajeDecifrado;

    mensajeDecifrado=mensajeCifradoPa;

    mensajeDecifrado=mensajeDecifrado.Replace('1','a');
    mensajeDecifrado=mensajeDecifrado.Replace('2','e');
    mensajeDecifrado=mensajeDecifrado.Replace('3','i');
    mensajeDecifrado=mensajeDecifrado.Replace('4','o');
    mensajeDecifrado=mensajeDecifrado.Replace('5','u');

    return mensajeDecifrado;
}