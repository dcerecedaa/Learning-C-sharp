using System;

namespace ProyectoCita
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user if they want to enter the application.
            Console.WriteLine("¿Quieres entrar en la aplicación?");
            string respuesta = Console.ReadLine().ToLower();

            // Continue execution until the user types "no".
            while (respuesta != "no")
            {
                // Prompt the user to enter their name.
                Console.WriteLine("\nIntroduce tu nombre por favor: ");
                string nombre = Console.ReadLine();

                // Greet the user by name and display the available appointment days.
                Console.WriteLine($"\n**************** Bienvenido a la aplicación {nombre} ****************");
                Console.WriteLine("Elige un dia para pedir cita");
                Console.WriteLine(" 1. Lunes\n 2. Martes\n 3. Miercoles\n 4. Jueves\n 5. Viernes\n 6. Sabado\n 7. Domingo\n");

                // Parse the day selection from the user.
                int opcionCita = Int32.Parse(Console.ReadLine());

                // Process the appointment day based on the user's selection.
                switch (opcionCita)
                {
                    // LUNES (Monday)
                    case 1:
                        // Inform the user of the available times for Monday.
                        Console.WriteLine("Has elegido el Lunes, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 11:30\n 2. 12:00\n 3. 12:30\n 4. 13:00\n 5. 16:30\n 6. 17:30\n 7. 19:30\n 8. 20:00\n");
                        // Parse the selected time option.
                        int horaLunes = Int32.Parse(Console.ReadLine());

                        // Process the appointment time for Monday based on the user's selection.
                        switch (horaLunes)
                        {
                            case 1:
                                // Handle the appointment at 11:30.
                                Console.WriteLine("Has elegido la hora 11:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesPrimero = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle the appointment at 12:00.
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesSegundo = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                // pelo = hair, barba = beard, pelo y barba = hair and beard
                                if (servicioLunesSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle the appointment at 12:30.
                                Console.WriteLine("Has elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesTercero = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle the appointment at 13:00.
                                Console.WriteLine("Has elegido la hora 13:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesCuarto = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle the appointment at 16:30.
                                Console.WriteLine("Has elegido la hora 16:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesQuinto = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle the appointment at 17:30.
                                Console.WriteLine("Hs elegido la hora 17:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesSexto = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle the appointment at 19:30.
                                Console.WriteLine("Has elegido la hora 19:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesSeptimo = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle the appointment at 20:00.
                                Console.WriteLine("Has elegido la hora 20:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioLunesOctavo = Console.ReadLine().ToLower();

                                // Determine the service and display the corresponding price.
                                if (servicioLunesOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioLunesOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioLunesOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Notify the user of an invalid service option.
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Handle any invalid time selection.
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Tuesday appointments
                    case 2:
                        // Display available times for Tuesday
                        Console.WriteLine("Has elegido el Martes, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 12:00\n 2. 12:30\n 3. 13:00\n 4. 16:00\n 5. 16:30\n 6. 17:30\n 7. 19:30\n 8. 20:00\n");
                        // Read and parse the selected time slot for Tuesday
                        int horaMartes = Int32.Parse(Console.ReadLine());

                        // Evaluate the chosen time slot for Tuesday
                        switch (horaMartes)
                        {
                            case 1:
                                // Handle Tuesday appointment at 12:00
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesPrimero = Console.ReadLine().ToLower();

                                // Determine service type and display corresponding price
                                // pelo = hair, barba = beard, pelo y barba = hair and beard
                                if (servicioMartesPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Invalid service option feedback
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle Tuesday appointment at 12:30
                                Console.WriteLine("Has elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesSegundo = Console.ReadLine().ToLower();

                                if (servicioMartesSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle Tuesday appointment at 13:00
                                Console.WriteLine("Has elegido la hora 13:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesTercero = Console.ReadLine().ToLower();

                                if (servicioMartesTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle Tuesday appointment at 16:00
                                Console.WriteLine("Has elegido la hora 16:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesCuarto = Console.ReadLine().ToLower();

                                if (servicioMartesCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle Tuesday appointment at 16:30
                                Console.WriteLine("Has elegido la hora 16:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesQuinto = Console.ReadLine().ToLower();

                                if (servicioMartesQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle Tuesday appointment at 17:30
                                Console.WriteLine("Hs elegido la hora 17:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesSexto = Console.ReadLine().ToLower();

                                if (servicioMartesSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle Tuesday appointment at 19:30
                                Console.WriteLine("Has elegido la hora 19:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesSeptimo = Console.ReadLine().ToLower();

                                if (servicioMartesSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle Tuesday appointment at 20:00
                                Console.WriteLine("Has elegido la hora 20:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMartesOctavo = Console.ReadLine().ToLower();

                                if (servicioMartesOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMartesOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMartesOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Feedback for an invalid time slot selection
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Wednesday appointments
                    case 3:
                        // Display available times for Wednesday
                        Console.WriteLine("Has elegido el Miercoles, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 11:00\n 2. 12:00\n 3. 13:00\n 4. 13:30\n 5. 17:30\n 6. 18:30\n 7. 19:30\n 8. 20:00\n");
                        // Read and parse the selected time slot for Wednesday
                        int horaMiercoles = Int32.Parse(Console.ReadLine());

                        // Evaluate the chosen time slot for Wednesday
                        switch (horaMiercoles)
                        {
                            case 1:
                                // Handle Wednesday appointment at 11:00
                                Console.WriteLine("Has elegido la hora 11:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesPrimero = Console.ReadLine().ToLower();

                                // pelo = hair, barba = beard, pelo y barba = hair and beard
                                if (servicioMiercolesPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle Wednesday appointment at 12:00
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesSegundo = Console.ReadLine().ToLower();

                                if (servicioMiercolesSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle Wednesday appointment at 13:00
                                Console.WriteLine("Has elegido la hora 13:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesTercero = Console.ReadLine().ToLower();

                                if (servicioMiercolesTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle Wednesday appointment at 13:30
                                Console.WriteLine("Has elegido la hora 13:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesCuarto = Console.ReadLine().ToLower();

                                if (servicioMiercolesCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle Wednesday appointment at 17:30
                                Console.WriteLine("Has elegido la hora 17:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesQuinto = Console.ReadLine().ToLower();

                                if (servicioMiercolesQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle Wednesday appointment at 18:30
                                Console.WriteLine("Hs elegido la hora 18:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesSexto = Console.ReadLine().ToLower();

                                if (servicioMiercolesSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle Wednesday appointment at 19:30
                                Console.WriteLine("Has elegido la hora 19:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesSeptimo = Console.ReadLine().ToLower();

                                if (servicioMiercolesSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle Wednesday appointment at 20:00
                                Console.WriteLine("Has elegido la hora 20:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioMiercolesOctavo = Console.ReadLine().ToLower();

                                if (servicioMiercolesOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioMiercolesOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioMiercolesOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Feedback for an invalid time slot selection
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Thursday appointments
                    case 4:
                        // Display available times for Thursday
                        Console.WriteLine("Has elegido el Jueves, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 10:30\n 2. 12:00\n 3. 12:30\n 4. 13:30\n 5. 16:00\n 6. 18:30\n 7. 19:30\n 8. 20:30\n");
                        // Read and parse the selected time slot for Thursday
                        int horaJueves = Int32.Parse(Console.ReadLine());

                        // Evaluate the chosen time slot for Thursday
                        switch (horaJueves)
                        {
                            case 1:
                                // Handle Thursday appointment at 10:30
                                Console.WriteLine("Has elegido la hora 10:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesPrimero = Console.ReadLine().ToLower();

                                // Determine service type and display corresponding price
                                // pelo = hair, barba = beard, pelo y barba = hair and beard
                                if (servicioJuevesPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Provide feedback for an invalid service option
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle Thursday appointment at 12:00
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesSegundo = Console.ReadLine().ToLower();

                                if (servicioJuevesSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle Thursday appointment at 12:30
                                Console.WriteLine("Has elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesTercero = Console.ReadLine().ToLower();

                                if (servicioJuevesTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle Thursday appointment at 13:30
                                Console.WriteLine("Has elegido la hora 13:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesCuarto = Console.ReadLine().ToLower();

                                if (servicioJuevesCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle Thursday appointment at 16:00
                                Console.WriteLine("Has elegido la hora 16:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesQuinto = Console.ReadLine().ToLower();

                                if (servicioJuevesQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle Thursday appointment at 18:30
                                Console.WriteLine("Hs elegido la hora 18:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesSexto = Console.ReadLine().ToLower();

                                if (servicioJuevesSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle Thursday appointment at 19:30
                                Console.WriteLine("Has elegido la hora 19:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesSeptimo = Console.ReadLine().ToLower();

                                if (servicioJuevesSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle Thursday appointment at 20:30
                                Console.WriteLine("Has elegido la hora 20:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioJuevesOctavo = Console.ReadLine().ToLower();

                                if (servicioJuevesOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioJuevesOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioJuevesOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Provide feedback for an invalid time slot selection
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Friday appointments
                    case 5:
                        // Display available times for Friday
                        Console.WriteLine("Has elegido el Viernes, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 11:00\n 2. 11:30\n 3. 12:00\n 4. 12:30\n 5. 16:00\n 6. 17:00\n 7. 18:30\n 8. 20:30\n");
                        // Read and parse the selected time slot for Friday
                        int horaViernes = Int32.Parse(Console.ReadLine());

                        // Evaluate the chosen time slot for Friday
                        switch (horaViernes)
                        {
                            case 1:
                                // Handle Friday appointment at 11:00
                                Console.WriteLine("Has elegido la hora 11:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesPrimero = Console.ReadLine().ToLower();

                                // pelo = hair, barba = beard, pelo y barba = hair and beard
                                if (servicioViernesPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle Friday appointment at 11:30
                                Console.WriteLine("Has elegido la hora 11:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesSegundo = Console.ReadLine().ToLower();

                                if (servicioViernesSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle Friday appointment at 12:00
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesTercero = Console.ReadLine().ToLower();

                                if (servicioViernesTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle Friday appointment at 12:30
                                Console.WriteLine("Has elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesCuarto = Console.ReadLine().ToLower();

                                if (servicioViernesCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle Friday appointment at 16:00
                                Console.WriteLine("Has elegido la hora 16:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesQuinto = Console.ReadLine().ToLower();

                                if (servicioViernesQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle Friday appointment at 17:00
                                Console.WriteLine("Hs elegido la hora 17:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesSexto = Console.ReadLine().ToLower();

                                if (servicioViernesSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle Friday appointment at 18:30
                                Console.WriteLine("Has elegido la hora 18:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesSeptimo = Console.ReadLine().ToLower();

                                if (servicioViernesSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle Friday appointment at 20:30
                                Console.WriteLine("Has elegido la hora 20:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioViernesOctavo = Console.ReadLine().ToLower();

                                if (servicioViernesOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioViernesOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioViernesOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Provide feedback for an invalid time slot selection
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Saturday appointments
                    case 6:
                        // Display available time slots for Saturday
                        Console.WriteLine("Has elegido el Sabado, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 11:30\n 2. 12:30\n 3. 13:00\n 4. 13:30\n 5. 17:00\n 6. 17:30\n 7. 18:00\n 8. 19:30\n");
                        // Read and convert the user’s input to an integer for the selected time slot
                        int horaSabado = Int32.Parse(Console.ReadLine());

                        // Evaluate the selected Saturday time slot
                        switch (horaSabado)
                        {
                            case 1:
                                // Handle appointment at 11:30 on Saturday
                                Console.WriteLine("Has elegido la hora 11:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoPrimero = Console.ReadLine().ToLower();

                                // Check service type and output corresponding price
                                if (servicioSabadoPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    // Inform the user if the service option is invalid
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle appointment at 12:30 on Saturday
                                Console.WriteLine("Has elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoSegundo = Console.ReadLine().ToLower();

                                if (servicioSabadoSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle appointment at 13:00 on Saturday
                                Console.WriteLine("Has elegido la hora 13:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoTercero = Console.ReadLine().ToLower();

                                if (servicioSabadoTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle appointment at 13:30 on Saturday
                                Console.WriteLine("Has elegido la hora 13:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoCuarto = Console.ReadLine().ToLower();

                                if (servicioSabadoCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle appointment at 17:00 on Saturday
                                Console.WriteLine("Has elegido la hora 17:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoQuinto = Console.ReadLine().ToLower();

                                if (servicioSabadoQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle appointment at 17:30 on Saturday
                                Console.WriteLine("Hs elegido la hora 17:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoSexto = Console.ReadLine().ToLower();

                                if (servicioSabadoSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle appointment at 18:00 on Saturday
                                Console.WriteLine("Has elegido la hora 18:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoSeptimo = Console.ReadLine().ToLower();

                                if (servicioSabadoSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle appointment at 19:30 on Saturday
                                Console.WriteLine("Has elegido la hora 19:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioSabadoOctavo = Console.ReadLine().ToLower();

                                if (servicioSabadoOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioSabadoOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioSabadoOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Inform the user if the chosen time slot is invalid
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    // Case for Sunday appointments
                    case 7:
                        // Display available time slots for Sunday
                        Console.WriteLine("Has elegido el Domingo, tienes estas horas disponibles");
                        Console.WriteLine(" 1. 10:00\n 2. 10:30\n 3. 11:00\n 4. 11:30\n 5. 12:00\n 6. 12:30\n 7. 16:30\n 8. 17:00\n");
                        // Read and convert the user’s input to an integer for the selected time slot
                        int horaDomingo = Int32.Parse(Console.ReadLine());

                        // Evaluate the selected Sunday time slot
                        switch (horaDomingo)
                        {
                            case 1:
                                // Handle appointment at 10:00 on Sunday
                                Console.WriteLine("Has elegido la hora 10:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoPrimero = Console.ReadLine().ToLower();

                                if (servicioDomingoPrimero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoPrimero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoPrimero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 2:
                                // Handle appointment at 10:30 on Sunday
                                Console.WriteLine("Has elegido la hora 10:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoSegundo = Console.ReadLine().ToLower();

                                if (servicioDomingoSegundo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoSegundo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoSegundo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 3:
                                // Handle appointment at 11:00 on Sunday
                                Console.WriteLine("Has elegido la hora 11:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoTercero = Console.ReadLine().ToLower();

                                if (servicioDomingoTercero == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoTercero == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoTercero == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 4:
                                // Handle appointment at 11:30 on Sunday
                                Console.WriteLine("Has elegido la hora 11:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoCuarto = Console.ReadLine().ToLower();

                                if (servicioDomingoCuarto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoCuarto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoCuarto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 5:
                                // Handle appointment at 12:00 on Sunday
                                Console.WriteLine("Has elegido la hora 12:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoQuinto = Console.ReadLine().ToLower();

                                if (servicioDomingoQuinto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoQuinto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoQuinto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 6:
                                // Handle appointment at 12:30 on Sunday
                                Console.WriteLine("Hs elegido la hora 12:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoSexto = Console.ReadLine().ToLower();

                                if (servicioDomingoSexto == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoSexto == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoSexto == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 7:
                                // Handle appointment at 16:30 on Sunday
                                Console.WriteLine("Has elegido la hora 16:30, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoSeptimo = Console.ReadLine().ToLower();

                                if (servicioDomingoSeptimo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoSeptimo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoSeptimo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            case 8:
                                // Handle appointment at 17:00 on Sunday
                                Console.WriteLine("Has elegido la hora 17:00, ¿qué será? (pelo, pelo y barba, barba)");
                                string servicioDomingoOctavo = Console.ReadLine().ToLower();

                                if (servicioDomingoOctavo == "pelo")
                                {
                                    Console.WriteLine("El precio de solo pelo son 12,50 euros");
                                }
                                else if (servicioDomingoOctavo == "pelo y barba")
                                {
                                    Console.WriteLine("El precio de pelo y barba son 16,50 euros");
                                }
                                else if (servicioDomingoOctavo == "barba")
                                {
                                    Console.WriteLine("El precio de solo barba son 4 euros");
                                }
                                else
                                {
                                    Console.WriteLine("Esa opcion no existe, por favor introduce una opcion valida");
                                }
                                break;

                            default:
                                // Inform the user if the chosen time slot is invalid
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;

                    default:
                        // Inform the user if the day selection is invalid
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                // Ask the user if they want to make another reservation
                Console.WriteLine("\n¿Quieres hacer otra reserva? (si/no)");
                respuesta = Console.ReadLine().ToLower();

            }

            // After exiting the loop, thank the user for using the application
            Console.WriteLine("\nGracias por usar la aplicacion\n");
        }
    }
}