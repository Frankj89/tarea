using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Progra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do  // primero ejecuta y luego evalua
            {
                Console.Clear();
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);
        }

        // 1 camisa sin descuento
        // de 2 a 5 con 15% descuento
        // mas de 5 con 20% descuento
        public static void Ejercicio1()
        {

            float precio = 0f;
            int cantidad;

            Console.WriteLine("Digite el precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)  // si la cantidad es 1            {

            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");

            }

            if (cantidad >= 2 && cantidad <= 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.15f)) * cantidad)} con descuento de 15%");

            }

            if (cantidad > 5)

            {

                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento de 20%");

            }

            Console.ReadLine();

        }

        //Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación 1.
        //Deberá leer los siguientes datos para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3,
        //tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3.
        //El programa deberá calcular el porcentaje de quices (25%), porcentaje de tareas (30%),
        //y el porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final y
        //reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas, porcentaje de exámenes,
        //promedio final y condición del estudiante. La condición del estudiante esta con base a:
        //Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y
        //menor que 70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”.
        public static void Ejercicio2()
        {

            string nombre;
            int carnet;
            double quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3 = 0f;
            double promedio;
            double nota;
            double porcentaje_quices;
            double porcentaje_tareas;
            double porcentaje_examenes;

            Console.WriteLine("Ingrese su numero de carnet");
            carnet = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese su numbre");
            nombre = Console.ReadLine();


            Console.WriteLine("Digite la calificacion de quiz1");
            quiz1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion de quiz2");
            quiz2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion de quiz3");
            quiz3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion de la tarea1");
            tarea1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la nota de la tarea2");
            tarea2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion de la tarea3");
            tarea3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion del examen1");
            examen1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion del examen2");
            examen2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite la calificacion del examen3");
            examen3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Su numero de carnet es: " + carnet);
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("la nota de quiz1 es: " + quiz1);
            Console.WriteLine("la nota de quiz2 es: " + quiz2);
            Console.WriteLine("la nota de quiz3 es: " + quiz3);
            Console.WriteLine("la nota de tarea1 es: " + tarea1);
            Console.WriteLine("la nota de tarea2 es: " + tarea2);
            Console.WriteLine("la nota de tarea3 es: " + tarea3);
            Console.WriteLine("la nota de examen1 es: " + examen1);
            Console.WriteLine("la nota de examen2 es: " + examen2);
            Console.WriteLine("la nota de examen3 es: " + examen3);

          

            porcentaje_quices = (quiz1 + quiz2 + quiz2 * 0.25f) / 100;
            Console.WriteLine("Obtuviste  " + porcentaje_quices + " % " + "  De los 3 quizes");
            porcentaje_quices = Convert.ToDouble(Console.ReadLine());



            porcentaje_tareas = (tarea1 + tarea2 + tarea3 * 0.30f) / 100;
            Console.WriteLine("Obtuviste  " + porcentaje_tareas + " % " + "  De las 3 tareas");
            porcentaje_tareas = Convert.ToDouble(Console.ReadLine());

            porcentaje_examenes = (examen1 + examen2 + examen3 * 0.45f) / 100;
            Console.WriteLine("Obtuviste  " + porcentaje_tareas + " % " + "  De los 3 examenes");
            porcentaje_examenes = Convert.ToDouble(Console.ReadLine());

            promedio = (quiz1 + quiz2 + quiz3 + tarea1 + tarea2 + tarea3 + examen1 + examen2 + examen3) / 9;

            if (promedio >= 70)
            {
                Console.WriteLine("Aprobado");
            }

            if (promedio >= 50 && promedio < 70) ;
            {
                Console.WriteLine("Aplazado");
            }

            if (promedio < 50)
            {
                Console.WriteLine("Reprobado");
            }
            
            Console.ReadLine();

        }
        

            
        public static void Ejercicio3()
        {

            float precio= 0f;
            int cantidad;
            float total=0f;

            Console.WriteLine("Digite la cantidad de productos: ");
            cantidad = int.Parse(Console.ReadLine());
            

            if (cantidad <= 10)  // se paga $20 por producto           {

            {
                Console.WriteLine($"El precio por unidad es de $20");
                Console.WriteLine($"El total a pagar es: {(((precio = 20)) * cantidad)}");
                cantidad = int.Parse(Console.ReadLine());
                precio = float.Parse(Console.ReadLine());
                total = float.Parse(Console.ReadLine());    
                total = cantidad * precio;
                

            }

            
            if (cantidad > 10) // se paga $15 por producto
            {
                Console.WriteLine($"El precio por unidad es de $15");
                Console.WriteLine($"El total a pagar es: {(((precio = 15)) * cantidad)}" );
                cantidad = int.Parse(Console.ReadLine());
                precio = float.Parse(Console.ReadLine());
                total = float.Parse(Console.ReadLine());
                total = cantidad * precio;

            }

            Console.ReadLine();
        }

    }
}

