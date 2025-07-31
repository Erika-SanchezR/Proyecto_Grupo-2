class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        int opcion;
        do
        {
            Console.Clear(); 
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║         AGENDA DE CONTACTOS          ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║  1. Agregar contacto                 ║");
            Console.WriteLine("║  2. Mostrar todos los contactos      ║");
            Console.WriteLine("║  3. Buscar contacto                  ║");
            Console.WriteLine("║  4. Eliminar contacto                ║");
            Console.WriteLine("║  5. Salir                            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.Write("Selecciona una opción (1-5): ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("\n[!] Opción inválida. Presiona una tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=== AGREGAR NUEVO CONTACTO ===");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Correo: ");
                    string correo = Console.ReadLine();
                    agenda.AgregarContacto(new Contacto(nombre, telefono, correo));
                    Console.WriteLine("\n[✓] Contacto agregado. Presiona una tecla para continuar...");
                    break;
                case 2:
                    Console.WriteLine("=== LISTA DE CONTACTOS ===\n");
                    agenda.MostrarContactos();
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    break;
                case 3:
                    Console.WriteLine("=== BUSCAR CONTACTO ===");
                    Console.Write("Nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    agenda.BuscarContacto(buscar);
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    break;
                case 4:
                    Console.WriteLine("=== ELIMINAR CONTACTO ===");
                    Console.Write("Nombre del contacto a eliminar: ");
                    string eliminar = Console.ReadLine();
                    agenda.EliminarContacto(eliminar);
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    break;
                case 5:
                    Console.WriteLine("[✓] Saliendo del programa... ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("[!] Opción no válida. Presiona una tecla para continuar...");
                    break;
            }
            if (opcion != 5) Console.ReadKey();
        } while (opcion != 5);
    }
}
