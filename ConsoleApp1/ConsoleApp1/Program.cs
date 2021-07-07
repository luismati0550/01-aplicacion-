using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[5, 15];
            char OP = 's';
            int op;



            while (OP == 's')
            {
                mat[0, 0] = "Nombre ";
                mat[1, 0] = "Apellido ";
                mat[2, 0] = "Direccion ";
                mat[3, 0] = "Telefono ";
                mat[4, 0] = "Correo";



                Console.WriteLine("\n 1.Ingresar Contacto\n 2.Mostrar Contactos\n 3.Buscar");
                op = int.Parse(Console.ReadLine());
