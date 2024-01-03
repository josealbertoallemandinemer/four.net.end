// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string nombreJugador1, nombreJugador2;
int primerTurno;

Console.WriteLine("escoge tu nombre jugador 1: ");
nombreJugador1=Console.ReadLine();
Jugador jugador1=new Jugador(nombreJugador1,1000);

jugador1.EscogerPersonaje();
jugador1.EscogerArma();

Console.WriteLine("escoge tu nombre jugador 2: ");
nombreJugador2=Console.ReadLine();
Jugador jugador2=new Jugador(nombreJugador2,1000);

jugador2.EscogerPersonaje();
jugador2.EscogerArma();

primerTurno= Batalla.TirarDados();

if(primerTurno==1)
{
    Console.WriteLine($"{jugador1.Nombre} empieza primero\n");

    Batalla.SimularBatalla(jugador1,jugador2);
}else
{
    Console.WriteLine($"{jugador2.Nombre} empieza primero\n"); //aqui se meteria a jugador2 en jugador1
    Batalla.SimularBatalla(jugador2,jugador1);
}







enum TipoPersonaje{Escudero,Arquero,Caballero}

enum TipoArma{Espada,Arco,Martillo}

class Jugador
{
    string nombre;
    int salud;
    int ataque;
    int defensa;
    TipoPersonaje personajeEscogido;
    TipoArma armaEquipada;

    Random random= new Random();

    public string Nombre { get => nombre; set => nombre = value; }
    public int Salud { get => salud; set => salud = value; }
    public int Ataque { get => ataque; set => ataque = value; }
    public int Defensa { get => defensa; set => defensa = value; }
    internal TipoPersonaje PersonajeEscogido { get => personajeEscogido; set => personajeEscogido = value; }
    internal TipoArma ArmaEquipada { get => armaEquipada; set => armaEquipada = value; }

public Jugador(string nombrePa, int saludPa)
{
    nombre=nombrePa;
    salud=saludPa;
}

public void EscogerPersonaje()
{
    int opcion;

    Console.Clear();

    do
    {
        Console.WriteLine("1.escudero");
        
        Console.WriteLine("2.arquero");
        
        Console.WriteLine("3.caballero");
        
        Console.WriteLine($"{Nombre} escoge");
        opcion=Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
            personajeEscogido=TipoPersonaje.Escudero;
            ResumenPersonajeEscogido();
            break;
            case 2:
            personajeEscogido=TipoPersonaje.Arquero;
            ResumenPersonajeEscogido();
            break;
            case 3:
            personajeEscogido=TipoPersonaje.Caballero;
            ResumenPersonajeEscogido();
            break;

            default:
            Console.WriteLine("intentalo otra vez");
            
            break;
        }


    } while (opcion < 1 || opcion > 3);
}

public void ResumenPersonajeEscogido()
{
Console.WriteLine($"{Nombre}, ahora eres \"{PersonajeEscogido}\"");
Console.WriteLine($"preciona cualquier tecla para termnar");
Console.ReadKey();
Console.Clear();

}

public void EscogerArma()
{
  int opcion;
  Console.Clear();

  do
    {
        Console.WriteLine("1.espada");
        
        Console.WriteLine("2.arco");
        
        Console.WriteLine("3.martllo");
        
        Console.WriteLine($"{Nombre} escoge");
        opcion=Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
            ArmaEquipada=TipoArma.Espada;
            ValoresAtaqueDefensaArma();
            ResumenArmaEscogida();
            break;
            case 2:
            ArmaEquipada=TipoArma.Arco;
            ValoresAtaqueDefensaArma();
            ResumenArmaEscogida();
            
            break;
            case 3:
            ArmaEquipada=TipoArma.Martillo;
            ValoresAtaqueDefensaArma();
            ResumenArmaEscogida();
            
            break;

            default:
            Console.WriteLine("intentalo otra vez");
            
            break;
        }


    } while (opcion < 1 || opcion > 3);
}

public void ValoresAtaqueDefensaArma()
{
    switch (ArmaEquipada)
    {
        case TipoArma.Espada:
        Ataque=130;
        Defensa=40;
        break;
        case TipoArma.Arco:
        Ataque=140;
        Defensa=30;
        break;
        case TipoArma.Martillo:
        Ataque=150;
        Defensa=20;
        break;
        
    }
}

public void ResumenArmaEscogida()
{

Console.WriteLine($"{Nombre}, escogiste \"{ArmaEquipada}\"\n con un nivel de ataque de [{Ataque}] y defensa de [{Defensa}]");
Console.WriteLine($"preciona cualquier tecla para termnar");
Console.ReadKey();
Console.Clear();



}

public void Atacar()
{
  Console.WriteLine($"\n{PersonajeEscogido} {Nombre}, ataca con  su {ArmaEquipada}\n ");

}

