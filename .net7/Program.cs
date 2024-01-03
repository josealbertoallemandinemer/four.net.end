internal class Program
{
    private static void Main(string[] args)
    {
        int[] matriz={1,2,3,4,5,6,7,8,9,10};

        ImprimirMatriz(matriz);

        double[,] matriz2d={{1,2},{3,4}};
    
        ImprimirMatrizMulti(matriz2d);



      var matrizz= new [] {1,2,3};
      var matrizzz= new [] {"carlos","alberto"};
      var matrix2d=new [,] { {2,3},{4,5} };

      var matrizJagged= new[]
      {
        new[]{12,23},
        new[]{15,30}
        
      };











    
    }

    static void ImprimirMatriz(int[] matrizPa)
    {

        int i;
        for ( i = 0; i < matrizPa.Length; i++)
        {
            Console.WriteLine(matrizPa[i]);
        }
    }

    static void ImprimirMatrizMulti(double[,] matriz2dPa)
    {

        int i;
        int j;

        for ( i = 0; i < matriz2dPa.GetLength(0); i++)
        {
             Console.WriteLine("fila {0}",i);

           for (j = 0; j < matriz2dPa.GetLength(1); j++)
           {
                 Console.WriteLine(matriz2dPa[i,j]);
           }
        }
    }
}