using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        bool a;
        Automovil automovil1 = new Automovil();

        automovil1.color= "rojo";
        automovil1.combustible="diesel";
        Console.WriteLine("combustible es {0}", automovil1.combustible);
    
        a=automovil1.Acelerar();
    
        if (a)
        {
            Console.WriteLine("acelero");
        }


      Console.WriteLine(automovil1.ToString());


      //Console.WriteLine(automovil1.asientos); protegido por private




    
    }
}

public class Automovil
{
    //campos
    public string color, modelo,combustible;
    public byte anio, numeroDePuertas;
    public int ccMotor;

    private string  asientos, colorTablero;
    private bool camaraTrasera;

    public Automovil(){

         asientos="piel";
         colorTablero="cafe";
         camaraTrasera=false;
    }

    //metodos

    public bool Acelerar()
    {
        bool acelerar=true;
        Console.WriteLine("acelerar");
        Prueba();//no se puede poner en main por ser static a no ser que Automovil.Prueba();
        return acelerar;
    }


    public bool Frenar()
    {
        bool frenar=true;
        Console.WriteLine("frenar");
        return frenar;
    }


    public void Velocidades(ref byte velocidadPa)

{
  velocidadPa++;
  Console.WriteLine("cambio de velocidad");



}

public static void Prueba()
{
    Console.WriteLine("soy un metodo estatico");

}
//aqui
//si color fuera privado arriba, habria que hacer otro campo aqui con: public string Color{ get{return color;}} y en main se usaria asi: automovil.Color este es solo de lectura el ser get
// si ademas combustible fuera privado: public string Combustible{ set{combustible=value} get{return combustible} o get=>combustible y set=>combustible=value} ======en main: automovil.Combustible="diesel"; console.writeline(automovil.Combustible);



//invalidar metodo string y lo convertimos en esto

public override string ToString()
{
    string mensaje;
    mensaje="\nel color es:"+color+"\nasientos"+asientos;
    return mensaje;

    //podemos enviar y recoger desde aqui todo lo que se quiera
}





}