public class Agenda
{
    private List<Contacto> contactos;
    public Agenda()
    {
        contactos = new List<Contacto>();
    }
    public void AgregarContacto(Contacto contacto)
    {
        contactos.Add(contacto);
        Console.WriteLine("✅Contacto agregado exitosamente.\n");
    }
    public void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine(" No hay contactos registrados.");
            return;
        }
        Console.WriteLine("\n Lista de Contactos:\n");
        foreach (var contacto in contactos)
        {
            contacto.Mostrar();
        }
    }
    public void BuscarContacto(string nombre)
    {
        var encontrados = contactos.Where(c =>
       c.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
        if (encontrados.Count == 0)
        {
            Console.WriteLine("❌No se encontró ningún contacto con ese nombre.");
            return;
        }
        Console.WriteLine($"\n Resultados de búsqueda para '{nombre}':\n");
        foreach (var contacto in encontrados)
        {
            contacto.Mostrar();
        }
    }
    public void EliminarContacto(string nombre)
    {
        var contacto = contactos.FirstOrDefault(c => c.Nombre.Equals(nombre,
       StringComparison.OrdinalIgnoreCase));
        if (contacto != null)
        {
            contactos.Remove(contacto);
            Console.WriteLine(" Contacto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("❌No se encontró el contacto.");
        }
    }
}
