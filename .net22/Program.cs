// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/// /////////////////


    Type tipoDeDatoStruct=typeoff(Libro);
    Type tipoDeDatoClass=typeoff(Biblioteca);



Console.WriteLine($"el nombre del tipo es {tipoDatoStruct.Name}");
Console.WriteLine($"el namespace del tipo es {tipoDatoStruct.Namespace}");

FieldInfo[] camposDatoStruct;//fieldinfo es de System.Reflection;

camposDatoStruct=tipoDatoStruct.GetFields(BindingFlags.NonPublics | BindingFlags.Instance);

Console.WriteLine("campos deltipo: \n");
foreach (FieldInfo elemento in camposDatoStruct)
{
    Console.WriteLine(elemento);//habria que hacerlos publicos abajo

}

Console.WriteLine("\n-------------------\n");
Console.WriteLine($"elnombre completo del tipo es:{tipoDatoClass.FullName}");

MethodInfo[] metodosDatoClass;
PropertyInfo[] propiedadesDatoClass;
propiedadesDatoClass=tipoDatoClass.GetProperties();

metodosDatoClass=tipoDatoClass.GetMethods();

Console.WriteLine("propiedades del tipo: \n");

foreach (PropertyInfo elemento in propiedadesDatoClass)
{
    Console.WriteLine(elemento);//habria que hacerlos publicos abajo

}

Console.WriteLine("metodos del tipo: \n");

foreach (MethodInfoInfo elemento in metodosDatoClass)
{
    Console.WriteLine(elemento);//habria que hacerlos publicos abajo

}









bool repetir=true;
string opcion;

Biblioteca biblioteca1= new Biblioteca();

do
{
    Console.WriteLine("\nBiblioteca\n");
    Console.WriteLine("1.Agregar libro");
    Console.WriteLine("2.Mostrar libro");
    Console.WriteLine("3.Busqueda libro");
    Console.WriteLine("4.Busqueda Parcial libro");
    Console.WriteLine("5.eliminar libro");
    Console.WriteLine("6.Salir");

    Console.Write("\nIngresar una opcion: ");
    opcion=Console.ReadLine();

    switch (opcion)
    {
        case "1":
        biblioteca1.AgragarLibro();
        break;

        case "2":
        biblioteca1.MostrarLibros();
        break;

        case "3":
        biblioteca1.BuscarLibro();
        break;

        case "4":
        biblioteca1.BusquedaParcial();
        break;

        case "5":
        biblioteca1.EliminarLibro();
        break;

        case "6":
        repetir=false;
        break;

        default:
        Console.WriteLine("\nOpcion invalida, intentalo otra vez");
        break;
        
    }


} while (repetir);















///////////////////


class Biblioteca
{
   Libro[] libros;          //struct llamado
   int cantidadLibros=0;
   string buscarLibro;
   bool libroEncontrado;
   int posicionLibroEliminar;

   public Biblioteca()          //constructor
   {
    libros=new Libro[1000];
   }

   public void AgragarLibro()
   {
    if (cantidadLibros<libros.Length)
    {
        Console.Clear();
        Console.WriteLine($"Ingresa informacion para el libro {cantidadLibros+1}\n");
        Console.WriteLine("nombre libro: ");
        libros[cantidadLibros].Titulo=Console.ReadLine();
        Console.WriteLine("autor: ");
        libros[cantidadLibros].Autor=Console.ReadLine();
        Console.WriteLine("ano: ");
        libros[cantidadLibros].Ano=Console.ReadLine();

        cantidadLibros++;
        Console.Clear();
        Console.WriteLine("libro agregado");

    } else
    {
        
        Console.WriteLine("libreria llena, elimine uno");
    }
   }

   public void MostrarLibros()
   {
       Console.Clear();

       if (cantidadLibros==0)
       {
        Console.WriteLine("biblioteca vacia");

       } else
       {
        for (int i = 0; i < cantidadLibros; i++)
        {
            Console.WriteLine($"{i+1}. Titulo={libros[i].Titulo}, autor={libros[i].Autor}, ano={libros[i].Ano}");
            Console.ReadKey();
            Console.WriteLine();

        }
       }
   }
    
    public void BuscarLibro()
    {
        Console.Clear();
        Console.WriteLine("ingresar nombre exacto del libro a buscar");
        buscarLibro=Console.ReadLine();
        libroEncontrado=false;

        for (int i =0; i < cantidadLibros; i++)
        {
            if (libros[i].Titulo.Equals(buscarLibro))
            {
                Console.WriteLine($"ellibro\"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\"se encuentra disponible en la biblioteca en el indice:{i+1}");
                libroEncontrado=true;
            
            }
        }
        if (!libroEncontrado)//==false
        {
            Console.WriteLine("libro no encontrado");
        }
    }


    public void BusquedaParcial()
    {
       Console.Clear();

       Console.WriteLine("busqueda con al menos una parte del titulo");
       buscarLibro=Console.ReadLine().ToLower();
       libroEncontrado=false;

       for (int i =0; i < cantidadLibros; i++)
        {
            if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
            {
                Console.WriteLine($"la palabra\"{buscarLibro}\" se encontro en\"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" en el indice:{i+1}");
                libroEncontrado=true;
            
            }
        }

        if (!libroEncontrado)//==false
        {
            Console.WriteLine("no encontrado");
        }

    }

    public void EliminarLibro()
    {
        Console.Clear();

        if (cantidadLibros==0)
        {
            Console.WriteLine("la biblioteca esta vacia!");

        }else
        {
            Console.Write($"ingresa que libro quieres eliminar (del 1 al {cantidadLibros}):");
            posicionLibroEliminar=Convert.ToInt32(Console.ReadLine())-1;

            if(posicionLibroEliminar>=0 && posicionLibroEliminar<cantidadLibros)
        
        {
           
           Console.WriteLine("el libro a eliminar es: {0} ? ", libros[posicionLibroEliminar].Titulo);
           string opcion=Console.ReadLine().ToLower();

           if (opcion=="si")
           {
            
              string tituloEliminado=libros[posicionLibroEliminar].Titulo;
              string autorEliminado=libros[posicionLibroEliminar].Autor;
          
            for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
            {
                libros[i]=libros[i+1];
            }
            cantidadLibros--;

             Console.WriteLine("ha sido eliminado el libro : {0}  ", libros[posicionLibroEliminar].Titulo);

           }else
           {
            Console.WriteLine("operacion cancelada");
           }

        }else
        {
            Console.WriteLine("el n no es valido");
        }
        
        
        
        }


    }

}

struct Libro
{
   string titulo;
   string autor;
   string ano;

   public string Titulo {get=>titulo;set=>titulo=value;}
   public string Autor {get=>autor;set=>autor=value;}
   public string Ano {get=>ano;set=>ano=value;}


}