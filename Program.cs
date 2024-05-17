// using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);


/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
*/

int numero,resto;
int invertido = 0;
bool continuar = true;
bool parseado = false;

do
{
    Console.WriteLine("Ingrese un numero mayor a 0 para invertir:");
    // numero = Console.Read();
    // console.read() lo que hace es LEER el primer carcter ingresado por el usuario y me devuelve su ascii, luego a ese valor lo guarda en el int numero
    string numeroString = Console.ReadLine();
    parseado = int.TryParse(numeroString,out numero);

    if(parseado){
        if(numero >0){
            while (numero > 0) {
                resto = numero % 10;
                invertido = invertido * 10 + resto;
                numero = numero/10;
            }
            Console.WriteLine("El numero invertido es: "+invertido);
            continuar = false;
        }else{
            Console.WriteLine("El numero no es mayor a 0.");
        }
    }else{
        Console.WriteLine("Usted no ingreso un numero.");
    }
}while (continuar);

/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/

int option = 0;
int resultado= 0;
int num1,num2;
bool success,successA,successB;
do
{
    Console.WriteLine("----------CALCULADORA 1 ----------");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5-Salir");
    success = int.TryParse(Console.ReadLine(), out option);

    if(success){
        Console.WriteLine("Ingrese el numero 1:");
        successA = int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        successB = int.TryParse(Console.ReadLine(), out num2);
        if( successA && successB){
            switch (option)
            {
                case 1:
                    Console.WriteLine("Eligio la suma.");
                    resultado = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine("Eligio la resta.");
                    resultado = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Eligio la multiplicacion.");
                    resultado = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Eligio la division (entre enteros).");
                    if(b == 0){
                        resultado = num1/num2;
                    }else{
                        Console.WriteLine("No e puede dividir por 0.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo... FIN.");
                    break;
                default:
                    Console.WriteLine("Caso default.");
                    break;
            }
            Console.WriteLine("Resultado: "+ resultado);
      }else{
        Console.WriteLine("No ingreso numeros validos para operar.");
      }
    }else{
        Console.WriteLine("Opcion ingresada no valida.");
    }
} while (option!=5);