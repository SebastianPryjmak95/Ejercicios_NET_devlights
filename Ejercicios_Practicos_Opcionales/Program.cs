/*

    
    // 1. Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
    //    sólo cuando se cumpla dicha condición.
    


    //Declaramos variable
    string linea;
    float valor;

    // Solicito un valor al usuario
    Console.WriteLine("Ingrese cualquier valor numerico");
    linea = Console.ReadLine();
    valor  = float.Parse(linea);

    if (valor > 100)
        Console.WriteLine("El valor ingresado es mayor que 100 ");

*/

//----------------------------------------------------------------------------

/*

// 2. Pedir un número entero por teclado y calcular si es par o impar.

//declaramos variables
string linea;
int num;

//Solicitamos un valor numerico al usuario
Console.WriteLine("ingrese cualquier valor numerico entero: ");
linea = Console.ReadLine();
num=int.Parse(linea);

// Comprobaremos si el numero es par o impar
if((num%2)==0)
   { Console.WriteLine($"El numero {num} ingresado es: par"); }
 else
   { Console.WriteLine($"El numero {num} ingreso es : Impar"); }

 */

//-------------------------------------------------------------------------------

/*

// 3. Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición.

//declaramos variables
string linea;
int num, doble;

//Pediremos al usuario ingresar un valor entero
Console.WriteLine("ingrese cualquier valor numerico entero: ");
linea = Console.ReadLine();
num = int.Parse(linea);

//Calcularemos el doble
doble = num + num;

if((doble%2)==0)
 {Console.WriteLine($"El numero {num}; su doble es {doble} y resulta ser par. ");}
  else
   {Console.WriteLine($"El numero {num}; su doble es {doble} y resulta ser impar. ");}

*/

//-----------------------------------------------------------------------------------------