internal class Program
{
    private static void Main(string[] args)
    {
        //objet es como var pero es lioso

        int numGrande=500;
        byte numPequenio=(byte)numGrande;
        //hay que mirar tablas de cast, no todos se pueden
    //boxing
        int a=50;
        object obj=a;

        object num=5;
        object Res;

        Res=(int)num+10;

     EjemploGenerico<string> generico1=new EjemploGenerico<string>();
    

//

//string valorElemento;
Alumno valorElemento;
GuardaObjetos objetos1= new GuardaObjetos(3);
//GuardaObjetos<Alumno> objetos1= new GuardaObjetos<Alumno>(3);

Alumno alumno1= new Alumno(7);
Alumno alumno2= new Alumno(8);
Alumno alumno3= new Alumno(9);

 objetos1.AgregarElementos(alumno1);
 objetos1.AgregarElementos(alumno2);
 objetos1.AgregarElementos(alumno3);



// objetos1.AgregarElementos("luis");
 //objetos1.AgregarElementos("jose");
 //objetos1.AgregarElementos("dani");
 

//valorElemento=(string)objetos1.ObtenerElemento(2);
valorElemento=(Alumno)objetos1.ObtenerElemento(2);
//Console.WriteLine(valorElemento);
Console.WriteLine(valorElemento.Calificacion);













    }

}

class EjemploGenerico<T>
{

}

class GuardaObjetos  //<T> y en todos los object=T asi pilla de cualquier tipo
{
private int i=0;
private object[] matrizElementos;
//T[]

public GuardaObjetos(int elementosPa)
{
    matrizElementos=new object[elementosPa];
}

public void AgregarElementos(object elementoPa)

{

    matrizElementos[i]=elementoPa;
    i++;
}

public object ObtenerElemento(int elementoPa)

{
    return matrizElementos[elementoPa];
}




}


class Alumno
{
    double calificacion;

public Alumno(double calificacionPa)
{
    calificacion=calificacionPa;
}

public double Calificacion{
    get=>calificacion;
}



}