public void Defender()
{
   Console.WriteLine($"\n{PersonajeEscogido} {Nombre}, se defende con  su {ArmaEquipada}\n ");
    
}

public void EscogerAtacarDefender()
{
   int opcion;
   
   do
    {
        Console.WriteLine("1.atacar");
        
        Console.WriteLine("2.defender");
        
       
        
        Console.WriteLine($"{PersonajeEscogido} {Nombre} escoge");
        opcion=Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
            Atacar();
            break;

            case 2:
            Defender();
            
            break;

            default:
            Console.WriteLine("intentalo otra vez");
            
            break;
        }


    } while (opcion < 1 || opcion > 2);

    
}

public void ResumenJugador()
{
    Console.WriteLine($"[{PersonajeEscogido} {Nombre}] salud={Salud}/[{ArmaEquipada}] ataque={Ataque}, defensa={Defensa}");

}

public void CalcularDano(int ataqueOtroJugadorPa)
{
    int danoRecibido;
    int ataqueSorpresa=random.Next(-15,16);

     danoRecibido= ataqueOtroJugadorPa-Defensa+ataqueSorpresa;

     Salud-=danoRecibido;

     



}

class Batalla
{

    static Random random=new Random();
    public static int TirarDados()
    {
               Console.WriteLine("presiona cualquier tecla para tirar los dados y ver quien empieza..");
               Console.ReadKey();
               Console.Clear();

               int primerTurno;
               primerTurno=random.Next(1,3);

               return primerTurno;



    }

    public static void SimularBatalla(Jugador jugador1pA, Jugador jugador2pA )
    {

        int ronda=1;
        Console.WriteLine("la batalla comienza");
        Console.WriteLine("Ronda {ronda}\n");

        jugador1pA.ResumenJugador();
        jugador2pA.ResumenJugador();

        Console.WriteLine($"\n{jugador1Pa.PersonajeEscogido}{jugador1Pa.Nombre}, empieza ataque");
        Console.WriteLine($"presina enter para usar tu {jugador1Pa.ArmaEquipada}...");
        Console.ReadKey();
        jugador1pA.Atacar();

        jugador2pA.CalcularDano(jugador1pA.Ataque);

        jugador2pA.EscogerAtacarDefender();

        jugador1pA.CalcularDano(jugador2pA.Ataque);


        for (ronda  = 2; ronda <= 5; ronda++)
        {
            Console.WriteLine($"ronda {ronda}\n");
            jugador1pA.ResumenJugador();
            jugador2pA.ResumenJugador();

            jugador1pA.EscogerAtacarDefender();
            jugador2pA.CalcularDano(jugador1pA.ataque);

            jugador2pA.EscogerAtacarDefender();
            jugador1pA.CalcularDano(jugador2pA.ataque);

            Console.WriteLine();
        }

Console.WriteLine("termino");

jugador1pA.ResumenJugador();
jugador2pA.ResumenJugador();

if (jugador1pA.Salud>jugador2pA.Salud)
{
    Console.WriteLine($"\n{jugador1Pa.Nombre} ha ganado");
}else
{
    Console.WriteLine($"\n{jugador2Pa.Nombre} ha ganado");
}




    }
}

}



