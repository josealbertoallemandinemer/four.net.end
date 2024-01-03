// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

Char[] caracter={'h','o','l','a'};
string cadena="holu";
string unirCaracteres= new string(caracter);
Console.WriteLine(unirCaracteres);

string texto1="hola";
string texto2="a";
string texto3="todos";
string texto4="hola"+"a"+"todos";
string texto5="hola a todos";
texto5 +="ustedes";

string[] palabras ={"hola","a","todos"};
string texto = string.Concat(palabras);
string textoseparador=string.Join("-",palabras);

string pa="hola", pa1="a", pa2="todos";
Console.WriteLine();
Console.WriteLine(string.Concat(pa,pa1,pa2));


string parrafo=" yvtg fuyvu tfkgvg, utfityvvv ouy, vu";

string[] palabrass=parrafo.Split('');
//string[] palabrass=parrafo.Split('',',');
Console.WriteLine(palabrass[0]);
Console.WriteLine(palabrass[1]);

foreach (string elemento in palabrass)
{
    Console.WriteLine("palabra sustraida es: {0}",elemento);
}

string parr="holaholi holu hili hele halo hai pitito";

Console.WriteLine("ingresa palabra a buscar");
string buscartexto=Console.ReadLine();

if (parr.Contains(buscartexto)) //EndsWith  StartsWith 
{
    Console.WriteLine("se encontro {0}", buscartexto);
}else{  Console.WriteLine("no se encontro {0}", buscartexto);   }


string palabra="pantalla";
char caracterBuscado='a';

int primeraAparicion=palabra.IndexOf(caracterBuscado); //LastIndexOff
Console.WriteLine("la primera aparicion de ({0}) en la cadena ({1}) es en ({2})", caracterBuscado,palabra,primeraAparicion);


string a="hola";
string b=a;

Console.WriteLine("ref 1"+a);

Console.WriteLine("ref 1"+b);

a+="a todos";

Console.WriteLine("ref 1"+a);

Console.WriteLine("ref 1"+b);

string texto_original="mi hermano guille es gay de fijo";

string textoDeCambio=texto_original.Replace("guille","Guille");//Trim elimina caracteres del principio o final
                                                               //Remove(21,4);

Console.WriteLine(textoDeCambio);


string akagui="";
for(int di=1; di<=10; di++)
{
    akagui+=di+",";
}

Console.WriteLine(akagui);


StringBuilder numbers= new StringBuilder(); //asi no se carga tanto pero no se puede buscar
for (int i = 0; i < 10; i++)
{
    numbers.Append(i);
    numbers.Append(",");
}

string cadenaNumeros=numbers.ToString();
Console.WriteLine(cadenaNumeros);


//comparar cadenas
string correo11="",correo22="";

bool coincide=Equals(correo11,correo22);

if (coincide)
{
    Console.WriteLine("si");
}else{Console.WriteLine("no");}


if (correo11.Equals(correo22, StringComparison.OrdinalIgnoreCase))//que no importen mayusculas
{
    Console.WriteLine("si");
}else{Console.WriteLine("no");}


//ToUpper lo pone todo en mayusculas    ToLower todo a minusculas
//Char.ToUpper o Char.ToLower

//Console.WriteLine(String.Compare(correo11,correo22,new CultureInfo("sv-SE"),CompareOptions.None);
//da -1,0,1 segun criterio de ordenacion

string dd="hola a todos";


Console.WriteLine(dd.PadLeft(15,'#'));

//secuencias de escape como /n

//cadena1=String.Format("el valor es {0}", numero);             se inserta valor no es posicion como siempre
//console.writeline(cadena1);


//son cadenas de formato

//cadena interpolada    console.writeline($"huhuh {numero1} huhuhuh{numero2} ji");

// textual   string ruta=@"c:\windows\font";

// int @for;

// DateTime fechahoradeter= new DateTime();       2004,01,23  se puede jugar con las horas tambien
//console.writeline($"la fecha se {fechahoradeter}");
// string cadena=fechahoradeter.tostring("d");              cambia formato hay muchos  \"feliz\"  \\de
//console.writeline($"la fecha se {fechahoradeter}");

//string cfechahora;        DateTime date;      ESCRIBIMOS Y... date=DateTime.Parse(cfechayhora);  mostramos
































