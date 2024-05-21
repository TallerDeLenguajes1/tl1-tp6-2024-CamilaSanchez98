// using System.Globalization;
// using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);


/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
*/

int numero, resto;
int invertido = 0;
bool continuar = true;
bool parseado = false;

do
{
    Console.WriteLine("Ingrese un numero mayor a 0 para invertir:");
    // numero = Console.Read();
    // console.read() lo que hace es LEER el primer carcter ingresado por el usuario y me devuelve su ascii, luego a ese valor lo guarda en el int numero
    string numeroString = Console.ReadLine();
    parseado = int.TryParse(numeroString, out numero);

    if (parseado)
    {
        if (numero > 0)
        {
            while (numero > 0)
            {
                resto = numero % 10;
                invertido = invertido * 10 + resto;
                numero = numero / 10;
            }
            Console.WriteLine("El numero invertido es: " + invertido);
            continuar = false;
        }
        else
        {
            Console.WriteLine("El numero no es mayor a 0.");
        }
    }
    else
    {
        Console.WriteLine("Usted no ingreso un numero.");
    }
} while (continuar);

/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/

int option = 0;
int resultado = 0;
int num1, num2;
bool success, successA, successB;
string operacion="";

do
{
    Console.WriteLine("----------CALCULADORA 1 ----------");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5-Salir");
    success = int.TryParse(Console.ReadLine(), out option);

    if (success && option!=5)
    {
        Console.WriteLine("Ingrese el numero 1:");
        successA = int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        successB = int.TryParse(Console.ReadLine(), out num2);
        if (successA && successB)
        {
            switch (option)
            {case 1:
                    Console.WriteLine("Eligio la suma.");
                    resultado = num1 + num2;
                    operacion = "suma";
                    break;
                case 2:
                    Console.WriteLine("Eligio la resta.");
                    resultado = num1 - num2;
                    operacion = "resta";
                    break;
                case 3:
                    Console.WriteLine("Eligio la multiplicacion.");
                    resultado = num1 * num2;
                    operacion = "multuplicacion";
                    break;
                case 4:
                    Console.WriteLine("Eligio la division.");
                    operacion = "division";
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                        operacion = "";
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo... FIN.");
                    break;
                default:
                    Console.WriteLine("Caso default.");
                    break;
            }
            if(operacion != ""){
                Console.WriteLine("Resultado: " + resultado);
            }
            Console.WriteLine("¿Desea realizar otro cálculo? Ingrese 5 para salir:");
            int.TryParse(Console.ReadLine(), out option);
            operacion = "";
        }
        else
        {
            Console.WriteLine("No ingreso numeros validos para operar.");
        }
    }
    else
    {
        Console.WriteLine("Opcion ingresada no valida.");
    }
} while (option != 5);

/*
3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.

Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no
ingrese un número válido.
*/
int option_v2 = 1;
float num_v2;
bool flagNum1_v2;
do
{
    Console.WriteLine("----------CALCULADORA 2 ----------");
    Console.WriteLine("Ingrese un numero :");
    flagNum1_v2 = float.TryParse(Console.ReadLine(), out num_v2);

    if (flagNum1_v2)
    {
        float absNum = (float)Math.Abs(num_v2); //conversion explicita
        Console.WriteLine($"Su valor absoluto es: {absNum}");

        double cuadrado = Math.Pow(num_v2, 2);
        Console.WriteLine($"El cuadrado es: {cuadrado}");

        if (num_v2 >= 0)
        {
            double raiz = Math.Sqrt(num_v2);
            Console.WriteLine($"La raíz cuadrada es: {raiz}");
        }
        else
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
        }
        // Conversión de grados a radianes
        double numeroEnRadianes = num_v2 * (Math.PI / 180);

        double seno = Math.Sin(numeroEnRadianes);
        Console.WriteLine($"El seno es: {seno}");

        double coseno = Math.Cos(numeroEnRadianes);
        Console.WriteLine($"El coseno es: {coseno}");

        int parteEntera = (int)num_v2;
        Console.WriteLine($"La parte entera es (usando int): {parteEntera}");
        float parteEntera2 = (float)Math.Truncate(num_v2);
        Console.WriteLine($"La parte entera es (usando TRUNCATE): {parteEntera2}");
    }
    else
    {
        Console.WriteLine("Numero ingresado no valido.");
    }
    Console.WriteLine("¿Desea continuar ingresando numeros? Ingrese 0 para salir:");
    int.TryParse(Console.ReadLine(), out option_v2);
} while (option_v2 != 0);

float max, min;
float num1_v2, num2_v2;
do
{
    Console.WriteLine("-------------- MAXIMO Y MINIMO --------------------");
    Console.WriteLine("Ingrese el numero 1:");
    // success = float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out num1_v2);

    successA = float.TryParse(Console.ReadLine(), out num1_v2);
    Console.WriteLine("Ingrese el numero 2:");
    successB = float.TryParse(Console.ReadLine(), out num2_v2);
    if (successA && successB){
        if( num1_v2 == num2_v2){
            Console.WriteLine("Los numeros ingresados son iguales.");
        }else{
            max = Math.Max(num2_v2, num1_v2);
            min = Math.Min(num2_v2, num1_v2);
            Console.WriteLine($"Maximo: {max} , minimo: {min}");
        }
    }else{
        Console.WriteLine("No ingresó un numero valido.");
    }
    Console.WriteLine("¿Desea continuar ingresando numeros? Ingrese 0 para salir:");
    int.TryParse(Console.ReadLine(), out option_v2);
} while (option_v2 != 0);