///siguiente ejer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool repetir = true; //Se encarga de repetir el menú hasta que nosotros decidamos salir del programa
            int opcion;

            Inventario inventario = new Inventario();

            do
            {
                Console.Clear();

                Console.WriteLine("\nMundo Celular\n");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar inventario");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Salir");

                Console.Write("Ingresar una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inventario.AgregarProducto();
                        break;
                    case 2:
                        // Mostrar inventario
                        inventario.MostrarProductos();
                        break;
                    case 3:
                        inventario.EliminarProducto();
                        break;
                    case 4:  // Finalizar el programa
                        repetir = false; //El bucle se repite mientras "repetir == true", por lo tanto, esta instrucción nos sacará del programa
                        break;
                    default:
                        Console.WriteLine("\n¡Opción invalida, intenta de nuevo!\n");
                        break;
                }
            } while (repetir);
        }
    }

    struct Celular
    {
        // Campos
        string marca;
        string modelo;
        int memoriaPrincipal;
        double precio;
        int stock;

        // Propiedades
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int MemoriaPrincipal { get => memoriaPrincipal; set => memoriaPrincipal = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }

    class Inventario
    {
        // Crea una lista de productos para almacenar el inventario
        List<Celular> listaCelulares = new List<Celular>();

        public void AgregarProducto()
        {
            // Creamos un producto (objeto) de tipo Celular
            Celular nuevoProducto = new Celular();

            // Limpiamos consola y colocamos un título
            Console.Clear();
            Console.WriteLine("\n\t\tAgregar producto\n");

            // Preguntamos los valores que tendrá el producto y se los asignamos
            Console.Write("Marca: ");
            nuevoProducto.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            nuevoProducto.Modelo = Console.ReadLine();

            Console.Write("Memoria: ");
            nuevoProducto.MemoriaPrincipal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio: $");
            nuevoProducto.Precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock: ");
            nuevoProducto.Stock = Convert.ToInt32(Console.ReadLine());

            // Agregamos el producto "Celular" al inventario (List)
            listaCelulares.Add(nuevoProducto);

            Console.Write("Producto agregado al inventario. Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarProductos()
        {
            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("¡El inventario está vacío!");
            }
            else
            {
                int indice = 1;
                Console.WriteLine("Inventario de productos:\n");

                foreach (Celular elemento in listaCelulares)
                {
                    Console.WriteLine($"{indice}.- Marca: {elemento.Marca}, Modelo: {elemento.Modelo}, Memoria: {elemento.MemoriaPrincipal}, Precio: ${elemento.Precio}, Stock: {elemento.Stock},");
                    indice++;
                }
            }

            Console.Write("\nPresiona cualquier tecla para continuar... ");
            Console.ReadKey();
        }

        public void EliminarProducto()
        {
            // Variable para indicar el índice del producto a eliminar
            int productoEliminar;

            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("¡El inventario está vacío, no hay nada que eliminar!");
            }
            else
            {
                Console.Write($"Ingresa el número de producto (indice) que deseas eliminar (del 1 al {listaCelulares.Count}): ");
                productoEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //Decimos que es -1 para que el índice ingresado coincida con el indice real de la List

                // Verificamos que el número ingresado sea válido
                if (productoEliminar >= 0 && productoEliminar < listaCelulares.Count)
                {
                    //Confirmamos si el producto ingresado es el que se desea eliminar
                    Console.Write($"¿El producto que deseas eliminar es: \"{listaCelulares[productoEliminar].Marca} {listaCelulares[productoEliminar].Modelo}\"? (Sí/No): ");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cuál fue el libro eliminado
                        string marcaEliminado = listaCelulares[productoEliminar].Marca;
                        string modeloEliminado = listaCelulares[productoEliminar].Modelo;

                        // Eliminamos el producto
                        listaCelulares.RemoveAt(productoEliminar);

                        // Le mostramos al usuario el libro que se eliminó
                        Console.WriteLine($"\n¡El producto \"{marcaEliminado} {modeloEliminado}\" fue eliminado!");
                    }
                    else
                    {
                        Console.WriteLine("Operación \"eliminar producto\" cancelada");
                    }
                }
                else
                {
                    Console.WriteLine("¡El número de producto no es válido, revisa la lista e intenta nuevamente!");
                }
            }

            Console.Write("\nPresiona cualquier tecla para continuar... ");
            Console.ReadKey();
        }
    }
}




