
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN___UNIDAD_1___MARIO_SILVA
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Title = "| EXAMEN UNIDAD 1 | MARIO SILVA |";
                Console.WriteLine("Bienvenido al programa candelaria, seleccione con un número la cantidad de personas a las que le tocó el mono: ");
                int monos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ahora ingrese la cantidad de personas que comerán tamales (incluyendo los que les tocó mono): ");
                int personas = int.Parse(Console.ReadLine());
                Persona[] razita = new Persona[personas];
                Console.Clear();
                for (int i = 0; i < personas; i++)
                {
                    Persona p = new Persona();
                    Console.WriteLine("Indique el nombre de la persona que elegirá sus tamales: ");
                    p.Nombre = Console.ReadLine();
                    Console.WriteLine("Seleccione con un número el tipo de tamal que quiere: \n\n1.-Tamal de Carne\n2.-Tamal de Pollo\n3.-Tamal de RAjas con Queso\n4.-Tamal de elote");
                    int elección = int.Parse(Console.ReadLine());
                    if (elección > 0 && elección < 5)
                    {
                        p.Elección = elección;
                    }
                    else
                    {
                        Console.WriteLine("Opcion incorrecta, se colocará tamal de carne como opción.");
                        p.Elección = 1;
                    }
                    Console.WriteLine("Indique la cantidad de tamales que la persona consumirá: ");
                    p.Cantidad = int.Parse(Console.ReadLine());
                    razita[i] = p;
                    Console.Clear();
                }
                Console.WriteLine("Personas capturadas, presione cualquier tecla para avanzar al despliegue de datos.");
                Console.ReadKey();
                Console.Clear();
                int[] ttotales = new int[4];
                int[] ptotales = new int[4];
                int[,] precios = new int[4, 3];
                precios[0, 0] = 15;
                precios[0, 1] = 13;
                precios[0, 2] = 10;
                precios[1, 0] = 12;
                precios[1, 1] = 11;
                precios[1, 2] = 9;
                precios[2, 0] = 11;
                precios[2, 1] = 10;
                precios[2, 2] = 8;
                precios[3, 0] = 18;
                precios[3, 1] = 15;
                precios[3, 2] = 13;
                foreach (var item in razita)
                {
                    if (item.Elección == 1)
                    {
                        ttotales[0] = ttotales[0] + item.Cantidad;
                    }
                    else if (item.Elección == 2)
                    {
                        ttotales[1] = ttotales[1] + item.Cantidad;
                    }
                    else if (item.Elección == 3)
                    {
                        ttotales[2] = ttotales[2] + item.Cantidad;
                    }
                    else
                    {
                        ttotales[3] = ttotales[3] + item.Cantidad;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (ttotales[i] < 11)
                    {
                        ptotales[i] = ttotales[i] * precios[i, 0];
                    }
                    else if (ttotales[i] > 10 && ttotales[i] < 21)
                    {
                        ptotales[i] = ttotales[i] * precios[i, 1];
                    }
                    else if (ttotales[i] > 20)
                    {
                        ptotales[i] = ttotales[i] * precios[i, 2];
                    }
                }
                foreach (var item in razita)
                {
                    if (item.Elección == 1) { Console.WriteLine("| {0} | Tamales de Carne | Comerá {1} tamales", item.Nombre, item.Cantidad); }
                    else if (item.Elección == 2) { Console.WriteLine("| {0} | Tamales de Pollo | Comerá {1} tamales", item.Nombre, item.Cantidad); }
                    else if (item.Elección == 3) { Console.WriteLine("| {0} | Tamales de Rajas | Comerá {1} tamales", item.Nombre, item.Cantidad); }
                    else { Console.WriteLine("| {0} | Tamales de Elote | Comerá {1} tamales", item.Nombre, item.Cantidad); }
                }
                Console.WriteLine("Tamales de carne elegidos: {0}, precio a pagar por tamales de carne: {1}", ttotales[0], ptotales[0]);
                Console.WriteLine("Tamales de pollo elegidos: {0}, precio a pagar por tamales de pollo: {1}", ttotales[1], ptotales[1]);
                Console.WriteLine("Tamales de rajas elegidos: {0}, precio a pagar por tamales de rajas: {1}", ttotales[2], ptotales[2]);
                Console.WriteLine("Tamales de elote elegidos: {0}, precio a pagar por tamales de elote: {1}", ttotales[3], ptotales[3]);
                int CostoTotal = ptotales[0] + ptotales[1] + ptotales[2] + ptotales[3];
                int Dividido = CostoTotal / monos;
                Console.WriteLine("El total a pagar por todo es {0}, dividido entre los {1} monos es de {2}\nPresione cualquier tecla para salir", CostoTotal, monos, Dividido);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                NoJala(ex);
            }
        }
        static void NoJala(Exception ex)
        {
            Console.WriteLine("Ocurrio un error, detalles aqui: \n {0} \nPresione cualquier tecla para salir y volver a empezar",ex.Message);
            Console.ReadKey();
        }
    }
}
