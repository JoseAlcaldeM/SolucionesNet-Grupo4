using ConsoleApp2.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////POO
            #region Listas  con un tipo de dato
            ///*
            //Listas - List
            //Diccionario - Dictionary
            //colas - Queue
            //Pilas - Stack
            //*/
            //List<int> listaNumeros = new List<int>();
            //listaNumeros.Add(40);// indice 0
            //listaNumeros.Add(9);// indice 1
            //listaNumeros.Add(10);// indice 2
            ////inicializacion; validacion; incremento
            //Console.WriteLine("Lista de NÚmeros con FOR");
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    //indice[0] = 40
            //    //indice[1]= 9
            //    Console.WriteLine("Nro de indice:" + i + " - valor: " + listaNumeros[i]);
            //}
            //Console.WriteLine("Lista de Números con FOREACH");
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region MyRegion


            /*Elaborar un programa que ingrese los valores, si es cero (0) que termine su ejecución 
             y muestre todos los valores ingresados previamente*/

            //int numero = 0;
            //List<int> listaNum = new List<int>();
            //do
            //{
            //    Console.Write("Ingrese número: ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    listaNum.Add(numero);
            //} while (numero!=0);

            //Console.WriteLine("Lista de numero ingresados");
            //foreach (var item in listaNum)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Lista con clases
            //ClienteBEAN cliBEAN = new ClienteBEAN();
            //cliBEAN.Nombre = "Jose";
            //cliBEAN.Apellido = "Alcalde";

            //ClienteBEAN cliBEAN2 = new ClienteBEAN() { Nombre = "Carlos", Apellido = "Alcantara" };

            //List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            //listaCliente.Add(cliBEAN);
            //listaCliente.Add(cliBEAN2);
            //listaCliente.Add(new ClienteBEAN { Nombre= "Carol", Apellido= "Mercedes"});

            //Console.WriteLine("Lista de clientes");
            //foreach (var item in listaCliente)
            //{
            //    Console.WriteLine(item.Nombre + " " + item.Apellido);
            //}



            #endregion

            #region Diccionary- diccionario de datos
            //key - Value
            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1, "Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sábado");
            //datos.Add(7, "Domingo");

            ///*que se ingrese los valores entre 1 al 7 y que se muestre el día de la semana*/
            //Console.WriteLine("Ingrese valor");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El nombre del día es: " + datos[valor]);
            #endregion

            #region ejercicio 1

            //8 horas -> 10 soles = 80 soles
            // si es mas de  8 horas el precio por hora es 12

            Dictionary<int, int> listaCostoextra = new Dictionary<int, int>();
            listaCostoextra.Add(0, 10);
            listaCostoextra.Add(1, 12);
            listaCostoextra.Add(2, 12);
            listaCostoextra.Add(3, 12);
            listaCostoextra.Add(4, 13);
            listaCostoextra.Add(5, 13);
            listaCostoextra.Add(6, 15);
            listaCostoextra.Add(7, 15);
            listaCostoextra.Add(8, 15);


            /*ejue*/
            Console.WriteLine("Ingrese las horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            int horasExtras = 0;
            int costoHoraExtra = 0;
            int costodia = 0;
            if (horas > 8)//12
            {
                horasExtras = horas - 8;//4
                costoHoraExtra = listaCostoextra[horasExtras] * horasExtras;
                costodia = 8 * listaCostoextra[0];
            }

            else
            {
                costodia = horas * listaCostoextra[0];            
            }

            Console.WriteLine("horas trabajadas: " + "S/."  + horas);
            Console.WriteLine("Costo horas normales: " + "S/." + costodia );
            Console.WriteLine(" horas extras: " + horasExtras );
            Console.WriteLine("Costo horas extras: " + "S/."  + costoHoraExtra );
            Console.WriteLine("-------------------------------------- " );
            Console.WriteLine("pago a realizar es de: " + "S/." + (costodia + costoHoraExtra) );

            /*luego de haber calculdo el costo*/
            Dictionary<int, string> listanombre = new Dictionary<int, string>();
            listanombre.Add(1, "");
            listanombre.Add(2, "");
            listanombre.Add(3, "");
            listanombre.Add(4, "");
            listanombre.Add(5, "");
            listanombre.Add(6, "");
            listanombre.Add(7, "");
            listanombre.Add(8, "");
            


            #endregion
            Console.ReadLine();
        }


    }
}
