internal class Program
{
    private static void Main(string[] args)
    {
        // int [] numeros' matriz
          double [] calificaciones= new double [4] {9,10,4.1,0};

          // double [] notas={9,10,4.1,0};

         //numeros= new int[] {5,3,1}
           
         
        //calificaciones[2]=6;

         Console.WriteLine(calificaciones[2]);

         double califin;

         califin= calificaciones[2]-1;

         Console.WriteLine(califin);


string[] nombres=new string[3];

/*nombres[0]="angela";
nombres[1]="jose";
nombres[2]="thanos";*/

//Console.WriteLine(nombres[2]);


byte i;
for ( i = 0; i <= 2; i++)
{
   // Console.WriteLine(nombres[i]);

     Console.Write("ingresa valor {0}",i);
     nombres[i]=Console.ReadLine();
}

for ( i = 0; i <= 2; i++)
{
    Console.WriteLine(nombres[i]);

    
}



byte j, numalumn;
double plus=0,promedio, calmax=10, calfmin=0;


Console.Write("n de alumnos");
numalumn=Convert.ToByte(Console.ReadLine());

double [] cal= new double [numalumn];

for (j = 0; j < numalumn; j++)
{
    Console.WriteLine("nota");
    cal[j]=Convert.ToDouble(Console.ReadLine());
    plus+=cal[j];
}

promedio=plus/numalumn;

for (j =0; j<numalumn; j++)
{
    if (cal[j]<calfmin)
    {
        calfmin=cal[j];
    }
}

for (j =0; j<numalumn; j++)
{
    if (cal[j]>calmax)
    {
        calmax=cal[j];
    }
}


Console.WriteLine("el promedio es {0}", promedio);
Console.WriteLine("calif max {0}", calmax);
Console.WriteLine("calif min {0}", calfmin);









    }
}