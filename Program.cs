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