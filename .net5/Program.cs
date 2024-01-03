﻿internal class Program
{
    private static void Main(string[] args)
    {
         double[,] ventas=new double[4,3]{{1,2,3},{4,5,6},{7,8,9},{10,11,12}};

           int[, ,] ventasAnio=new int[2,2,3]{ {{1,2,3},{4,5,6}} , {{7,8,9},{10,11,12}} };

Console.WriteLine(ventas[1,2]);
ventas[1,2]=450;
Console.WriteLine(ventas[1,2]);


      int i;
      int j;


      
for ( i = 0; i < 4; i++)
{

    Console.WriteLine("fila {0}",i);
    for (j = 0; j < 3; j++)
    {
        Console.WriteLine(ventas[i,j]);
    }
}




//escalonada

double[][] ventanas=new double [4][];

ventanas[0]=new double[3]; //{}
ventanas[1]=new double[2];
ventanas[2]=new double[4];
ventanas[3]=new double[3];


double[][] vent=//new double [][]
{
new double[] {1,2,3},
new double[] {4,5},
new double[] {6,7,8,9},
new double[] {10,11,12}


};


//Console.WriteLine(ventanas.Length); no funciona escalonadas ensena fila
//Console.WriteLine(ventanas[3].Length);  hay que ir por partes
//Console.WriteLine(ventanas[1][0]); 


for ( i = 0; i < vent.Length; i++)
{
    Console.WriteLine("elem: {0}",i);
    for (j =0;j < vent[i].Length ; j++ )
    {
;        Console.WriteLine(vent[i][j]); 
    }
}

//Variables
            byte  numAlumnos, salones;
            double sumaCalif = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Creación de la matriz
            double[][] calificaciones = new double[salones][];

            // Pedimos el número de alumnos por salón
            for( i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
                sumaAlumnos += numAlumnos;

                //Instanciamos las matrices internas (alumnos en cada salón)
                calificaciones[i] = new double[numAlumnos];
            }

            //Pedimos las calificaciones de los alumnos de cada salón
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Pedimos la califiación
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i] [j] = Convert.ToDouble(Console.ReadLine());

                    //Acumulamos las califiaciones
                    sumaCalif += calificaciones[i] [j];
                }
            }

            //Calculamos el promedio
            promedio = sumaCalif / sumaAlumnos;

            //Calculamos la calificación mínima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                }
            }

            //Calculamos la califiación máxima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }


            //Mostramos las calificaciones de todos los alumnos de la escuela
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
                }
            }

            //Mostramos los resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La califiación mínima es: {0}", califMin);
            Console.WriteLine("La califiación máxima es: {0}", califMax);




Console.WriteLine(calificaciones.GetLength(0));

int m,n;

for (n =0; n < ventas.GetLength(0) ;n++)
{
    for (m=0; m<ventas.GetLength(1);m++)  
     {
        Console.WriteLine(ventas[m,n]);
    }
}





    }
}