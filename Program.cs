// // Ejercise one
// Console.WriteLine("Escriba su nombre");
// string nombre = Console.ReadLine();;
// Console.WriteLine(nombre);
// string hora = DateTime.Now.ToString("h:mm:ss tt");
// Console.WriteLine("La hora es {0}", hora);

// Ejercise two ===> conversion de datos (Convert) y dataTypes.
// Practica
string str2 = "32";
int miInt2 = Convert.ToInt32(str2);
Console.Write("str2: " + miInt2);
Console.WriteLine(" miInt2: " + miInt2);
miInt2 = miInt2 +5;
Console.WriteLine(" nuevo Int2:" + miInt2);

miInt2.ToString();
Console.WriteLine(miInt2);

Console.WriteLine("Escriba su Edad");   // Convert. de str a entero
// int edad = Convert.ToInt32(Console.ReadLine()); 

const float pi = 3.1415f;  // constante
float unFloatCuaca = pi * 2;
Console.WriteLine("El valor de pi es: " + pi + " y el de unFloatCuaca es: " + unFloatCuaca);

int? i = null; // nullable ===> al principio del datatype va ? para que su valor sea null
string? str3 = null; // nullable

// """Examen"""
//Variables
string nombre2 = "Facundo";
string apellido = "Gonzalez";
int edad2 = 23;
bool sabeProgramar = false;

// Salida de datos
Console.WriteLine("Nombre: " + nombre2 + ", Apellido: " + apellido + ", Edad: " + edad2 + ", Sabe programar: " + sabeProgramar);

// SELECCIONA LOS MEJORES DATATYPES PARA LAS SIGUIENTES VARIABLES
// Coche: puertas, ruedas, marca, ITV vigente
byte puertas = 4;
byte ruedas = 4;
string marca = "Ford";
bool itvVigente = true;
// Mesa: peso, largo, material, color
float peso = 5.5f;
float largo = 1.5f;
string material = "Madera";
string color = "Marron";

// OPERADORES 
int num = 15;
char letra = 'a';

if(num > 10 && letra == 'a'){
    Console.WriteLine("El numero es mayor a 10 y la letra es a");
}

if(num < 10 || letra == 'a'){
    Console.WriteLine("El numero no es mayor a 10 y la letra es a");
}