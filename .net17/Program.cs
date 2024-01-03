// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int opcion;
float gasto;

Stck<float> gastos = new Stack<float>();

do{
    Console.Clear();
    Console.WriteLine("1.agregar gasto");
    Console.WriteLine("2. mostrar");
    Console.WriteLine("3.pago para no generar intereses");

    Console.WriteLine("choose");
    opcion=Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
        Console.Write("Monto: $");
        gasto= Conver.Single(Console.ReadLine());

        gastos.Push(gasto);
        break;

        case 2:
        Console.WriteLine("gastos del mes:\n")

        foreach (float elemento in gastos)
        {
            Console.WriteLine("{0}",elemento);

        }

        Console.WriteLine("\nPresiona cualquier tecla");
        Console.ReadKey();
        break;

        case 3:
        
        float total=0;

        foreach (float elemento in gastos)
        {
           total+=elemento;

        }


        Console.WriteLine("pago para no generar intereses ${0}",total);
        Console.WriteLine("\nPresiona cualquier tecal para continuar");
        Console.ReadKey();
        break;

        
        
    }


} while (opcion>=1 && opcion<=3);
