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

// ejercicio 3
//ESTRUCTURA DE DATOS   
// Crea una estructura de datos para un cliente con estos campos:
// Nombre completo
// Teléfono
// Dirección
// Email
// Si es nuevo cliente


Cliente misClientes = new Cliente("Carlos", 22415342, "calle siempre viva 123", "sarasa@gmail.com", true);
Console.WriteLine(misClientes.name);
public struct Cliente
{
    public Cliente(string name, int phone, string address, string email, bool isNew)
    {
        this.name = name;
        this.phone = phone;
        this.address = address;
        this.email =  email;
        this.isNew = isNew;
    }
    public string name { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool isNew { get; set; }

public override string ToString() => $"Nombre: {name}, Telefono: {phone}, Direccion: {address}, Email: {email}, Nuevo Cliente: {isNew}";

}

// ejercicio 4 BUCLES
// Ejercicio 1 - While
// Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
// Es decir, un programa que presente para el 1:
// 1 x 1 = 1
// 1 x 2 = 2
// …
// 1 x 10 = 10

namespace MisBucles
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("1 x " + i + " = " + i);
                i++;
            }
        }
    }
}
// Ejercicio 2 - Do while
// Escribe un programa que realice estos pasos:
// Reciba al menos un número por consola
// Determine si el número es positivo o negativo
// Presente un contador para cada tipo (positivo y negativo).
// Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.

namespace MibucleFor
{
    class For
    {
        static void Main(string[] args)
        {
                int contadorPositivo = 0;
                int contadorNegativo = 0;

                Console.WriteLine("Ingrese números (ingrese 0 para salir):");

        while (true)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
                break;

            if (numero > 0)
                contadorPositivo++;
            else
                contadorNegativo++;
        }
        Console.WriteLine("Cantidad de números positivos: " + contadorPositivo);
        Console.WriteLine("Cantidad de números negativos: " + contadorNegativo);

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
        }
    }
}
// Ejercicio 3 - For
// Escribe un programa que realice estos pasos:
// Reciba 3 datos:
// ancho
// alto
// relleno o no
// Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
// En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
// Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

// Input: 2,2,2, relleno = true
// Output:

// ** **

// Input: 3, 4, 1, relleno = false
// Output:

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el ancho, alto, relleno (0 para no, 1 para sí) y cantidad de figuras separados por comas:");
        string[] input = Console.ReadLine().Split(',');

        int ancho = Convert.ToInt32(input[0]);
        int alto = Convert.ToInt32(input[1]);
        bool relleno = Convert.ToInt32(input[2]) == 1;
        int cantidadFiguras = Convert.ToInt32(input[3]);

        for (int i = 0; i < cantidadFiguras; i++)
        {
            if (ancho == alto)
            {
                DibujarCuadrado(ancho, relleno);
            }
            else
            {
                DibujarRectangulo(ancho, alto, relleno);
            }

            Console.WriteLine(); // Salto de línea entre figuras
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void DibujarCuadrado(int lado, bool relleno)
    {
        Console.WriteLine("Cuadrado de lado " + lado);

        for (int i = 0; i < lado; i++)
        {
            for (int j = 0; j < lado; j++)
            {
                if (relleno || i == 0 || i == lado - 1 || j == 0 || j == lado - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void DibujarRectangulo(int ancho, int alto, bool relleno)
    {
        Console.WriteLine("Rectángulo de ancho " + ancho + " y alto " + alto);

        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                if (relleno || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}