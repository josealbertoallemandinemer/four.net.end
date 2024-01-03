// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Introducir una cadena de caracteres e indicar si es un palíndromo. Una palabra palíndroma es aquella que se lee igual adelante que atrás. Por ejemplo: ojo, rayar, solos, rapar, oso, rotomotor, sedes.

            string palabraUsuario, palabraInvertida = "";

            // Pedimos la palabra
            Console.Write("Ingresa una palabra y veamos si es un palíndromo: ");
            palabraUsuario = Console.ReadLine();

            foreach (char letra in palabraUsuario)
            {
                palabraInvertida = letra + palabraInvertida;
            }

            if(palabraUsuario.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{palabraUsuario}\" es una palabra palíndroma");
            }
            else
            {
                Console.WriteLine($"\"{palabraUsuario}\" No es una palabra palíndroma");
            }


//Variables necesarias
            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacimiento;

            //Pedimos la fecha de nacimiento
            Console.Write("Dime la fecha de tu nacimiento (día mes y año) y te diré que día de la semana era: ");
            cadenaFechaNacimiento = Console.ReadLine();

            //Convertimos la cadena en un objeto DateTime
            dateTimeFechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            //Aplicamos formato de fecha personalizado ("dddd") para mostrar el día de la semana
            Console.WriteLine($"Naciste un {dateTimeFechaNacimiento.ToString("dddd")}");