/// siguiente ejercicio

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a la clase CompraBoletos
            CompraBoletos compraBoletos = new CompraBoletos();
            compraBoletos.Reservacion();

        }
    }

    // Definimos una estructura para representar la información del cliente
    struct Cliente
    {
        // Campos
        string nombre;
        string apellido;
        string id;
        int edad;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }
    }

    enum Destinos
    {
        Guadalajara = 900,
        Monterrey = 1000,
        LosAngeles = 1700
    }

    enum Horarios
    {
        Siete_AM = 7,
        Tres_PM = 15,
        Ocho_PM = 20
    }

    enum SeccionAvion
    {
        Atras = 0,
        Centro = 50,
        Adelante = 80
    }

    enum TipoAsiento
    {
        Medio = 20,
        Pasillo = 60,
        Ventana = 90
    }

    class CompraBoletos
    {
        // Campos
        Destinos destinoEscogido;
        Horarios horarioEscogido;
        SeccionAvion seccionEscogida;
        TipoAsiento asientoEscogido;

        int precioBase;
        int precioSeccion;
        int precioAsiento;
        int precioFinal;

        public void Reservacion()
        {
            // Mensaje de bienvenida
            Console.WriteLine("\n\t\tBienvenido a la reserva de vuelos\n");

            //Creamos un objeto cliente para poder guardar su información
            Cliente cliente = new Cliente();

            // Pedimos información del cliente
            Console.WriteLine("Ingrese la información que se le pide a continuación\n");

            Console.Write("Nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            cliente.Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de identificación oficial: ");
            cliente.Id = Console.ReadLine();

            // Mandamos a llamar a los métodos
            SeleccionarDestino();
            SeleccionarHorario();
            SeleccionarSeccion();
            SeleccionarAsiento();
            ResumenReservacion(cliente);
        }

        public void SeleccionarDestino()
        {
            // Variables
            int opcionDestino;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nDestinos disponibles:\n");

            foreach (Destinos elemento in Enum.GetValues(typeof(Destinos)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");
            }

            Console.Write("Seleccione un destino (número): ");
            opcionDestino = Convert.ToInt32(Console.ReadLine());

            switch (opcionDestino)
            {
                case 1:
                    destinoEscogido = Destinos.Guadalajara;
                    precioBase = (int)destinoEscogido;
                    break;
                case 2:
                    destinoEscogido = Destinos.Monterrey;
                    precioBase = (int)destinoEscogido;
                    break;
                case 3:
                    destinoEscogido = Destinos.LosAngeles;
                    precioBase = (int)destinoEscogido;
                    break;
                default:
                    Console.WriteLine("Destino no válido");
                    break;
            }
        }

        public void SeleccionarHorario()
        {
            // Variables
            int opcionHorario;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nHorarios disponibles:\n");

            foreach (Horarios elemento in Enum.GetValues(typeof(Horarios)))
            {
                Console.WriteLine($"{indice++}. {(int)elemento}:00");
            }

            Console.Write("Seleccione un horario (número): ");
            opcionHorario = Convert.ToInt32(Console.ReadLine());

            switch (opcionHorario)
            {
                case 1:
                    horarioEscogido = Horarios.Siete_AM;
                    break;
                case 2:
                    horarioEscogido = Horarios.Tres_PM;
                    break;
                case 3:
                    horarioEscogido = Horarios.Ocho_PM;
                    break;
                default:
                    Console.WriteLine("Horario no válido");
                    break;
            }
        }

        public void SeleccionarSeccion()
        {
            // Variables
            int opcionSeccion;
            int indice = 1;

            // Mostramos las secciones disponibles
            Console.WriteLine("\nSecciones disponibles:\n");

            foreach (SeccionAvion elemento in Enum.GetValues(typeof(SeccionAvion)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");
            }

            Console.Write("Seleccione la sección de su preferencia (número): ");
            opcionSeccion = Convert.ToInt32(Console.ReadLine());

            switch (opcionSeccion)
            {
                case 1:
                    seccionEscogida = SeccionAvion.Atras;
                    precioSeccion = (int)seccionEscogida;
                    break;
                case 2:
                    seccionEscogida = SeccionAvion.Centro;
                    precioSeccion = (int)seccionEscogida;
                    break;
                case 3:
                    seccionEscogida = SeccionAvion.Adelante;
                    precioSeccion = (int)seccionEscogida;
                    break;
                default:
                    Console.WriteLine("Sección no válida");
                    break;
            }
        }

        public void SeleccionarAsiento()
        {
            // Variables
            int opcionAsiento;
            int indice = 1;

            // Mostramos las secciones disponibles
            Console.WriteLine("\nAsientos disponibles:\n");

            foreach (TipoAsiento elemento in Enum.GetValues(typeof(TipoAsiento)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");
            }

            Console.Write("Seleccione el tipo de asiento de su preferencia (número): ");
            opcionAsiento = Convert.ToInt32(Console.ReadLine());

            switch (opcionAsiento)
            {
                case 1:
                    asientoEscogido = TipoAsiento.Medio;
                    precioAsiento = (int)asientoEscogido;
                    break;
                case 2:
                    asientoEscogido = TipoAsiento.Pasillo;
                    precioAsiento = (int)asientoEscogido;
                    break;
                case 3:
                    asientoEscogido = TipoAsiento.Ventana;
                    precioAsiento = (int)asientoEscogido;
                    break;
                default:
                    Console.WriteLine("Asiento no válido");
                    break;
            }
        }

        public void ResumenReservacion(Cliente cliente)
        {
            // Limpiamos la consola para mostrar el resumen
            Console.Clear();

            // Mostramos un resumen de la reserva
            Console.WriteLine("Resumen de la reserva:\n");

            Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellido}");
            Console.WriteLine($"Edad: {cliente.Edad}");
            Console.WriteLine($"Número de identificación oficial: {cliente.Id}");
            Console.WriteLine($"Destino: {destinoEscogido} - ${(int)destinoEscogido}");
            Console.WriteLine($"Horario: {(int)horarioEscogido}:00");
            Console.WriteLine($"Sección: {seccionEscogida} - ${(int)seccionEscogida}");
            Console.WriteLine($"Asiento: {asientoEscogido} - ${(int)asientoEscogido}");
            Console.WriteLine($"Precio Total: ${precioFinal = precioBase + precioSeccion + precioAsiento}");

            // Pedimos confirmación al usuario
            Console.Write("\nConfirme su reserva (Presione cualquier tecla para confirmar): ");
            Console.ReadKey();
        }
    }
}