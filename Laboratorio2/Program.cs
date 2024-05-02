//using System;
/*int[] numeros = new int[10];
numeros[0] = 1; numeros[1] = 2;
numeros[2] = 3; numeros[3] = 4;
numeros[4] = 5; numeros[5] = 6;
numeros[6] = 7; numeros[7] = 8;
numeros[8] = 9; numeros[9] = 0;

var numero = numeros[3];
var cantidad = numeros.Length;

Console.WriteLine(numero.ToString() + "-" + cantidad.ToString());

Console.ReadLine();*/

/*double[] r, w;
r = new double[11];
w = new double[15];

for (int i = 0; i < r.Length; i++)
    r[i] = (double);*/

//int[,] matriz = new int[2, 2];
/*int[,] matrizd;
matrizd = new int[2, 2, 1];
matrizd[0, 0, 0]= 0; matrizd[0, 1, 0]= 1;
matrizd[1, 0, 0] = 2; matrizd[1, 1, 0] = 3;
Console.WriteLine(matrizd[1, 0].ToString());*/

/*string cadena = "clase";

char[] cadena2 = ['c', 'l', 'a', 's', 'e'];
Console.WriteLine(cadena.Length);*///como funciona la herencia y el polimorfismo

//OPERACIONES BASICAS//
/*int num1;
int num2;
int resSuma;
int resResta;
int resMultiplicación;
int resDiv;

Console.WriteLine("Ingrese el primer numero:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrse el segundo numero");
num2 = Convert.ToInt32(Console.ReadLine());

resSuma=num1+num2;
resResta=num1-num2;
resMultiplicación=num1*num2;
resDiv=num1/num2;
Console.WriteLine($"La suma es: {resSuma}");
Console.WriteLine($"La resta es: {resResta}");
Console.WriteLine($"La multiplicación es: {resMultiplicación}");
Console.WriteLine($"La división es: {resDiv}");*/

//VERIFICACIÓN DE NÚMERO PAR O IMPAR//

/*int num1;

Console.WriteLine("Ingrese un numero:");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}*/

//AREA DE UN TRIÁNGULO//

/*float a;
float b;
float arTriangulo;

Console.WriteLine("Ingrse la altura de triangulo:");
a=Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Ingrese la base del triangulo:");
b=Convert.ToSingle(Console.ReadLine());

arTriangulo = (b * a) / 2;

Console.WriteLine($"El area del triangulo es: {arTriangulo}");*/

//CALCULADORA DE FACTORIAL//

/*int n;
int factorial;

Console.WriteLine("Ingrese el factorial que deseé saber:");
n=Convert.ToInt32(Console.ReadLine());
factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial = factorial * i;
}
Console.WriteLine($"El factorial de {n} es: {factorial}");*/

//NUMERO PRIMO//

/*Console.WriteLine("Ingrese un numero:");
int n = Convert.ToInt32(Console.ReadLine());
int divisor=1, contador=0;
while (divisor <= n)
{
    if (n % divisor == 0)
    {
        contador++;
    }
    divisor++;
}
if (contador == 2)
{
       Console.WriteLine("El número es primo");
}
else
{
       Console.WriteLine("El número no es primo");
}*/
//Console.ReadKey();

//CADENA INVERTIDA//
/*string cadena = "jorge";
string cadenaInvertida = "";
for (int i =cadena.Length -1; i >= 0; i--)
{
    cadenaInvertida += cadena[i];
}
Console.WriteLine($"La cadena {cadena} invertida es: {cadenaInvertida}");*/

//SUMA DE NÚMEROS PARES//

/*Console.WriteLine("Ingrese el inicio del rango:");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el fin del rango:");
int fin = Convert.ToInt32(Console.ReadLine());

int suma = 0;

for (int num = inicio; num<= fin; num++)
{
    if (num % 2 == 0)
    {
        suma += num;
    }
}
Console.WriteLine($"La suma de los números pares en el rango de {inicio} y {fin} es: {suma}");*/

//LISTA DE CUADRADOS//

/*List<int> cuadrados = new List<int> ();

for (int i = 1; i <= 10; i++)
{
    cuadrados.Add (i*i);
}

Console.WriteLine("Los cuadrados de los primeros 10 numeros naturales son:");
foreach (int cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}*/

List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
lista.Add(9);
lista.Add(0);
lista.Add(11);

foreach (var numero in lista)
{
    Console.WriteLine($"Elemento: {numero}");
}

List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premium") };
cervezas.Add(new Cerveza(500));
cerveza erdinger = new cerveza(500, "Cerveza de trigo");
cervezas, Add(erdinger);

foreach (var cerveza in cervezas)
{
    Console.WriteLine("cerveza:" + cerveza.Name );
}








