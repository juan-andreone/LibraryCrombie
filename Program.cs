using System;

namespace LibraryCrombie
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenú de Biblioteca:");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Registrar Usuario");
                Console.WriteLine("3. Prestar Libro");
                Console.WriteLine("4. Devolver Libro");
                Console.WriteLine("5. Ver Estado de Todos los Libros");
                Console.WriteLine("6. Ver Libros Prestados de un Usuario");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        biblioteca.AgregarLibro();
                        break;
                    case "2":
                        biblioteca.RegistrarUsuario();
                        break;
                    case "3":
                        biblioteca.PrestarLibro();
                        break;
                    case "4":
                        biblioteca.DevolverLibro();
                        break;
                    case "5":
                        biblioteca.VerEstadoLibros();
                        break;
                    case "6":
                        biblioteca.VerLibrosPrestadosDeUsuario();
                        break;
                    case "7":
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}