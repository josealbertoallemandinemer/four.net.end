// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


FileStream fr= new FileStream("C:\\Users\\LosSupers\\Desktop\\web\net\\.net27\\MiPrimerArchivoTXT.txt",FileMode.Create); //C:\\Users\\LosSupers\\Desktop\\web\net\\.net27\\MiPrimerArchivoTXT.txt

string textoParaArchivo="texto para el archivo";

byte[] bufferCadenaBytes;

bufferCadenaBytes=Encoding.UTF8.GetBytes(textoParaArchivo);

fr.Write(bufferCadenaBytes,0,bufferCadenaBytes.Length);

///////////////
///
FileStream fs= new FileStream("C:\\Users\\LosSupers\\Desktop\\web\net\\.net27\\MiPrimerArchivoTXT.txt",FileMode.Open); 

byte[] bufferLeerDatosArchivo=new byte[1024];

fs.Read(bufferLeerDatosArchivo,0,bufferLeerDatosArchivo.Length);

string cadenaDescodificada=Encoding.UTF8.GetString(bufferLeerDatosArchivo);

Console.WriteLine($"el contenido es {cadenaDescodificada}");

/////////
///
FileStream fl;

fl=File.Create("Archivo con File.txt");

fl.Close();

File.WriteAllText("Archivo con File.txt","prueba de que se escribio");

//////
///

FileStream fx;

fx=File.Create("Archivo con File.txt");

byte[] bufer=Encoding.UTF8.GetBytes("prueba de super texto");

fx.Write(bufer,0,(int)bufer.Length);

fx.Close();

////////////
///


FileStream fo=File.Create("Archivo con File 2.txt");



fo.Close();

File.AppendAllText("Archivo con File 2.txt","texto anexado");  //lo abre y cierra