/*using Laboratorio3;
using System;
namespace Laboratotio3
{
    class Program
    {
        static void Main(string[] args)
        {
            coche carro1 = new coche(4, 2, "Azul", 0);

            Console.WriteLine(carro1.Encendido);
            Console.WriteLine(carro1.Color);
            carro1.Encender();
            Console.WriteLine(carro1.Encendido);
        }
    }
}*/


/*int[] numeros = new int[10];
numeros[0] = 1; numeros[1] = 45;
numeros[2] = 34; numeros[3] = 4;
numeros[4] = 5; numeros[5] = 6;
numeros[6] = 7; numeros[7] = 8;
numeros[8] = 9; numeros[9] = 10;

Console.WriteLine("Elementos del arrary:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

int[] numero1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] numero2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

var numero = numero[5];
var Cantidad = numeros.Length;
Console.WriteLine(numero.ToString() + " - " + Cantidad.ToString());*/

/*int[] numero1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var cantidad1 = numero1.Length;
Console.WriteLine(cantidad1);*/

/*double[] decimales = new double[] { 1.2, 2.5, 2.8, 4.5, 3.56 };
var sumad = sumaDecimales(decimales);
Console.WriteLine(sumad.ToString());

static double sumaDecimales(double[] w)
{
    double s = 0.0;
        for (int i = 0; i < w.Length; i++)
    {
        s += w[i];
    }
    return  s;
}*/

//INICIALIZACIÓNDE UN ARRAY//

//int[] numeros = {10, 20, 30};
//int[] n = {40, 50, 60};
//char[] c = { 'l', 'u', 'i' };

//COPIA DE ARRAYS//
/*double[] r, w;
r = new double[11];
w = new double[15];
for (int i = 0; i < r.Length; i++)
{
    r[i] = (double)(2 * i - 1);

}
//Copiar valores de r a w
Array.Copy(r, w, Math.Min(r.Length, w.Length));

Console.WriteLine("Arreglo r:");
ImprimirArreglo(r);

Console.WriteLine("\nArreglo w:");
ImprimirArreglo(w);

static void ImprimirArreglo(double[] arr);
{
    for (int i = 0; i <arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
}*/

//ARRAYS MULTIDIMENSIONALES//

/*int[,] matriz = new int[2, 2];

matriz[0,0]= 0; matriz[0,1]= 1;
matriz[1,0]= 2; matriz[1,1]= 3;

Console.WriteLine("Elementos del la matriz:");
foreach (int numero in matriz)
{
    Console.WriteLine(numero);
}*/

/*string[,] ArrayCiudades = new string[2,3];
ArrayCiudades[0, 0] = "Teruel";
ArrayCiudades[0, 1] = "Huesca";
ArrayCiudades[0, 2] = "Zaragoza";
ArrayCiudades[1, 0] = "Valencia";
ArrayCiudades[1, 1] = "Castellon";
ArrayCiudades[1, 2] = "Alicante";
//PRIMERA FORMA DE IMPRIMIR//
for (int i=0; i< 2; i++)
{
    for (int j=0; j< 3; j++)
    {
        Console.WriteLine(ArrayCiudades[i, j]);
    }
}
//SEGUNDA FORMA DE IMPRIMIR EL ARRAY//
foreach (string ciudades in ArrayCiudades)
{
    Console.WriteLine(ciudades);
}*/

//CADENAS ""string""//

//string cadena = "Jorge Luis";
//string cadena1 = "Berrocal Yucra";
//char[] cadena2 = ['c', 'l', 'a', 's', 'e'];
/*Console.WriteLine(cadena.Length);
Console.WriteLine(cadena2.Length);

string resultado = string.Concat(cadena, cadena1);
Console.WriteLine(resultado);*/

/*string primerCaracter = cadena.Substring(0, 5);
string subcaracter = cadena1.Substring(0, 8);
Console.WriteLine(primerCaracter);
Console.WriteLine(subcaracter);*/

/*int indice = cadena.IndexOf("Luis");
char caracter = 'L';
int indice1 = cadena.IndexOf(caracter);
Console.WriteLine(indice1);
Console.WriteLine($"El índice de 'mundo' en la cadena es:{indice}");*/


/*string cadena1 = "jorge";
string cadena2 = "gato";

int resultado = cadena1.CompareTo(cadena2);

if (resultado < 0)
{
    Console.WriteLine("cadena1 es menor que cadena2");
}
else if (resultado == 0)
{
    Console.WriteLine("cadena1 es igual a cadena2");
}
else
{
    Console.WriteLine("cadena1 es mayor que cadena2");
}*/

//HACER UN PROGRAMA QUE PIDEA UN NMERO Y INDIQUE SI ES
//PAR O IMPAR

//DECLARAR VARIABLE
/*Console.WriteLine("====== programa que determina si es par o impar======");
Console.WriteLine("Ingrese un numero entero:");
var numeroRecibido = Console .ReadLine();
var numero = int.Parse(numeroRecibido);
var esPar = false;
//RESOLVER
if (numero%2 == 0)
{
    esPar = true;
}

//MOSTRAT RESULTADOS
Console.WriteLine(esPar? "Es par": "Es Impar");
Console.ReadLine();*/

//EJERCICIO 1//
/*double d, v, t;

Console.Write("Ingrese la velocidad:");
v = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tiempo: ");
t = int.Parse(Console.ReadLine());

d = v * t;

Console.WriteLine("La distancia es: {}")*/

//OPERACIONES BÁSICAS//
/*int a, b, sum, res, mul, div;
Console.WriteLine("Ingrese un numero: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero:");
b = int.Parse(Console.ReadLine());

sum = a + b;
res = a - b;
mul = a * b;
if (b != 0)
{
    div= a / b;
}
else
{
    Console.WriteLine("No se puede dividir entre cero");
    div = 0;
}


Console.WriteLine($"La suma es: {sum}");
Console.WriteLine($"La resta es: {res}");
Console.WriteLine($"La multiplicación es: {mul}");
Console.WriteLine($"La división es: {div}");*/