/*
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes tarea:
● Obtener la longitud de la cadena y muestre por pantalla.
● A partir de una segunda cadena ingresada por el usuario, concatene ambas
cadenas distintas.
● Extraer una subcadena de la cadena ingresada.
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente.
Nota: Busque el comportamiento del Método ToString();
● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
elemento en pantalla
● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
● Convierta la cadena a mayúsculas y luego a minúsculas.
● Ingrese una cadena separada por caracteres que usted determine y muestre por
pantalla los resultados (Revisar el comportamiento de split())
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2
*/

Console.Write("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();

int longitud = cadena1.Length;
Console.WriteLine($"Longitud de la cadena: {longitud}");

Console.Write("Ingrese una segunda cadena de texto: ");
string cadena2 = Console.ReadLine();
string concatenacion = string.Concat(cadena1, cadena2);
Console.WriteLine($"Concatenación de ambas cadenas: {concatenacion}");

bool salir = false;
int inicioSubcadena;
do{
    Console.Write("Ingrese el índice de inicio para la subcadena: ");
    salir = int.TryParse(Console.ReadLine(), out inicioSubcadena);
}while(!salir);

int longitudSubcadena;
do{
    do{
        Console.Write("Ingrese la longitud de la subcadena: ");
        salir = int.TryParse(Console.ReadLine(), out longitudSubcadena);
    }while(!salir);

    if (inicioSubcadena + longitudSubcadena <= cadena1.Length)
    {
        string subcadena = cadena1.Substring(inicioSubcadena, longitudSubcadena);
        Console.WriteLine($"Subcadena extraída: {subcadena}");
    }
    else
    {
        Console.WriteLine("La longitud de la subcadena excede el rango válido.");
        salir = false;
    }
}while(!salir);


do
{
    Console.WriteLine("----------CALCULADORA 1 ----------");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5-Salir");
    success = int.TryParse(Console.ReadLine(), out option);

    if (success && option!=5)
    {
        Console.WriteLine("Ingrese el numero 1:");
        successA = int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        successB = int.TryParse(Console.ReadLine(), out num2);
        if (successA && successB)
        {
            switch (option)
            {
                case 1:
                    resultado = num1 + num2;
                    operacion = "suma";
                    break;
                case 2:
                    resultado = num1 - num2;
                    operacion = "resta";
                    break;
                case 3:
                    resultado = num1 * num2;
                    operacion = "multuplicacion";
                    break;
                case 4:
                    operacion = "division";
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                        operacion="";
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo... FIN.");
                    break;
                default:
                    Console.WriteLine("Caso default.");
                    break;
            }
            if(operacion != ""){
                Console.WriteLine($"La {operacion} de {num1} y {num2} es igual a: {resultado}");
            }
            Console.WriteLine("¿Desea realizar otro cálculo? Ingrese 5 para salir:");
            int.TryParse(Console.ReadLine(), out option);
            operacion = "";
        }
        else
        {
            Console.WriteLine("No ingreso numeros validos para operar.");
        }
    }
    else
    {
        Console.WriteLine("Opcion ingresada no valida.");
    }
} while (option != 5);

Console.WriteLine("Recorriendo la cadena de texto:");
foreach (char c in cadena1)
{
    Console.WriteLine(c);
}

Console.Write("Ingrese la palabra a buscar: ");
string palabraBuscada = Console.ReadLine();
bool contienePalabra = cadena1.Contains(palabraBuscada);
Console.WriteLine($"¿La cadena contiene la palabra '{palabraBuscada}'? {contienePalabra}");

string mayusculas = cadena1.ToUpper();
string minusculas = cadena1.ToLower();
Console.WriteLine($"Cadena en mayúsculas: {mayusculas}");
Console.WriteLine($"Cadena en minúsculas: {minusculas}");

Console.Write("Ingrese una cadena separada por comas: ");
string cadenaConComas = Console.ReadLine();
string[] elementos = cadenaConComas.Split(',');
Console.WriteLine("Elementos separados:");
foreach (string elemento in elementos)
{
    Console.WriteLine(elemento);
}

// Ecuacion
Console.Write("Ingrese una ecuación simple (ej. 582+2): ");
string ecuacion = Console.ReadLine();
char operador = ' ';
if (ecuacion.Contains("+")) operador = '+';
else if (ecuacion.Contains("-")) operador = '-';
else if (ecuacion.Contains("*")) operador = '*';
else if (ecuacion.Contains("/")) operador = '/';

string[] partes = ecuacion.Split(operador);
double numero1 = double.Parse(partes[0]);
double numero2 = double.Parse(partes[1]);
double resultado2 = 0;

switch (operador)
{
    case '+':
        resultado2 = numero1 + numero2;
        break;
    case '-':
        resultado2 = numero1 - numero2;
        break;
    case '*':
        resultado2 = numero1 * numero2;
        break;
    case '/':
        if (numero2 != 0)
            resultado2 = numero1 / numero2;
        else
            Console.WriteLine("Error: no se puede dividir por cero.");
        break;
}

if (operador != ' ')
{
    Console.WriteLine($"El resultado de {numero1} {operador} {numero2} es igual a: {resultado2}");
}
else
{
    Console.WriteLine("Operador no válido.");
}

