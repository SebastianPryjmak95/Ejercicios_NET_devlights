/*
 Crear una aplicación simple de consola para el siguiente escenario:

Escenario: Weather Forecast

1. Solicitar al usuario que introduzca la temperatura actual (en grados Celsius).
2. Basándose en la temperatura introducida, la aplicación debería mostrar un mensaje:
   - Si la temperatura es inferior a 0, mostrar "Hace mucho frío afuera, asegúrate de abrigarte bien."
   - Si la temperatura está entre 0 y 20, mostrar "El clima está fresco, una chaqueta ligera sería perfecta."
   - Si la temperatura es superior a 20, mostrar "Hace calor afuera, no necesitas una chaqueta."
3. Luego, la aplicación debería preguntar al usuario si quiere conocer el pronóstico para los próximos cinco días (sí/no).
4. Si el usuario responde 'sí', la aplicación debería generar y mostrar un pronóstico simple. 
5. Finalmente, la aplicación debería preguntar al usuario si quiere consultar otro pronóstico. Si el usuario responde 'sí', la aplicación debería comenzar de nuevo. Si el usuario responde 'no', la aplicación debería mostrar un mensaje de despedida y terminar.

Compartir el program.cs o de lo posible sólo el texto del algoritmo, en la tarea.

Cualquier consulta, no duden en escribir por cualquier medio.

Saludos!

 */

//Declarar variables
int a = 1,dia = 1;
string linea, respuesta;
float temp = 0;


while(a == 1)
{
    // Solicitar al usuario que introduzca la temperatura actual
    Console.WriteLine("Ingrese la temperatura actual (en grados Celsius)");
    linea = Console.ReadLine();
    temp = float.Parse(linea);
    
    // Mostrar mensaje basado en la temperatura introducida
    if (temp <0)
     {Console.WriteLine("Hace mucho frío afuera, asegúrate de abrigarte bien.");}
      else if(temp >= 0 && temp<=20)
       {Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");}
        else 
         {Console.WriteLine("Hace calor afuera, no necesitas una chaqueta."); }
    
    
    // Preguntar si el usuario quiere conocer el pronóstico para los próximos cinco días
    Console.WriteLine("quiere conocer el pronóstico para los próximos cinco días: si / no");
    respuesta = Console.ReadLine();

    if (respuesta == "si")
    {
        // Generar y mostrar el pronóstico
        string[] pronostico = new string[5] {"24°C","12°C","15°C","27°C","24°C"};
        foreach (string i in pronostico)
        {
          Console.WriteLine($"Día {dia}:{i}");
          dia++;
        }

        //Reinicio el contador de dias para la proxima consulta
        dia = 1;
    }
    
    // Preguntar si el usuario quiere consultar otro pronóstico
    Console.WriteLine("Quiere volver consultar por otro pronóstico. responder con 'si' o 'no' ");
    respuesta = Console.ReadLine();

    if (respuesta == "si" || respuesta == "Si" || respuesta == "SI")
        a = 1;
    else
    { a = 0;
      Console.WriteLine("Gracias por usar la aplicación. ¡Hasta luego!");
    }

}
