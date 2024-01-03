// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


 //Variables necesarias
            int opcion;
            string nombre;
            long numero;

            //Instanciamos a la colección
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                //Menú
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contactos");
                Console.WriteLine("5. Cambio numero");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if(contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encontrado!");

                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine("\n({0}) ha sido eliminado con exito", nombre);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach(KeyValuePair<string,long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;

                        case 5:
                        Console.WriteLine("Nuevo numero: \n");
                        nombre=Console.ReadLine();

                        if(contactos.ContainsKey(nombre))
                        {
                        numero=Convert.ToInt(Console.ReadLine());
                        contacto[nombre]=numero;


                        Console.WriteLine("\nInformacion guardada");
                        Console.WriteLine("{0: {1}}",nombre, contactos[nombre]);

                        Console.WriteLine("\nPresiona cualquier tecla para salir");
                        Console.ReadKey();
                        }else
                        {
                            Console.WriteLine("\nNo existe");
                        }
                        break;


                }

            } while (opcion >= 1 && opcion <= 5);