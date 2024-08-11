/*
 Crear una aplicación simple de consola para el siguiente escenario:

Escenario: Weather Forecast Mejorado (para una Estación Meteorológica)

Una estación meteorológica necesita gestionar y procesar datos de temperatura del interior de la cabina para un mes completo (31 días).
Los datos deben registrarse en una colección tipo matriz, donde las filas representan las semanas, y las columnas los días.
Se requiere implementar varias funcionalidades para gestionar y procesar estos datos.

----------------------------------------------------------------------------------------------------------

Para este ejercicio, se deben utilizar:
Una  5 x 7 para almacenar las temperaturas diarias del mes.
Una  para almacenar las temperaturas promedio de cada semana.
Una  para almacenar las temperaturas por encima de un cierto umbral.

-------------------Requerimientos-------------------------------------------------------------------------------
Requerimientos:
Implementar un algoritmo principal que permita la carga inicial de todas las temperaturas del mes, 31 días
(Puedes pedirle al usuario que cargue día por día, o bien simular la carga total de temperaturas).

No importa si sobran lugares en la matriz al final, sólo deberemos usar 31 lugares.

Luego mostrar al usuario un menú con las opciones (Ver siguiente). 

El usuario elije una opción y luego se le da la opción de elegir si quiere otra opción o salir, y así sucesivamente hasta que elija salir.

--------------------Opciones-------------------------------------------------------------------------------------

Opción para ver temperatura de un día específico: Aquí vamos a usar lo del escenario anterior pero cambiándole el mensaje.
Basándose en la temperatura del día elegido, la aplicación debería mostrar la temperatura y un mensaje:
 Si la temperatura es inferior a 0, mostrar "Hizo mucho frío."
 
 Si la temperatura está entre 0 y 20, mostrar "El clima estaba fresco."
 
 Si la temperatura es superior a 20, mostrar "Hizo calor afuera."

Opción para calcular y ver temperaturas promedios de cada semana.
Aquí debes usar otra colección para el almacenamiento.

Opción para encontrar y ver temperaturas por encima de 20° (Umbral).
Aquí también debes usar otra colección para el almacenamiento.

Opción para ver la temperatura promedio del mes.
Aquí puedes usar la matriz principal o la colección de promedios de cada semana.

Opción para ver la temperatura más alta. 
Aquí debes usar la matriz principal.Opción para ver la temperatura más baja. Aquí debes usar la matriz principal.

Opción para ver el pronóstico de 5 días posteriores al mes.
Aquí también debes implementar lo del ejercicio anterior,
sólo que puedes mejorar el código colocando la funcionalidad en una opción aparte.

Opción para Salir.

--------------------------------Funciones a implementar -----------------------------------------------------------------------------------

Implementar una función para añadir las temperaturas diarias.
Implementar una función para calcular las temperaturas promedio de cada semana y almacenarlas en una colección.
Implementar una función para encontrar las temperaturas por encima de un umbral (20°) y almacenarlas en una colección.
Implementar una función para calcular la temperatura promedio del mes.
Implementar una función para encontrar la temperatura más alta y la más baja.

Utilizar una matriz 5x7 para almacenar las temperaturas diarias del mes.
Utilizar una colección adecuada para almacenar las temperaturas promedio de cada semana.
Utilizar una colección que creas más conveniente para almacenar las temperaturas por encima de un cierto umbral.


Compartir el program.cs o de lo posible sólo el texto del algoritmo, en la tarea.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_obligatorio_2
{ 
    class Program
    {
        static void Main (string[] args)
        {
            bool salir = false;
            
            // Crear una matriz 5x7 para almacenar las temperaturas diarias del mes
            int[,] temperaturas = new int[5, 7];
            // Lista para almacenar las temperaturas promedio de cada semana.
            List<double> promediosSemanales = new List<double>();
            // Lista para almacenar las temperaturas por encima de un cierto umbral (20°).
            List<int> temperaturasAltas = new List<int>();

            //Cargar las temperaturas del mes
            CargarTemperaturas(temperaturas);

            while(!salir) 
            {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. ver temperatura de un día especifico.");
                Console.WriteLine("2. Calcular y ver temperaturas promedio de cada semana.");
                Console.WriteLine("3. Econtrar y ver temperaturas por encima de 20°C.");
                Console.WriteLine("4. Ver la temperatura promedio del mes.");
                Console.WriteLine("5. Ver la temperatura más alta.");
                Console.WriteLine("6. Ver la temperatura más baja.");
                Console.WriteLine("7. Ver pronostico de 5 dias posteriores al mes.");
                Console.WriteLine("8. Salir.");
                Console.Write("Elegir una opcion: ");
                string opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        VerTemperaturaDiaEspecifico(temperaturas);
                        break;
                    case "2":
                        CalcularPromediosSemanales(temperaturas, promediosSemanales);
                        VerPromediosSemanales(promediosSemanales);
                        break;
                    case "3":
                        EncontrarTemperaturasAltas(temperaturas, temperaturasAltas);
                        VerTemperaturasAltas(temperaturasAltas);
                        break;
                    case "4":
                        VerPromedioMensual(temperaturas);
                        break;
                    case "5":
                        VerTemperaturaMasAlta(temperaturas);
                        break;
                    case "6":
                        VerTemperaturaMasBaja(temperaturas);
                        break;
                    case "7":
                        VerPronostico5Dias();
                        break;
                    case "8":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;

                }
            }


        }

        //función para añadir las temperaturas diarias.
        static void CargarTemperaturas(int[,] temperaturas)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++) 
            {
                 for (int j =0; j < 7; j++)
                {
                    if (i == 4 && j >= 3) break; //utilizamos los 31 dias  *el break* permite cortar el ciclo for en j 
                    temperaturas[i, j] = random.Next(-10, 35); //genera temperaturas aleatorias de -10 a 35
                }
            }

        }

        //---------------------------------------------------------------
        //1. Funcion ver temperatura dia especifico
        static void VerTemperaturaDiaEspecifico(int[,] temperaturas)
        {
            Console.WriteLine("Ingrese el número del dia (1-31): ");
            int dia = int.Parse(Console.ReadLine());
            int semana = (dia - 1) / 7;
            int diaSemana = (dia - 1) % 7;
            int temperatura = temperaturas[semana, diaSemana];


            Console.WriteLine($"La temperatura del día {dia} fue: {temperatura}°C");
            if (temperatura < 0)
            {
                Console.WriteLine("Hizo mucho frio.");
            }
            else if (temperatura <= 20)
            {
                Console.WriteLine("El clima estaba fresco.");
            }
            else
            {
                Console.WriteLine("hizo calor afuera.");
            }
            
            
        }

        //-------------------------------------------------------------

        //2. Funcion Calcular las temperaturas promedio de cada semana
        static void CalcularPromediosSemanales(int[,] temperaturas, List<double> promediosSemanales)
        {
            promediosSemanales.Clear();
            for (int i = 0; i < 5; i++)
            {
                int suma = 0;
                int diasEnSemana = (i == 4) ? 3 : 7;
                for (int j = 0; j < diasEnSemana; j++)
                {
                    suma += temperaturas[i, j];
                }
                double promedio = (double)suma / diasEnSemana;
                promediosSemanales.Add(promedio);
            }
        }

        //2. Ver promediosSemanales
        static void VerPromediosSemanales(List<double> promediosSemanales)
        {
            for (int i = 0; i < promediosSemanales.Count; i++)
            {
                Console.WriteLine($"Temperatura promedio de la semana {i + 1}: {promediosSemanales[i]:F2}°C");
            }
        }

        //-----------------------------------------------------------------

        //3. Funcion para encontrar temperaturas alta por encima de un umbral (20°)
        static void EncontrarTemperaturasAltas(int[,] temperaturas, List<int> temperaturasAltas)
        {
            temperaturasAltas.Clear();
            foreach (int temp in temperaturas)
            {
                if (temp > 20)
                {
                    temperaturasAltas.Add(temp);
                }
            }
        }

        //3. Funcion para ver temperaturas por encima de 20°C
        static void VerTemperaturasAltas(List<int> temperaturasAltas)
        {
            Console.WriteLine("Temperaturas por encima de 20°C:");
            foreach (int temp in temperaturasAltas)
            {
                Console.WriteLine($"{temp}°C");
            }
        }

        //-----------------------------------------------------------------

        //4. Funcion calcular la temperatura promedio del mes.
        static void VerPromedioMensual(int[,] temperaturas)
        {
            int suma = 0;
            int contador = 0;
            foreach (int temp in temperaturas)
            {
                suma += temp;
                contador++;
                if (contador == 31) break; // Solo 31 días
            }
            double promedio = (double)suma / 31;
            Console.WriteLine($"Temperatura promedio del mes: {promedio:F2}°C");
        }

        //------------------------------------------------------------------

        //5.Funcion Ver temperatura mas alta
        static void VerTemperaturaMasAlta(int[,] temperaturas)
        {
            int maxTemp = int.MinValue;
            foreach (int temp in temperaturas)
            {
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }
            }
            Console.WriteLine($"La temperatura más alta del mes fue: {maxTemp}°C");
        }

        //-------------------------------------------------------------------

        //6.Funcion Ver temperatura mas baja
        static void VerTemperaturaMasBaja(int[,] temperaturas)
        {
            int minTemp = int.MaxValue;
            foreach (int temp in temperaturas)
            {
                if (temp < minTemp)
                {
                    minTemp = temp;
                }
            }
            Console.WriteLine($"La temperatura más baja del mes fue: {minTemp}°C");
        }

        //-------------------------------------------------------------------

        //7.Funcion Ver Pronostico5Dias 
        static void VerPronostico5Dias()
        {
            Random random = new Random();
            Console.WriteLine("Pronóstico de 5 días posteriores al mes:");
            for (int i = 1; i <= 5; i++)
            {
                int temp = random.Next(-10, 35);
                Console.WriteLine($"Día {i}: {temp}°C");
            }
        }

        //-------------------------------------------------------------------
    }
}