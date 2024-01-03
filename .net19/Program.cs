// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string nombreUsuario, opcion, contrasena;

(bool contrasenaValida, string mensajeError) verificarContrasena;


Console.WriteLine("\t\tregistro\n\n");

Console.WriteLine("ingrese n d usuario: ");
nombreUsuario=Console.ReadLine();

Console.WriteLine("genero contrasena?(si/no):");
opcion=Console.ReadLine();

opcion=opcion.ToLower();

switch (opcion)
{
    case"si":

    Contrasena contrasena1= new Contrasena();

    contrasena=contrasena1.GenerarContrasena();

    Console.WriteLine($"guarda tu nontrasena {contrasena}");
    
    Console.WriteLine("Preciona cualquier tecla para terminar");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine($"tus datos son:\n\tusuario:{nombreusuario}\n\tcontrasena:{contrasena} {contrasena}");


    break;

    case "no":

 Console.WriteLine("\ncrea contrasena segura con las reglas");
 contrasena=Console.ReadLine();

 Contrasena contrasena2=new Contrasena();

 verificarContrasena=contrasena2.ComprobarContrasena(contrasena);

 if (verificarContrasena.contrasenaValida)
 {
    Console.WriteLine("Preciona cualquier tecla para terminar");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine($"tus datos son:\n\tusuario:{nombreUsuario}\n\tcontrasena: {contrasena}");


 }else
 {
    Console.WriteLine(verificarContrasena.mensajeError+"ingresa valida");
 }




    break;

















}








class Contrasena
{
    string numeros="0123456789";
    string letrasMin="abcdefghijklmnopqrstuvwxyz";
    string letrasMay="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string caracterEspecial="$%#&!?";

    int numContiene=0, minContiene=0,mayContiene=0,espContiene=0;

    public string GenerarContrasena()
    {
        //string contrasenaGenerada="";
        StringBuilder contrasenaGenerada=new StringBuilder();
        
        Random random= new Random();
        
        int longitudContrasena=random.Next(8,21);


        double numTener= longitudContrasena * .15;
        double minTener= longitudContrasena * .35;
        double mayTener= longitudContrasena * .35;
        double espTener= longitudContrasena * .15;
    


        char caracterEscogido;

        while (contrasenaGenerada.Length<longitudContrasena)
        {
            switch (random.Next(0,4))
            {
                case 0:
                if (numContiene<numTener)
                {
                    caracterEscogido=numeros[random.Next(numeros.Length)];
                    //contrasenaGenerada+=caracterEscogido;
                    contrasenaGenerada.Append(caracterEscogido);
                    numContiene++;
                }
                break;

                case 1:
                if (minContiene<minTener)
                {
                    caracterEscogido=letrasMin[random.Next(letrasMin.Length)];
                    //contrasenaGenerada+=caracterEscogido;
                    contrasenaGenerada.Append(caracterEscogido);
                    minContiene++;
                }
                break;

                case 2:
                if (mayContiene<mayTener)
                {
                    caracterEscogido=letrasMay[random.Next(letrasMay.Length)];
                    //contrasenaGenerada+=caracterEscogido;
                    contrasenaGenerada.Append(caracterEscogido);
                    mayContiene++;
                }
                break;

                case 3:
                if (espContiene<espTener)
                {
                    caracterEscogido=letrasMin[random.Next(caracterEspecial.Length)];
                    //contrasenaGenerada+=caracterEscogido;
                    contrasenaGenerada.Append(caracterEscogido);
                    espContieneContiene++;
                }
                break;


                
                
            }
        }

        //return contrasenaGenerada;
        return contrasenaGenerada.ToString();

    }


    public(bool,string) ComprobarContrasena(string contrasenaPa)
    {
         bool contrasenaValida=false;

         bool hayNumero=false, hayMinuscula=false,hayMayuscula=false,hayEspecial=false;

         string mensajeError="";

         if (contrasenaPa.Length>=8 && contrasenaPa.Length<=20)
         {
            foreach ( char  elemento in numeros)
            {
                if (contrasenaPa.IndexOff(elemento)>=0)
                {
                    hayNumero=true;
                    break;
                }else{
                    hayNumero=false;
                    mensajeError="debe contener un numero";

                }

                if (hayNumero)
                {
                    foreach ( char  elemento in letrasMin)
            {
                if (contrasenaPa.IndexOff(elemento)>=0)
                {
                    hayMinuscula=true;
                    break;
                }else{
                    hayMinuscula=false;
                    mensajeError="debe contener una letra minuscula";
                    
                }
                    
                  

                }

                if (hayMinuscula)
                {
                    foreach ( char  elemento in letrasMay)
            {
                if (contrasenaPa.IndexOff(elemento)>=0)
                {
                    hayMayuscula=true;
                    break;
                }else{
                    hayMayuscula=false;
                    mensajeError="debe contener una letra mayuscula";

                }
                }

                if (hayMayuscula)
                {
                    foreach ( char  elemento in caracterEspecial)
            {
                if (contrasenaPa.IndexOff(elemento)>=0)
                {
                    hayEspecial=true;
                    break;
                }else{
                    hayEspecial=false;
                    mensajeError="debe contener un caracter especial";

                }
                }
                }

                
if (hayEspecial && hayMayuscula && hayMinuscula && hayNumero)
{
    contrasenaValida=true;
}else
{
    contrasenaValida=false;
}


            }
           



         }else
         {
            mensajeError="la contrasena debe tener 8-20 caracteres";
            contrasenaValida=false;

         }

         return(contrasenaValida,mensajeError);


    }


         }

    }
}