internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CALENTAR HORNO!");
        Console.WriteLine("mezclar harina y mantequilla!");
        Console.WriteLine("azucar y huevos!");
        Console.Write("amasar");
        Console.Write("darle forma");
        Console.Write("hornear");


        int numeroLibros;

       // int librosMate;

        double notaFinal = 9.8;

        numeroLibros = 500;

        char salon;

        salon = 'a';

        string saludo = "hola";


       // bool x = true;

       // decimal promedioExamen = 8.5m;

       // float notaClase = 7.9f;



        //comentario
        /*comentario*/

        Console.WriteLine(saludo);

        Console.WriteLine(salon);

        Console.WriteLine(notaFinal);

        Console.WriteLine(numeroLibros);

        Console.WriteLine("el precio es: {0} y su color es: {1}", numeroLibros, saludo);

    
       Console.WriteLine(1+6+notaFinal);
    
        Console.WriteLine(saludo+" "+"jose");

        Console.WriteLine(13/2.0);

        Console.WriteLine(5%2);

        //double lleva uno siempre un .0


        string tuNombre;

        Console.WriteLine("escribe tu nombre: ");
        tuNombre=Console.ReadLine();

        Console.WriteLine("hola {0} ",tuNombre);

        string b2;
        int b1=5,b3,numero;

        Console.WriteLine("introduce numero a sumarle 5:");
        
        b2=Console.ReadLine();

        b3=Convert.ToInt32(b2);

        //CONVERT LO PONE A 0 SI HAY PROBLEMA , PARSE CIERRA

        numero=b1+b3;

        Console.WriteLine(numero);

        int numb2, numb1=2, resultado;

         Console.WriteLine("introduce numero a sumarle 2:");
        // numb2=Convert.ToInt32(Console.ReadLine());

        numb2=Int32.Parse(Console.ReadLine());

        //ToDouble

         resultado=numb1+numb2;

         Console.WriteLine(resultado);

         Console.WriteLine(6==6);

         Console.WriteLine(4==3);

         Console.WriteLine(3!=1);



double number;
         Console.WriteLine("give me a number:");
         number=Convert.ToDouble(Console.ReadLine());

         if (number>0)
         {
            Console.WriteLine("numero es positivo y es el: {0}",number);
         } else
         {
            Console.WriteLine("numero negativo y es el: {0}",number);
         }


double a,b,c,d=0D;

Console.WriteLine(" number 1-3");

a=Convert.ToInt32(Console.ReadLine());

if (a==1)
{
    Console.WriteLine("1 es suma, decide que numeros sumar:");
    b=Convert.ToDouble(Console.ReadLine());
    c=Convert.ToDouble(Console.ReadLine());
    d=b+c;
    Console.WriteLine("la suma de {0} mas {1} es: {2}",b,c,d);


} else
{
   if (a==2)
{
    Console.WriteLine("2 es resta, decide que numeros restar:");
    b=Convert.ToDouble(Console.ReadLine());
    c=Convert.ToDouble(Console.ReadLine());
    d=b-c;
    Console.WriteLine("la resta de {0} menos {1} es: {2}",b,c,d);


} else
{
    if (a==3)
{
    Console.WriteLine("3 es decirte que eres gay");
    


} else
{
    if (a<=0 || a>3)
    {
        Console.WriteLine("error");
    }
}
}




}


bool bateria, movil=true;

Console.WriteLine("hay bateria? true/false");
bateria=Convert.ToBoolean(Console.ReadLine());
Console.WriteLine(bateria);


if (bateria && movil)
{
   Console.WriteLine("todo perfect"); 
}else
{
    Console.WriteLine("te falta movil o bateria"); 
}

string colours;

Console.Write("ingresa el color rgb");

colours=Console.ReadLine();

switch (colours)
{
    
    case "red":
    case "RED":
    Console.WriteLine("255,0,0");
    break;

    case "green":
    Console.WriteLine("0,255,0");
    break;

    case "blue":

    /*if (true)
    {
        
    }*/

    Console.WriteLine("0,0,255");
    break;

    default:
    
    Console.WriteLine("no existe");
    break;
    
}


const int r=10; //constantes no cambian
int l=1;

Console.WriteLine("valor : {0}", ++l);
Console.WriteLine("valor : {0}", l++);
Console.WriteLine("valor : {0}", l);

int i;
int contador=0;
for ( i = 1; i <= 10; i++, Console.WriteLine(i))
{
     Console.WriteLine(i);
     contador ++;
     Console.WriteLine(contador);
}

Console.WriteLine(i);

// x+=5    ==    x=x+5


int j,n=0,m;

for ( j = 1; j <= 5; j++)
{
    Console.Write("ingresa precio producto: ");
    m=Convert.ToInt32(Console.ReadLine());

    n=n+m;
}


Console.WriteLine("el total es: {0}", n);



//acumuladores inicializar a 0 para no dar problemas, media de notas de ninos



ulong su,si,se=1;

Console.Write("factorial");
si=Convert.ToUInt64(Console.ReadLine());

for (su =si; su >=1; su--)
{
    se=se*su;
}

Console.WriteLine(se);



string contrasena1, contrasena2="";

Console.Write("escribe contrasena");
contrasena1=Console.ReadLine();

while (contrasena1!=contrasena2)
{
    Console.Write("confirma contrasena");
    contrasena2=Console.ReadLine();
}

Console.WriteLine("super");


int aa=0; //15 lo sacaria una vez, a contrario de while se ejecuta una vez

 do
 {
    Console.WriteLine(aa);
    aa++;
 } while (aa<=10);



int api, apu, apa;

for (api=1; api <= 10; api++)
{
    Console.WriteLine("tabla del {0}",api);

    for (apu = 0; apu < 10; apu++)
    {
       apa=api*apu;

       Console.WriteLine("{0}*{1}={2}",api,apu,apa); 
    }

}


//Console.ReadKey(); con depuracion no la cierra punto a la derecha y ejecutamos por parte para ver las asignaciones

double numero1,numero2,angela=1,po=1;
double res=1;

Console.WriteLine("introduce un numero y a cuanto lo quieres elevar"); 

numero1=Convert.ToInt32(Console.ReadLine());
numero2=Convert.ToInt32(Console.ReadLine());

if (numero2<0)
{
    numero2 *= -1;
    while (angela<=numero2)
{
   // Console.WriteLine("va por el {0}", angela); 
       
     po *= numero1;

     
     
     angela++;
}
     res=(1/po);
     Console.WriteLine(res);
}else
{
    while (angela<=numero2)
{
   // Console.WriteLine("va por el {0}", angela); 
       
     po *= numero1;

     

    angela++;
}
Console.WriteLine(po);
}



int tii,tuu,taa=0;

for (tii =2 ; tii<=100; tii++)
{
     for (tuu = 1; tuu <= tii; tuu++)
     {
         if (tii%tuu==0)
         {
            taa+=1;
         }
     }
}

if (taa<=2)
{
    Console.WriteLine(tii);
}
taa=0;


























    }




}