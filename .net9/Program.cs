internal class Program
{
    private static void Main(string[] args)
    {
        string nombreYApellido;

        Nombres nombres=new Nombres();

        nombreYApellido= nombres.Concatenar("mario", "gay");
        Console.WriteLine(nombreYApellido);
    }

   
}

 class Nombres
    {
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;
            nombreApellido=nombrePa+" "+ apellidoPa;
            return nombreApellido;
        }

        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {
            string nombreApellido;
            nombreApellido=nombrePa+" "+ apellidoPa+" "+apellido2Pa;
            return nombreApellido;
        }
        //se puede sobrecargar si se sigue
    }