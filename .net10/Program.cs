internal class Program
{
    private static void Main(string[] args)
    {
        Random random=new Random();
        Console.WriteLine(random.Next(10));
   
   
     string nombreAr, apellidoAr,nip;

     Console.WriteLine("welcome to monsters inc.\n");
     Console.Write("nombre");
     nombreAr=Console.ReadLine();
     Console.Write("apellido");
     apellidoAr=Console.ReadLine();
     Console.Write("nip");
     nip=Console.ReadLine();

     Empleado empleado1=new Empleado(nombreAr,apellidoAr);
     empleado1.Nip=nip;

     Console.WriteLine(empleado1.ToString());

   
   
    }
}

class Empleado
{
   private string nombre,apellido,id,locker,banco,nip;


   public Empleado(string nombrePa, string apellidoPa)
   {
       nombre=nombrePa;
       apellido=apellidoPa;

       id= GenerarID();
       locker=GenerarLocker();
       banco=AsignaBanco();


   }

   Random random=new Random();


   public string Nip
   {

      set=>nip=value;

   }

   private string  GenerarID()
   {

    //Random random=new Random();
    int i,numero;
    string id= "";

    for ( i = 0; i < 10; i++)
    {
        numero=random.Next(10);

        id+=numero.ToString();
    }

    return id;
   }


 private string  GenerarLocker()
   {

    //Random random=new Random();
    int i,numero;
    string locker= "";

    for ( i = 0; i < 2; i++)
    {
        numero=random.Next(10);

        locker+=numero.ToString();
    }

    return locker;
   }


   private string AsignaBanco()
    {
       // Random random= new Random();

        int asignarBanco;
        string banco="";

        asignarBanco=random.Next(1,2);
        
        switch (asignarBanco)
        {
            
            case 1:
            banco="santander";
            break;


            case 2:
            banco="bbva";
            break;


        }
        return banco;



    }

   
 public override string ToString()
    {
        string mensaje="";

        mensaje= "empleado "+ nombre+" "+ apellido+ "\nnumero de empleado: "+id+"\nnumero de locker: "+locker+"\nnumero de banco: "+banco;
    
        return mensaje;
    }









}