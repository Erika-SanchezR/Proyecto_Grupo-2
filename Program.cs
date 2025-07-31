class Program
 {
 static void Main(string[] args)
 {
 Agenda agenda = new Agenda();
 int opcion;
 do
 {
 Console.WriteLine(" AGENDA DE CONTACTOS");
 Console.WriteLine("1. Agregar contacto");
 Console.WriteLine("2. Mostrar todos los contactos");
 Console.WriteLine("3. Buscar contacto");
 Console.WriteLine("4. Eliminar contacto");
 Console.WriteLine("5. Salir");
 Console.Write("Selecciona una opción: ");

 if (!int.TryParse(Console.ReadLine(), out opcion))
 {
 Console.WriteLine(" Opción inválida.\n");
 continue;
 }
 switch (opcion)
 {
 case 1:
 Console.Write("Nombre: ");
 string nombre = Console.ReadLine();
 Console.Write("Teléfono: ");
 string telefono = Console.ReadLine();
 Console.Write("Correo: ");
 string correo = Console.ReadLine();
 agenda.AgregarContacto(new Contacto(nombre, telefono, correo));
 break;
 case 2:
 agenda.MostrarContactos();
 break;
 case 3:
 Console.Write("Nombre a buscar: ");
 string buscar = Console.ReadLine();
 agenda.BuscarContacto(buscar);
 break;
 case 4:
 Console.Write("Nombre del contacto a eliminar: ");
 string eliminar = Console.ReadLine();
 agenda.EliminarContacto(eliminar);
 break;
 case 5:
 Console.WriteLine(" Saliendo del programa...");
 break;
 default:
 Console.WriteLine(" Opción no válida.");
 break;
 }
 Console.WriteLine();
 } while (opcion != 5);
 }
 }
}
